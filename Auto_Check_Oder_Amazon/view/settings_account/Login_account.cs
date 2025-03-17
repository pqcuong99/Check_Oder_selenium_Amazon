using Auto_Check_Oder_Amazon.controller;
using Auto_Check_Oder_Amazon.controller.api.login_account;
using Auto_Check_Oder_Amazon.model.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Check_Oder_Amazon.view.settings_account
{
    public partial class Login_account : Form
    {
        public Login_account()
        {
            checkLogin();
            InitializeComponent();
        }
        public void checkLogin()
        {
            string path =  Environment.CurrentDirectory + "\\Settings\\config.txt";
            string data = FileHelper_Controller.ReadFileTxt(path);
            if (data != null) { 
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string gmail = txtGmail.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (gmail != string.Empty && pass != string.Empty) { 
                string response = await Login(gmail, pass);
                if (response != null)
                {
                    var data_Response = JsonConvert.DeserializeObject<Response_login_account>(response);

                    string path = Environment.CurrentDirectory + "\\Settings\\config.txt";
                    string content = gmail + "|" + pass + "|" + data_Response.token;
                    FileHelper_Controller.WriteFileTxt(path, content);
                }
            }
        }
        public async Task<string> Login(string gmail, string pass)
        {
            try
            {
                var response = await API_login_account.Login(gmail, pass);
                return  response.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void Login_account_Load(object sender, EventArgs e)
        {
            txtGmail.Text = "mariuszwojtkielewicz064@gmail.com";
            txtPassword.Text = "cuquki-zaxid-pokomy";
        }
    }
}
