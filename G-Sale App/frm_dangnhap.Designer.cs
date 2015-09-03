namespace G_Sale_App
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_chonnhanvien = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_eye = new System.Windows.Forms.Button();
            this.lbl_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.ptb_gsale = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.chb_quantrivien = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_gsale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_taikhoan);
            this.panel2.Location = new System.Drawing.Point(77, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 24);
            this.panel2.TabIndex = 41;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_taikhoan.Enabled = false;
            this.txt_taikhoan.ForeColor = System.Drawing.Color.Gray;
            this.txt_taikhoan.Location = new System.Drawing.Point(1, 6);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(246, 13);
            this.txt_taikhoan.TabIndex = 0;
            this.txt_taikhoan.Text = "Nhập tên tài khoản";
            this.txt_taikhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_taikhoan_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_matkhau);
            this.panel1.Location = new System.Drawing.Point(77, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 24);
            this.panel1.TabIndex = 39;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Enabled = false;
            this.txt_matkhau.ForeColor = System.Drawing.Color.Gray;
            this.txt_matkhau.Location = new System.Drawing.Point(3, 6);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(246, 13);
            this.txt_matkhau.TabIndex = 0;
            this.txt_matkhau.Tag = "";
            this.txt_matkhau.Text = "Nhập mật khẩu";
            this.txt_matkhau.UseSystemPasswordChar = true;
            this.txt_matkhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_matkhau_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbo_chonnhanvien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(48, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 66);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dành cho nhân viên bán hàng";
            // 
            // cbo_chonnhanvien
            // 
            this.cbo_chonnhanvien.BackColor = System.Drawing.Color.White;
            this.cbo_chonnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_chonnhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_chonnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_chonnhanvien.ForeColor = System.Drawing.Color.Black;
            this.cbo_chonnhanvien.FormattingEnabled = true;
            this.cbo_chonnhanvien.Items.AddRange(new object[] {
            "Chọn tên của bạn..."});
            this.cbo_chonnhanvien.Location = new System.Drawing.Point(34, 29);
            this.cbo_chonnhanvien.Name = "cbo_chonnhanvien";
            this.cbo_chonnhanvien.Size = new System.Drawing.Size(242, 23);
            this.cbo_chonnhanvien.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // btn_eye
            // 
            this.btn_eye.BackColor = System.Drawing.Color.White;
            this.btn_eye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eye.BackgroundImage")));
            this.btn_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eye.Location = new System.Drawing.Point(343, 162);
            this.btn_eye.Name = "btn_eye";
            this.btn_eye.Size = new System.Drawing.Size(32, 27);
            this.btn_eye.TabIndex = 36;
            this.btn_eye.UseVisualStyleBackColor = false;
            this.btn_eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseDown);
            this.btn_eye.MouseHover += new System.EventHandler(this.btn_eye_MouseHover);
            this.btn_eye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseUp);
            // 
            // lbl_quenmatkhau
            // 
            this.lbl_quenmatkhau.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_quenmatkhau.AutoSize = true;
            this.lbl_quenmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quenmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_quenmatkhau.DisabledLinkColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_quenmatkhau.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quenmatkhau.ForeColor = System.Drawing.Color.White;
            this.lbl_quenmatkhau.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_quenmatkhau.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_quenmatkhau.Location = new System.Drawing.Point(136, 201);
            this.lbl_quenmatkhau.Name = "lbl_quenmatkhau";
            this.lbl_quenmatkhau.Size = new System.Drawing.Size(110, 18);
            this.lbl_quenmatkhau.TabIndex = 35;
            this.lbl_quenmatkhau.TabStop = true;
            this.lbl_quenmatkhau.Text = "Quên mật khẩu";
            // 
            // ptb_gsale
            // 
            this.ptb_gsale.BackColor = System.Drawing.Color.Transparent;
            this.ptb_gsale.Image = ((System.Drawing.Image)(resources.GetObject("ptb_gsale.Image")));
            this.ptb_gsale.Location = new System.Drawing.Point(139, 12);
            this.ptb_gsale.Name = "ptb_gsale";
            this.ptb_gsale.Size = new System.Drawing.Size(115, 50);
            this.ptb_gsale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_gsale.TabIndex = 37;
            this.ptb_gsale.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(233, 344);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 35);
            this.btn_thoat.TabIndex = 34;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(64, 344);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(80, 35);
            this.btn_dangnhap.TabIndex = 33;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // chb_quantrivien
            // 
            this.chb_quantrivien.AutoSize = true;
            this.chb_quantrivien.BackColor = System.Drawing.Color.Transparent;
            this.chb_quantrivien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_quantrivien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chb_quantrivien.Location = new System.Drawing.Point(58, 89);
            this.chb_quantrivien.Name = "chb_quantrivien";
            this.chb_quantrivien.Size = new System.Drawing.Size(122, 22);
            this.chb_quantrivien.TabIndex = 43;
            this.chb_quantrivien.Text = "Quản trị viên";
            this.chb_quantrivien.UseVisualStyleBackColor = false;
            this.chb_quantrivien.CheckedChanged += new System.EventHandler(this.chb_quantrivien_CheckedChanged);
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 391);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_eye);
            this.Controls.Add(this.lbl_quenmatkhau);
            this.Controls.Add(this.ptb_gsale);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.chb_quantrivien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dangnhap_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_gsale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_chonnhanvien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_eye;
        private System.Windows.Forms.LinkLabel lbl_quenmatkhau;
        private System.Windows.Forms.PictureBox ptb_gsale;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.CheckBox chb_quantrivien;

    }
}