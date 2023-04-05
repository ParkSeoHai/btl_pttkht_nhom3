namespace GUI_BHQA
{
    partial class frmThongKeSP_HOT
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
            this.rpViewSP_HOT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpViewSP_HOT
            // 
            this.rpViewSP_HOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpViewSP_HOT.Location = new System.Drawing.Point(0, 0);
            this.rpViewSP_HOT.Name = "rpViewSP_HOT";
            this.rpViewSP_HOT.ServerReport.BearerToken = null;
            this.rpViewSP_HOT.Size = new System.Drawing.Size(800, 450);
            this.rpViewSP_HOT.TabIndex = 0;
            this.rpViewSP_HOT.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmThongKeSP_HOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpViewSP_HOT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongKeSP_HOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKeSP_BanChay";
            this.Load += new System.EventHandler(this.frmThongKeSP_HOT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewSP_HOT;
    }
}