namespace GUI_BHQA
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnLienHe = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnQuanLy = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnGioHang = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtQuyen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.layout_SP = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Ivory;
            this.guna2Panel1.Controls.Add(this.btnDangXuat);
            this.guna2Panel1.Controls.Add(this.btnLienHe);
            this.guna2Panel1.Controls.Add(this.btnQuanLy);
            this.guna2Panel1.Controls.Add(this.btnGioHang);
            this.guna2Panel1.Controls.Add(this.btnTrangChu);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(209, 663);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoRoundedCorners = true;
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.BorderRadius = 31;
            this.btnDangXuat.BorderThickness = 1;
            this.btnDangXuat.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnDangXuat.CheckedState.FillColor = System.Drawing.Color.Gold;
            this.btnDangXuat.CheckedState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnDangXuat.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDangXuat.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnDangXuat.HoverState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnDangXuat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImageOffset = new System.Drawing.Point(0, 10);
            this.btnDangXuat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDangXuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDangXuat.Location = new System.Drawing.Point(12, 554);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(179, 65);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnLienHe
            // 
            this.btnLienHe.AutoRoundedCorners = true;
            this.btnLienHe.BackColor = System.Drawing.Color.Transparent;
            this.btnLienHe.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLienHe.BorderRadius = 31;
            this.btnLienHe.BorderThickness = 1;
            this.btnLienHe.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLienHe.CheckedState.FillColor = System.Drawing.Color.Gold;
            this.btnLienHe.CheckedState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnLienHe.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLienHe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLienHe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLienHe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLienHe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLienHe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLienHe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLienHe.FillColor = System.Drawing.Color.Transparent;
            this.btnLienHe.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLienHe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLienHe.ForeColor = System.Drawing.Color.Black;
            this.btnLienHe.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLienHe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLienHe.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnLienHe.HoverState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnLienHe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLienHe.Image = ((System.Drawing.Image)(resources.GetObject("btnLienHe.Image")));
            this.btnLienHe.ImageOffset = new System.Drawing.Point(0, 10);
            this.btnLienHe.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLienHe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLienHe.Location = new System.Drawing.Point(12, 449);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(179, 65);
            this.btnLienHe.TabIndex = 4;
            this.btnLienHe.Text = "Liên hệ";
            this.btnLienHe.Click += new System.EventHandler(this.btnLienHe_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.AutoRoundedCorners = true;
            this.btnQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLy.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLy.BorderRadius = 31;
            this.btnQuanLy.BorderThickness = 1;
            this.btnQuanLy.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnQuanLy.CheckedState.FillColor = System.Drawing.Color.Gold;
            this.btnQuanLy.CheckedState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnQuanLy.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLy.FillColor = System.Drawing.Color.Transparent;
            this.btnQuanLy.FillColor2 = System.Drawing.Color.Transparent;
            this.btnQuanLy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLy.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnQuanLy.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnQuanLy.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnQuanLy.HoverState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnQuanLy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
            this.btnQuanLy.ImageOffset = new System.Drawing.Point(0, 10);
            this.btnQuanLy.ImageSize = new System.Drawing.Size(40, 40);
            this.btnQuanLy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuanLy.Location = new System.Drawing.Point(12, 336);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(179, 65);
            this.btnQuanLy.TabIndex = 3;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.AutoRoundedCorners = true;
            this.btnGioHang.BackColor = System.Drawing.Color.Transparent;
            this.btnGioHang.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGioHang.BorderRadius = 34;
            this.btnGioHang.BorderThickness = 1;
            this.btnGioHang.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnGioHang.CheckedState.FillColor = System.Drawing.Color.Gold;
            this.btnGioHang.CheckedState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnGioHang.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGioHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGioHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGioHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGioHang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGioHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGioHang.FillColor = System.Drawing.Color.Transparent;
            this.btnGioHang.FillColor2 = System.Drawing.Color.Transparent;
            this.btnGioHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.ForeColor = System.Drawing.Color.Black;
            this.btnGioHang.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGioHang.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnGioHang.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnGioHang.HoverState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnGioHang.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btnGioHang.Image")));
            this.btnGioHang.ImageOffset = new System.Drawing.Point(0, 10);
            this.btnGioHang.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGioHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGioHang.Location = new System.Drawing.Point(12, 228);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(179, 71);
            this.btnGioHang.TabIndex = 2;
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.BorderRadius = 33;
            this.btnTrangChu.BorderThickness = 1;
            this.btnTrangChu.Checked = true;
            this.btnTrangChu.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTrangChu.CheckedState.FillColor = System.Drawing.Color.Gold;
            this.btnTrangChu.CheckedState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnTrangChu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.FillColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnTrangChu.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnTrangChu.HoverState.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btnTrangChu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageOffset = new System.Drawing.Point(0, 10);
            this.btnTrangChu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTrangChu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTrangChu.Location = new System.Drawing.Point(12, 117);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(179, 71);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Ivory;
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(209, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(891, 43);
            this.guna2Panel2.TabIndex = 7;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(775, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(36, 35);
            this.guna2ControlBox3.TabIndex = 6;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(817, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(32, 35);
            this.guna2ControlBox2.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.CustomIconSize = 12F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(855, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 35);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtQuyen);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtTenTK);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(891, 100);
            this.guna2GroupBox1.TabIndex = 8;
            // 
            // txtQuyen
            // 
            this.txtQuyen.BackColor = System.Drawing.Color.Transparent;
            this.txtQuyen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.Location = new System.Drawing.Point(502, 52);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(194, 30);
            this.txtQuyen.TabIndex = 7;
            this.txtQuyen.Text = "Người dùng\\ Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quyền:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(191, 52);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(133, 30);
            this.txtTenTK.TabIndex = 5;
            this.txtTenTK.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chào bạn: ";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(209, 43);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(891, 100);
            this.guna2Panel3.TabIndex = 9;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.layout_SP);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(209, 143);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(891, 520);
            this.guna2Panel4.TabIndex = 10;
            // 
            // layout_SP
            // 
            this.layout_SP.AutoScroll = true;
            this.layout_SP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_SP.Location = new System.Drawing.Point(0, 0);
            this.layout_SP.Name = "layout_SP";
            this.layout_SP.Size = new System.Drawing.Size(891, 520);
            this.layout_SP.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 663);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnTrangChu;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnLienHe;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnQuanLy;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnGioHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtQuyen;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTenTK;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.FlowLayoutPanel layout_SP;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDangXuat;
    }
}