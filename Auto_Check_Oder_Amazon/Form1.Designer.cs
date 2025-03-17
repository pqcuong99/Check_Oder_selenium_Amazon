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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAcountEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbPage = new System.Windows.Forms.NumericUpDown();
            this.nbLimit = new System.Windows.Forms.NumericUpDown();
            this.btnFindProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(164, 53);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(613, 426);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // imageLogout
            // 
            this.imageLogout.Location = new System.Drawing.Point(38, 449);
            this.imageLogout.Name = "imageLogout";
            this.imageLogout.Size = new System.Drawing.Size(24, 24);
            this.imageLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLogout.TabIndex = 1;
            this.imageLogout.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logout";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnFindProfile);
            this.Controls.Add(this.nbLimit);
            this.Controls.Add(this.nbPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAcountEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageLogout);
            this.Controls.Add(this.rtbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.PictureBox imageLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAcountEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbPage;
        private System.Windows.Forms.NumericUpDown nbLimit;
        private System.Windows.Forms.Button btnFindProfile;
    }
}

