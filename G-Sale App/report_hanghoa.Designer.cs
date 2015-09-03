namespace G_Sale_App
{
    partial class report_hanghoa
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
            this.crv_danhsachhanghoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_danhsachhanghoa
            // 
            this.crv_danhsachhanghoa.ActiveViewIndex = -1;
            this.crv_danhsachhanghoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_danhsachhanghoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_danhsachhanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_danhsachhanghoa.Location = new System.Drawing.Point(0, 0);
            this.crv_danhsachhanghoa.Name = "crv_danhsachhanghoa";
            this.crv_danhsachhanghoa.Size = new System.Drawing.Size(868, 471);
            this.crv_danhsachhanghoa.TabIndex = 0;
            // 
            // report_hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 471);
            this.Controls.Add(this.crv_danhsachhanghoa);
            this.Name = "report_hanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hàng hóa";
            this.Load += new System.EventHandler(this.report_hanghoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_danhsachhanghoa;
    }
}