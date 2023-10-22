using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sunny.UI.Demo
{
    public class Helper
    {
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

    }
}
