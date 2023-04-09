namespace GUI_BHQA
{
    partial class Form_Khach_Hang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer ThoiGian;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Khach_Hang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVeChungToi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGioHang = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGio = new System.Windows.Forms.Label();
            ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // ThoiGian
            // 
            ThoiGian.Enabled = true;
            ThoiGian.Interval = 1000;
            ThoiGian.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.btnVeChungToi,
            this.btnTroGiup,
            this.btnGioHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(146, 36);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // btnVeChungToi
            // 
            this.btnVeChungToi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeChungToi.ForeColor = System.Drawing.Color.White;
            this.btnVeChungToi.Name = "btnVeChungToi";
            this.btnVeChungToi.Size = new System.Drawing.Size(181, 36);
            this.btnVeChungToi.Text = "Về Chúng Tôi";
            this.btnVeChungToi.Click += new System.EventHandler(this.btnVeChungToi_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroGiup.ForeColor = System.Drawing.Color.White;
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(128, 36);
            this.btnTroGiup.Text = "Trợ Giúp";
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.ForeColor = System.Drawing.Color.White;
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(137, 36);
            this.btnGioHang.Text = "Giỏ Hàng";
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox7);
            this.groupBox4.Location = new System.Drawing.Point(0, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 486);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(239, 467);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(0, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 33);
            this.label1.TabIndex = 7;
            // 
            // lblGio
            // 
            this.lblGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.ForeColor = System.Drawing.Color.Black;
            this.lblGio.Location = new System.Drawing.Point(928, 530);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(127, 33);
            this.lblGio.TabIndex = 13;
            this.lblGio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Khach_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.lblGio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Khach_Hang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Khach_Hang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVeChungToi;
        private System.Windows.Forms.ToolStripMenuItem btnTroGiup;
        private System.Windows.Forms.ToolStripMenuItem btnGioHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}