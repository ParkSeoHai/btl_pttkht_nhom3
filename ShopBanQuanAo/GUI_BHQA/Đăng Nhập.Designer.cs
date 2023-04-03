namespace GUI_BHQA
{
    partial class Đăng_Nhập
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkDangKy = new System.Windows.Forms.LinkLabel();
            this.linkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(346, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Or login With ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 96);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đăng Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkDangKy
            // 
            this.linkDangKy.AutoSize = true;
            this.linkDangKy.BackColor = System.Drawing.Color.White;
            this.linkDangKy.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDangKy.Location = new System.Drawing.Point(503, 460);
            this.linkDangKy.Name = "linkDangKy";
            this.linkDangKy.Size = new System.Drawing.Size(90, 25);
            this.linkDangKy.TabIndex = 21;
            this.linkDangKy.TabStop = true;
            this.linkDangKy.Text = "Đăng Ký";
            this.linkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangKy_LinkClicked);
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.AutoSize = true;
            this.linkQuenMatKhau.BackColor = System.Drawing.Color.White;
            this.linkQuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQuenMatKhau.Location = new System.Drawing.Point(197, 460);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(162, 25);
            this.linkQuenMatKhau.TabIndex = 20;
            this.linkQuenMatKhau.TabStop = true;
            this.linkQuenMatKhau.Text = "Quên Mật Khẩu?";
            this.linkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuenMatKhau_LinkClicked);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(202, 390);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(391, 45);
            this.txtMatKhau.TabIndex = 18;
            this.txtMatKhau.Text = "Nhập Passwork";
            this.txtMatKhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseClick);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(202, 516);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(391, 74);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.Location = new System.Drawing.Point(202, 318);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(391, 45);
            this.txtTaiKhoan.TabIndex = 15;
            this.txtTaiKhoan.Text = "Nhập tài khoản";
            this.txtTaiKhoan.WordWrap = false;
            this.txtTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTaiKhoan_MouseClick);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::GUI_BHQA.Properties.Resources.Graphics_Vibe_Hot_Burning_Social_Google_48__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(402, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 67);
            this.button2.TabIndex = 26;
            this.button2.Text = "Google ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::GUI_BHQA.Properties.Resources.Guillendesign_Variations_3_Facebook_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(180, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 67);
            this.button1.TabIndex = 25;
            this.button1.Text = "  Facebook";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI_BHQA.Properties.Resources.Icons8_Windows_8_Security_Password_2;
            this.pictureBox3.Location = new System.Drawing.Point(99, 385);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::GUI_BHQA.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(99, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI_BHQA.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(99, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::GUI_BHQA.Properties.Resources.background_mau_xanh_009_1;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(672, 776);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(672, 776);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // Đăng_Nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 776);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkDangKy);
            this.Controls.Add(this.linkQuenMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Đăng_Nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_Nhập";
            this.Load += new System.EventHandler(this.Đăng_Nhập_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkDangKy;
        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}