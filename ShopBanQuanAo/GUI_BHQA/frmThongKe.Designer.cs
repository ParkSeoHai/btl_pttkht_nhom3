namespace GUI_BHQA
{
    partial class frmThongKe
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
            this.btnSP_HOT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnSP_NEW = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSP_HOT
            // 
            this.btnSP_HOT.BackColor = System.Drawing.Color.White;
            this.btnSP_HOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP_HOT.Location = new System.Drawing.Point(219, 105);
            this.btnSP_HOT.Name = "btnSP_HOT";
            this.btnSP_HOT.Size = new System.Drawing.Size(341, 61);
            this.btnSP_HOT.TabIndex = 0;
            this.btnSP_HOT.Text = "SẢN PHẨM BÁN CHẠY";
            this.btnSP_HOT.UseVisualStyleBackColor = false;
            this.btnSP_HOT.Click += new System.EventHandler(this.btnSP_HOT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỨC NĂNG THỐNG KÊ";
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.Color.White;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(219, 188);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(341, 61);
            this.btnDonHang.TabIndex = 2;
            this.btnDonHang.Text = "ĐƠN ĐẶT HÀNG";
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnSP_NEW
            // 
            this.btnSP_NEW.BackColor = System.Drawing.Color.White;
            this.btnSP_NEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP_NEW.Location = new System.Drawing.Point(219, 276);
            this.btnSP_NEW.Name = "btnSP_NEW";
            this.btnSP_NEW.Size = new System.Drawing.Size(341, 61);
            this.btnSP_NEW.TabIndex = 3;
            this.btnSP_NEW.Text = "SẢN PHẨM MỚI";
            this.btnSP_NEW.UseVisualStyleBackColor = false;
            this.btnSP_NEW.Click += new System.EventHandler(this.btnSP_NEW_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(454, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 49);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(288, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 49);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSP_NEW);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSP_HOT);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSP_HOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnSP_NEW;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBack;
    }
}