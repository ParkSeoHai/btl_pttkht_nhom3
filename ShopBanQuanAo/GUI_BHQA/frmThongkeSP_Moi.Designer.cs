namespace GUI_BHQA
{
    partial class frmThongkeSP_Moi
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
            this.rpViewSP_Moi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpViewSP_Moi
            // 
            this.rpViewSP_Moi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpViewSP_Moi.Location = new System.Drawing.Point(0, 0);
            this.rpViewSP_Moi.Name = "rpViewSP_Moi";
            this.rpViewSP_Moi.ServerReport.BearerToken = null;
            this.rpViewSP_Moi.Size = new System.Drawing.Size(800, 450);
            this.rpViewSP_Moi.TabIndex = 0;
            this.rpViewSP_Moi.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmThongkeSP_Moi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpViewSP_Moi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongkeSP_Moi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongkeSP_Moi";
            this.Load += new System.EventHandler(this.frmThongkeSP_Moi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewSP_Moi;
    }
}