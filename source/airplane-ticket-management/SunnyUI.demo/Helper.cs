using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
