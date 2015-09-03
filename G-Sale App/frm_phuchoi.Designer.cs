namespace G_Sale_App
{
    partial class frm_phuchoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_phuchoi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_phuchoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.btn_chon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(266, 163);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 35);
            this.btn_thoat.TabIndex = 20;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_phuchoi
            // 
            this.btn_phuchoi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_phuchoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phuchoi.ForeColor = System.Drawing.Color.White;
            this.btn_phuchoi.Location = new System.Drawing.Point(113, 163);
            this.btn_phuchoi.Name = "btn_phuchoi";
            this.btn_phuchoi.Size = new System.Drawing.Size(80, 35);
            this.btn_phuchoi.TabIndex = 21;
            this.btn_phuchoi.Text = "Phục hồi";
            this.btn_phuchoi.UseVisualStyleBackColor = false;
            this.btn_phuchoi.Click += new System.EventHandler(this.btn_phuchoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Đường dẫn";
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duongdan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_duongdan.Location = new System.Drawing.Point(88, 113);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.Size = new System.Drawing.Size(258, 21);
            this.txt_duongdan.TabIndex = 23;
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(364, 112);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(75, 23);
            this.btn_chon.TabIndex = 24;
            this.btn_chon.Text = "Chọn tệp...";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // frm_phuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(459, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.txt_duongdan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_phuchoi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_phuchoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_phuchoi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_phuchoi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_phuchoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.Button btn_chon;
    }
}