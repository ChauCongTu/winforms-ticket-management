using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
}
