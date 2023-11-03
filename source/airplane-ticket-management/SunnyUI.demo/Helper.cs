using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sunny.UI.Demo
{
    public class Helper
    {
        public static string GetCoordinates(string address)
        {
            return "10.81879 Lat - 106.651802 Lon";
        }
        public void dbError()
        {
            string message = "Có lỗi xảy ra, vui lòng thử lại!\nNếu lỗi vẫn tiếp tục xảy ra, báo lỗi cho kỹ thuật";
            string title = "Có lỗi xảy ra";
            MessageBox.Show(message, title);
        }

        public void dbError(string exception)
        {
            string message = "Có lỗi xảy ra, vui lòng thử lại!\nNếu lỗi vẫn tiếp tục xảy ra, báo lỗi cho kỹ thuật" + exception;
            string title = "Có lỗi xảy ra";
            MessageBox.Show(message, title);
        }

        public static string GenerateBookingCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string bookingCode = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return bookingCode;
        }

        public static string GetMD5(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("X2"));
            }

            return strBuilder.ToString();
        }
        public static bool IsEmail(string input)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(input, pattern);
        }
        public static List<string> LoadProvince()
        {
            List<string> provinceLists = new List<string>
            {
                "Ha Noi", "Ha Giang", "Cao Bang", "Lao Cai", "Tuyen Quang", "Lang Son", "Bac Kan",
                "Thai Nguyen", "Phu Tho", "Vinh Phuc", "Bac Ninh", "Hai Duong", "Hai Phong",
                "Hung Yen", "Thai Binh", "Ha Nam", "Nam Dinh", "Ninh Binh", "Thanh Hoa",
                "Nghe An", "Ha Tinh", "Quang Binh", "Quang Tri", "Thua Thien Hue", "Da Nang",
                "Quang Nam", "Quang Ngai", "Binh Dinh", "Phu Yen", "Khanh Hoa", "Ninh Thuan",
                "Binh Thuan", "Kon Tum", "Gia Lai", "Dak Lak", "Dak Nong", "Lam Dong",
                "Binh Phuoc", "Tay Ninh", "Binh Duong", "Dong Nai", "Ba Ria - Vung Tau",
                "Ho Chi Minh City", "Long An", "Tien Giang", "Ben Tre", "Tra Vinh", "Vinh Long",
                "Dong Thap", "An Giang", "Kien Giang", "Can Tho", "Hau Giang", "Soc Trang",
                "Bac Lieu", "Ca Mau", "Dong Thap", "Ba Ria - Vung Tau", "Phu Yen",
                "Khanh Hoa", "Binh Thuan", "Lam Dong", "Ninh Thuan"
            };

            return provinceLists;
        }

        public static string BookingTicketMailContent(TransactionResponse response)
        {
            Content content = new Content(
                response.customer.CustomerName,
                response.BookingCode.ToString(),
                new DAO.DAO_Airline().getByPlaneId(response.flight.Airplane.AirplaneId).AirlineName.ToString(),
                response.flight.Airplane.AirplaneNumber,
                response.flight.DepartureTime.Value.ToString("HH:mm"),
                response.flight.DepartureTime.Value.ToString("dd/MM/yyyy"),
                response.flight.DeparturePoint.ToString(),
                response.flight.DepartureAirport.AirportName,
                response.flight.Destination.ToString(),
                response.flight.DestinationAirport.AirportName);
            return content.rawContent;
        }

        public static string FormatVietnameseCurrency(string amount)
        {
            if (decimal.TryParse(amount, out decimal decimalAmount))
            {
                CultureInfo cultureInfoVND = new CultureInfo("vi-VN");
                return string.Format(cultureInfoVND, "{0:C}", decimalAmount);
            }

            return "Invalid input";
        }

        public string FormatUSCurrency(string amount)
        {
            if (decimal.TryParse(amount, out decimal decimalAmount))
            {
                CultureInfo cultureInfoUSD = new CultureInfo("en-US");
                return string.Format(cultureInfoUSD, "{0:C}", decimalAmount);
            }

            return "Invalid input";
        }

    }
    public class ValidationHelper
    {
        public static bool IsEmail(string input)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsNumber(string input)
        {
            string pattern = @"^-?\d+(\.\d+)?$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsNonNegativeInteger(string input)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsInteger(string input)
        {
            string pattern = @"^-?\d+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsDecimal(string input)
        {
            string pattern = @"^-?\d+(\.\d+)?$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsAlphabetic(string input)
        {
            string pattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsPlaneCode(string input)
        {
            string pattern = @"^[A-Z]+-\d+$";
            return Regex.IsMatch(input, pattern);
        }
    }
    public class NMailer
    {
        private static readonly string _from = "mixivivu.booking@gmail.com"; // Email của Sender (của bạn)
        private static readonly string _pass = "bxpfqdyldpzjupde"; // Mật khẩu Email của Sender (của bạn)

        public static string Send(string sendto, string subject, string content)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from, "Mixivivu Booking");
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
    }
    public class Content
    {
        public string rawContent;

        public Content(string name, string bookingCode, string airlineName, string airplaneNumber, string timeFlight, string dateFlight, string departurePoint, string departureAirport, string destination, string destinationAirport)
        {
            string Header = @"<!DOCTYPE html>
                        <html lang=""vi"">
                        <head>
                            <meta charset=""UTF-8"">
                            <title>Vé máy bay</title>
                            <style>
                                * {
                                    margin: 0;
                                    padding: 0;
                                }

                                body {
                                    background-color: #333;
                                    font-family: sans-serif;
                                    font-size: 16px;
                                }

                                .container {
                                    background-color: #fff;
                                    width: 600px;
                                    margin: 0 auto;
                                    padding-left: 10px;
                                    padding-right: 10px;
                                }

                                .header {
                                    background-color: #0099ff;
                                    color: #fff;
                                    padding: 20px;
                                }

                                .header h1 {
                                    font-size: 24px;
                                    margin-bottom: 0;
                                }

                                .content {
                                    padding: 20px;
                                }

                                .content table {
                                    width: 100%;
                                    border-collapse: collapse;
                                }

                                .content table th,
                                .content table td {
                                    border: 1px solid #ccc;
                                    padding: 10px;
                                }

                                .content table th {
                                    text-align: left;
                                }

                                .content .info {
                                    margin-top: 20px;
                                }

                                .content .info p {
                                    margin-bottom: 0;
                                }

                                .content .info span {
                                    font-size: 12px;
                                }

                                .footer {
                                    background-color: #ccc;
                                    padding: 20px;
                                }
                            </style>
                        </head>";

            string Body = $@"<body>
                            <div class=""container"">
                                <center>
                                    <img width=""100%"" src=""https://cdn.discordapp.com/attachments/1100753623849377835/1169892695985115136/mixivivu2.png?ex=65570e7a&is=6544997a&hm=5dd00bfb881debdaa56ca58b57c3ae4618e5d88185ea003a089042629b03fb32&"" alt=""mixivivu"">
                                    <h1>Vé đặt chỗ điện tử của quý khách</h1>
                                </center>
        
                                <div class=""content"">
                                    <div class=""info"" style=""padding-bottom: 20px;"">
                                        <h3>Kính chào {name}</h3>
                                        <p>
                                            Yêu cầu đặt vé của quý khách đã được xác nhận thành công. Quý khách vui lòng xem vé điện tử trong tập tin đính kèm.
                                        </p>
                                    </div>
                                    <table>
                                        <tr>
                                            <th>Mã đặt chỗ</th>
                                            <td>{bookingCode}</td>
                                        </tr>
                                        <tr>
                                            <th>Hãng hàng không</th>
                                            <td>{airlineName}</td>
                                        </tr>
                                        <tr>
                                            <th>Số hiệu chuyến bay</th>
                                            <td>{airplaneNumber}</td>
                                        </tr>
                                        <tr>
                                            <th>Thời gian khởi hành</th>
                                            <td>{timeFlight}</td>
                                        </tr>
                                        <tr>
                                            <th>Ngày khởi hành</th>
                                            <td>{dateFlight}</td>
                                        </tr>
                                        <tr>
                                            <th>Thành phố khởi hành</th>
                                            <td>{departurePoint}</td>
                                        </tr>
                                        <tr>
                                            <th>Sân bay khởi hành</th>
                                            <td>{departureAirport}</td>
                                        </tr>
                                        <tr>
                                            <th>Thành phố đến</th>
                                            <td>{destination}</td>
                                        </tr>
                                        <tr>
                                            <th>Sân bay đến</th>
                                            <td>{destinationAirport}</td>
                                        </tr>
                                    </table>
                                    <div class=""info"">
                                        <p>Quý khách cần có mặt ở sân bay trước giờ bay khoảng 45 phút để tiến hành làm các thủ tục checkin, kiểm tra an ninh.</p>
                                        <span>Trân trọng,</span>
                                        <span>{airlineName}</span>
                                    </div>
                                </div>
                                <div class=""footer"">
                                    <p>© 2023 Mixivivu</p>
                                </div>
                            </div>
                        </body>

                        </html>";
            this.rawContent = Header + Body;

        }
    }
}
