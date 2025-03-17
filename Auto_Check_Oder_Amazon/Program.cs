using Auto_Check_Oder_Amazon.controller;
using Auto_Check_Oder_Amazon.model.Login;
using Auto_Check_Oder_Amazon.view.settings_account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Check_Oder_Amazon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Kiểm tra đăng nhập trước khi chạy form chính
            string path = Environment.CurrentDirectory + "\\Settings\\config.txt";
            string data = FileHelper_Controller.ReadFileTxt(path);
            if (data != null)
            {
                LoginData.Token = data.Split('|')[2];
                LoginData.Email = data.Split('|')[0];
                Application.Run(new Form1()); // Chạy Form1 nếu đăng nhập thành công
            }
            else
            {
                Application.Run(new Login_account()); // Chạy Login_account nếu chưa đăng nhập
            }
        }
    }
}
