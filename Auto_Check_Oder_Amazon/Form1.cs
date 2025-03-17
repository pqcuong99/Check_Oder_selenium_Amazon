using Auto_Check_Oder_Amazon.model.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Check_Oder_Amazon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            imageLogout.MouseEnter += ImageLogout_MouseEnter;
            imageLogout.MouseLeave += ImageLogout_MouseLeave;
            imageLogout.Paint += ImageLogout_Paint;

            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
        }

        #region event_logout

        private void ImageLogout_Paint(object sender, PaintEventArgs e)
        {
            //if (imageLogout.BorderStyle == BorderStyle.Fixed3D)
            //{
            //    using (Pen pen = new Pen(Color.Red, 2)) // Màu đỏ, độ dày 2px
            //    {
            //        e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, imageLogout.Width - 1, imageLogout.Height - 1));
            //    }
            //}
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.None;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ImageLogout_MouseLeave(object sender, EventArgs e)
        {
            imageLogout.BorderStyle = BorderStyle.None;
            imageLogout.Invalidate();
        }

        private void ImageLogout_MouseEnter(object sender, EventArgs e)
        {
            imageLogout.BorderStyle = BorderStyle.Fixed3D;
            imageLogout.Invalidate();
        }
        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "..\\..\\view\\images\\logout.png");
            path = Path.GetFullPath(path); // Chuyển đổi đường dẫn tương đối thành đường dẫn tuyệt đối
            imageLogout.Image = Image.FromFile(path);

            lbAcountEmail.Text = TruncateString(LoginData.Email);
            this.Text = LoginData.Email;
        }
        public  string TruncateString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return input.Length > 20 ? input.Substring(0, 17) + "..." : input;
        }
    }
}
