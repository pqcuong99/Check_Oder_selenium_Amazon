namespace Auto_Check_Oder_Amazon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.imageLogout = new System.Windows.Forms.PictureBox();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbAcountEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbPage = new System.Windows.Forms.NumericUpDown();
            this.nbLimit = new System.Windows.Forms.NumericUpDown();
            this.btnFindProfile = new System.Windows.Forms.Button();
            this.grvListProfile = new System.Windows.Forms.DataGridView();
            this.pnLoad = new System.Windows.Forms.Panel();
            this.lbLoading = new System.Windows.Forms.Label();
            this.btnStartAuto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nbThread = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListProfile)).BeginInit();
            this.pnLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbThread)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(0, 3);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(584, 401);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            this.rtbData.Visible = false;
            // 
            // imageLogout
            // 
            this.imageLogout.Location = new System.Drawing.Point(38, 449);
            this.imageLogout.Name = "imageLogout";
            this.imageLogout.Size = new System.Drawing.Size(24, 24);
            this.imageLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLogout.TabIndex = 1;
            this.imageLogout.TabStop = false;
            this.imageLogout.Click += new System.EventHandler(this.imageLogout_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.Location = new System.Drawing.Point(68, 452);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(58, 17);
            this.lbLogout.TabIndex = 2;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbAcountEmail
            // 
            this.lbAcountEmail.AutoSize = true;
            this.lbAcountEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcountEmail.Location = new System.Drawing.Point(12, 418);
            this.lbAcountEmail.Name = "lbAcountEmail";
            this.lbAcountEmail.Size = new System.Drawing.Size(51, 15);
            this.lbAcountEmail.TabIndex = 3;
            this.lbAcountEmail.Text = "Logout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limit";
            // 
            // nbPage
            // 
            this.nbPage.Location = new System.Drawing.Point(532, 26);
            this.nbPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPage.Name = "nbPage";
            this.nbPage.Size = new System.Drawing.Size(53, 20);
            this.nbPage.TabIndex = 6;
            this.nbPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbLimit
            // 
            this.nbLimit.Location = new System.Drawing.Point(620, 26);
            this.nbLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbLimit.Name = "nbLimit";
            this.nbLimit.Size = new System.Drawing.Size(56, 20);
            this.nbLimit.TabIndex = 7;
            this.nbLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnFindProfile
            // 
            this.btnFindProfile.Location = new System.Drawing.Point(693, 23);
            this.btnFindProfile.Name = "btnFindProfile";
            this.btnFindProfile.Size = new System.Drawing.Size(75, 23);
            this.btnFindProfile.TabIndex = 8;
            this.btnFindProfile.Text = "Find profile";
            this.btnFindProfile.UseVisualStyleBackColor = true;
            // 
            // grvListProfile
            // 
            this.grvListProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListProfile.Location = new System.Drawing.Point(3, 4);
            this.grvListProfile.Name = "grvListProfile";
            this.grvListProfile.Size = new System.Drawing.Size(581, 401);
            this.grvListProfile.TabIndex = 9;
            this.grvListProfile.Visible = false;
            // 
            // pnLoad
            // 
            this.pnLoad.Controls.Add(this.lbLoading);
            this.pnLoad.Controls.Add(this.grvListProfile);
            this.pnLoad.Controls.Add(this.rtbData);
            this.pnLoad.Location = new System.Drawing.Point(181, 65);
            this.pnLoad.Name = "pnLoad";
            this.pnLoad.Size = new System.Drawing.Size(587, 408);
            this.pnLoad.TabIndex = 10;
            this.pnLoad.Visible = false;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.Location = new System.Drawing.Point(270, 170);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(89, 22);
            this.lbLoading.TabIndex = 0;
            this.lbLoading.Text = "Loading...";
            this.lbLoading.Visible = false;
            // 
            // btnStartAuto
            // 
            this.btnStartAuto.Location = new System.Drawing.Point(15, 134);
            this.btnStartAuto.Name = "btnStartAuto";
            this.btnStartAuto.Size = new System.Drawing.Size(143, 30);
            this.btnStartAuto.TabIndex = 11;
            this.btnStartAuto.Text = "Start auto";
            this.btnStartAuto.UseVisualStyleBackColor = true;
            this.btnStartAuto.Click += new System.EventHandler(this.btnStartAuto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thread";
            // 
            // nbThread
            // 
            this.nbThread.Location = new System.Drawing.Point(80, 99);
            this.nbThread.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbThread.Name = "nbThread";
            this.nbThread.Size = new System.Drawing.Size(78, 20);
            this.nbThread.TabIndex = 14;
            this.nbThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.nbThread);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartAuto);
            this.Controls.Add(this.pnLoad);
            this.Controls.Add(this.btnFindProfile);
            this.Controls.Add(this.nbLimit);
            this.Controls.Add(this.nbPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAcountEmail);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.imageLogout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListProfile)).EndInit();
            this.pnLoad.ResumeLayout(false);
            this.pnLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbThread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.PictureBox imageLogout;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbAcountEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbPage;
        private System.Windows.Forms.NumericUpDown nbLimit;
        private System.Windows.Forms.Button btnFindProfile;
        private System.Windows.Forms.DataGridView grvListProfile;
        private System.Windows.Forms.Panel pnLoad;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.Button btnStartAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbThread;
    }
}

