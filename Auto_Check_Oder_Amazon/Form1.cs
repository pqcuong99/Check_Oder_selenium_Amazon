using Auto_Check_Oder_Amazon.controller;
using Auto_Check_Oder_Amazon.controller.automation;
using Auto_Check_Oder_Amazon.model.Dolphin_info;
using Auto_Check_Oder_Amazon.model.Login;
using Auto_Check_Oder_Amazon.view.dashbroad;
using Auto_Check_Oder_Amazon.view.settings_account;
using Newtonsoft.Json;
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
        private List<DataItemProfile> selectedItems = new List<DataItemProfile>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

            imageLogout.MouseEnter += ImageLogout_MouseEnter;
            imageLogout.MouseLeave += ImageLogout_MouseLeave;
            imageLogout.Paint += ImageLogout_Paint;

            lbLogout.MouseEnter += label1_MouseEnter;
            lbLogout.MouseLeave += label1_MouseLeave;

            grvListProfile.CellClick += GrvListProfile_CellClick;
            
        }

        private void GrvListProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Chỉ xử lý khi click vào cột CheckBox
            {
                DataGridViewRow row = grvListProfile.Rows[e.RowIndex];
                bool isChecked = (bool)row.Cells["CheckBoxColumn"].Value;

                // Đảo ngược trạng thái CheckBox
                row.Cells["CheckBoxColumn"].Value = !isChecked;

                // Lấy dữ liệu từ dòng
                DataItemProfile item = new DataItemProfile
                {
                    Name = row.Cells["Name"].Value.ToString(),
                    Platform = row.Cells["Platform"].Value.ToString(),
                    ID_Profile = row.Cells["ID_Profile"].Value.ToString(),
                    MainWebsite = row.Cells["MainWebsite"].Value.ToString()
                };

                // Thêm hoặc xóa khỏi danh sách
                if (!isChecked)
                {
                    selectedItems.Add(item);
                }
                else
                {
                    selectedItems.Remove(item);
                }
            }
        }

        private void InitializeDataGridView()
        {
            // Xóa các cột mặc định (nếu có)
            grvListProfile.Columns.Clear();

            // Thêm cột CheckBox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "All";
            checkBoxColumn.Name = "CheckBoxColumn";
            grvListProfile.Columns.Add(checkBoxColumn);

            // Thêm các cột khác
            grvListProfile.Columns.Add("Name", "Name");
            grvListProfile.Columns.Add("Platform", "Platform");
            grvListProfile.Columns.Add("ID_Profile", "ID Profile");
            grvListProfile.Columns.Add("MainWebsite", "Main Website");

            // Thiết lập các thuộc tính cho DataGridView
            grvListProfile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvListProfile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvListProfile.MultiSelect = false;

            // Gắn sự kiện CellPainting để vẽ CheckBox trong header
            grvListProfile.CellPainting += GrvListProfile_CellPainting;
            grvListProfile.CellContentClick += GrvListProfile_CellContentClick;
        }

        private void GrvListProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == grvListProfile.Columns["CheckBoxColumn"].Index)
            {
                grvListProfile.EndEdit();
            }
        } 

        private void GrvListProfile_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == grvListProfile.Columns["CheckBoxColumn"].Index)
            {
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);

                // Tạo CheckBox
                CheckBox checkBoxAll = new CheckBox();
                checkBoxAll.Size = new Size(20, 20);
                checkBoxAll.Location = new Point(
                    e.CellBounds.X + (e.CellBounds.Width - checkBoxAll.Width) / 2,
                    e.CellBounds.Y + (e.CellBounds.Height - checkBoxAll.Height) / 2
                );
                checkBoxAll.CheckedChanged += CheckBoxAll_CheckedChanged;

                // Vẽ CheckBox vào header
                DataGridView grid = sender as DataGridView;
                if (grid != null)
                {
                    grid.Controls.Add(checkBoxAll);
                }

                e.Handled = true;
            }
        }

        private void AddCheckBoxHeader()
        {
            // Tạo một Panel để chứa CheckBox
            Panel panel = new Panel();
            panel.Size = new Size(20, 20); // Kích thước của Panel
            panel.Location = new Point(3, 3); // Vị trí của Panel trong header

            // Tạo CheckBox
            CheckBox checkBoxAll = new CheckBox();
            checkBoxAll.Size = new Size(20, 20); // Kích thước của CheckBox
            checkBoxAll.CheckedChanged += CheckBoxAll_CheckedChanged; ; // Gắn sự kiện

            // Thêm CheckBox vào Panel
            panel.Controls.Add(checkBoxAll);
             
            // Thêm Panel vào header của cột "Select"
            grvListProfile.Columns["CheckBoxColumn"].HeaderCell.Style.Padding = new Padding(panel.Width + 2, 0, 0, 0);
            grvListProfile.Controls.Add(panel);
        }

        private void CheckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxAll = sender as CheckBox;
            if (checkBoxAll != null)
            {
                bool isChecked = checkBoxAll.Checked;

                // Xóa danh sách hiện tại nếu bỏ tích
                if (!isChecked)
                {
                    selectedItems.Clear();
                }
                else
                {
                    // Thêm tất cả các item vào danh sách nếu tích
                    foreach (DataGridViewRow row in grvListProfile.Rows)
                    {
                        if (!row.IsNewRow) // Đảm bảo không xử lý dòng trống
                        {
                            DataItemProfile item = new DataItemProfile
                            {
                                Name = row.Cells["Name"].Value.ToString(),
                                Platform = row.Cells["Platform"].Value.ToString(),
                                ID_Profile = row.Cells["ID_Profile"].Value.ToString(),
                                MainWebsite = row.Cells["MainWebsite"].Value.ToString()
                            };

                            // Kiểm tra xem item đã tồn tại trong danh sách chưa
                            if (!selectedItems.Contains(item))
                            {
                                selectedItems.Add(item);
                            }
                        }
                    }
                }

                // Cập nhật trạng thái CheckBox trong các dòng
                foreach (DataGridViewRow row in grvListProfile.Rows)
                {
                    if (!row.IsNewRow) // Đảm bảo không xử lý dòng trống
                    {
                        row.Cells["CheckBoxColumn"].Value = isChecked;
                    }
                }
            }
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
            lbLogout.BorderStyle = BorderStyle.None;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lbLogout.BorderStyle = BorderStyle.FixedSingle;
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            pnLoad.Visible = true;
            lbLoading.Visible = true;
            lbLoading.Text = "Please wait...";

            string path = Path.Combine(Environment.CurrentDirectory, "..\\..\\view\\images\\logout.png");
            path = Path.GetFullPath(path); // Chuyển đổi đường dẫn tương đối thành đường dẫn tuyệt đối
            imageLogout.Image = Image.FromFile(path);

            lbAcountEmail.Text = TruncateString(LoginData.Email);
            this.Text = LoginData.Email;
            grvListProfile.AllowUserToAddRows = false;
            
            bool isGetData = await Getdata();
            if (isGetData) {
                SetVisibleListData(false);
                lbLoading.Visible = false;
            }
            else
            {
                lbLoading.Visible = true;
                lbLoading.Text = "Out session, please logout";
            }
            
            
        }
        public void SetVisibleListData(bool visible)
        {
            rtbData.Visible = visible ? true : false;
            grvListProfile.Visible = visible ? false : true;
        }
        public async Task<bool> Getdata()
        {
            DashbroadController dashbroad = new DashbroadController();
            var dataProfiles = await dashbroad.GetDataProfiles(1, 100);
            if(dataProfiles.Count > 0)
            {
                foreach (var profile in dataProfiles)
                {
                    grvListProfile.Rows.Add(false, profile.Name, profile.Platform, profile.ID_Profile, profile.MainWebsite);
                }
                return true;
            }
            
            return false;
        }
        public  string TruncateString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return input.Length > 20 ? input.Substring(0, 17) + "..." : input;
        }

        private async void btnStartAuto_Click(object sender, EventArgs e)
        {
            await RunAutoCheckOders();
        }
        public async Task RunAutoCheckOders()
        {
            //foreach (var profile in selectedItems)
            //{
            //    Script_check_oder script_Check_Oder = new Script_check_oder();
            //    string response = await script_Check_Oder.StartBrowser(Int32.Parse(profile.ID_Profile));
            //    if (response != null)
            //    {
            //        var convertResponse = JsonConvert.DeserializeObject< Startbrowser >(response);
            //        await script_Check_Oder.StartAuto(convertResponse.automation.wsEndpoint);
            //    }
            //}

            //   /devtools/browser/0a8c0f06-96dc-4217-a8f2-c02b683cfa24
            Script_check_oder script_Check_Oder = new Script_check_oder();
            //await script_Check_Oder.StartAuto("/devtools/browser/0a8c0f06-96dc-4217-a8f2-c02b683cfa24");
            await script_Check_Oder.StartAuto2(55345);
        }

        private void imageLogout_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Settings\\config.txt";
            FileHelper_Controller.DeleteFile(path);
            Login_account login_Account = new Login_account();
            login_Account.FormClosed += Login_Account_FormClosed;
            this.Hide(); // Ẩn form Login_account
            login_Account.Show(); // Hiển thị Form1
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Settings\\config.txt";
            FileHelper_Controller.DeleteFile(path);
            Login_account login_Account = new Login_account();
            login_Account.FormClosed += Login_Account_FormClosed;
            this.Hide(); // Ẩn form Login_account
            login_Account.Show(); // Hiển thị Form1
        }

        private void Login_Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
