namespace G_Sale_App
{
    partial class frm_hanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hanghoa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mahanghoa = new System.Windows.Forms.TextBox();
            this.txt_tenhanghoa = new System.Windows.Forms.TextBox();
            this.cbo_danhmuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_donvitinh = new System.Windows.Forms.ComboBox();
            this.txt_giagoc = new System.Windows.Forms.TextBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.txt_tienloi = new System.Windows.Forms.TextBox();
            this.ptb_tim = new System.Windows.Forms.PictureBox();
            this.ptb_chinhsua = new System.Windows.Forms.PictureBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_luu = new System.Windows.Forms.PictureBox();
            this.ptb_xoatrong = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgv_banghanghoa = new DevExpress.XtraGrid.GridControl();
            this.spDochanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSale_AppDataSet2 = new G_Sale_App.GSale_AppDataSet2();
            this.grv_banghanghoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmadm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiagoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltienloi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_DochanghoaTableAdapter = new G_Sale_App.GSale_AppDataSet2TableAdapters.sp_DochanghoaTableAdapter();
            this.ptb_in = new System.Windows.Forms.PictureBox();
            this.ptb_excel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banghanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDochanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSale_AppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_banghanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(383, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giá gốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(383, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(383, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tiền lời";
            // 
            // txt_mahanghoa
            // 
            this.txt_mahanghoa.Location = new System.Drawing.Point(134, 101);
            this.txt_mahanghoa.Name = "txt_mahanghoa";
            this.txt_mahanghoa.Size = new System.Drawing.Size(100, 20);
            this.txt_mahanghoa.TabIndex = 1;
            // 
            // txt_tenhanghoa
            // 
            this.txt_tenhanghoa.Location = new System.Drawing.Point(134, 142);
            this.txt_tenhanghoa.Name = "txt_tenhanghoa";
            this.txt_tenhanghoa.Size = new System.Drawing.Size(154, 20);
            this.txt_tenhanghoa.TabIndex = 2;
            // 
            // cbo_danhmuc
            // 
            this.cbo_danhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_danhmuc.FormattingEnabled = true;
            this.cbo_danhmuc.Location = new System.Drawing.Point(134, 178);
            this.cbo_danhmuc.Name = "cbo_danhmuc";
            this.cbo_danhmuc.Size = new System.Drawing.Size(154, 21);
            this.cbo_danhmuc.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(28, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Đơn vị tính";
            // 
            // cbo_donvitinh
            // 
            this.cbo_donvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvitinh.FormattingEnabled = true;
            this.cbo_donvitinh.Items.AddRange(new object[] {
            "Chai",
            "Bịt",
            "Cái",
            "Bộ",
            "Gói",
            "Cục",
            "Giỏ",
            "Kg",
            "Gram",
            "Cây",
            "Khác..."});
            this.cbo_donvitinh.Location = new System.Drawing.Point(134, 225);
            this.cbo_donvitinh.Name = "cbo_donvitinh";
            this.cbo_donvitinh.Size = new System.Drawing.Size(100, 21);
            this.cbo_donvitinh.TabIndex = 4;
            // 
            // txt_giagoc
            // 
            this.txt_giagoc.Location = new System.Drawing.Point(439, 100);
            this.txt_giagoc.Name = "txt_giagoc";
            this.txt_giagoc.Size = new System.Drawing.Size(179, 20);
            this.txt_giagoc.TabIndex = 5;
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(439, 142);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(179, 20);
            this.txt_giaban.TabIndex = 6;
            // 
            // txt_tienloi
            // 
            this.txt_tienloi.Enabled = false;
            this.txt_tienloi.Location = new System.Drawing.Point(439, 184);
            this.txt_tienloi.Name = "txt_tienloi";
            this.txt_tienloi.Size = new System.Drawing.Size(179, 20);
            this.txt_tienloi.TabIndex = 7;
            // 
            // ptb_tim
            // 
            this.ptb_tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_tim.Image = ((System.Drawing.Image)(resources.GetObject("ptb_tim.Image")));
            this.ptb_tim.Location = new System.Drawing.Point(280, 524);
            this.ptb_tim.Name = "ptb_tim";
            this.ptb_tim.Size = new System.Drawing.Size(35, 35);
            this.ptb_tim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_tim.TabIndex = 30;
            this.ptb_tim.TabStop = false;
            this.ptb_tim.Click += new System.EventHandler(this.ptb_tim_Click);
            // 
            // ptb_chinhsua
            // 
            this.ptb_chinhsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_chinhsua.Image = ((System.Drawing.Image)(resources.GetObject("ptb_chinhsua.Image")));
            this.ptb_chinhsua.Location = new System.Drawing.Point(220, 524);
            this.ptb_chinhsua.Name = "ptb_chinhsua";
            this.ptb_chinhsua.Size = new System.Drawing.Size(35, 35);
            this.ptb_chinhsua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_chinhsua.TabIndex = 26;
            this.ptb_chinhsua.TabStop = false;
            this.ptb_chinhsua.Click += new System.EventHandler(this.ptb_chinhsua_Click);
            // 
            // ptb_xoa
            // 
            this.ptb_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_xoa.Image = ((System.Drawing.Image)(resources.GetObject("ptb_xoa.Image")));
            this.ptb_xoa.Location = new System.Drawing.Point(160, 524);
            this.ptb_xoa.Name = "ptb_xoa";
            this.ptb_xoa.Size = new System.Drawing.Size(35, 35);
            this.ptb_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoa.TabIndex = 27;
            this.ptb_xoa.TabStop = false;
            this.ptb_xoa.Click += new System.EventHandler(this.ptb_xoa_Click);
            // 
            // ptb_luu
            // 
            this.ptb_luu.BackColor = System.Drawing.Color.Transparent;
            this.ptb_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_luu.Image = ((System.Drawing.Image)(resources.GetObject("ptb_luu.Image")));
            this.ptb_luu.Location = new System.Drawing.Point(100, 524);
            this.ptb_luu.Name = "ptb_luu";
            this.ptb_luu.Size = new System.Drawing.Size(35, 35);
            this.ptb_luu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_luu.TabIndex = 28;
            this.ptb_luu.TabStop = false;
            this.ptb_luu.Click += new System.EventHandler(this.ptb_luu_Click);
            // 
            // ptb_xoatrong
            // 
            this.ptb_xoatrong.BackColor = System.Drawing.Color.Transparent;
            this.ptb_xoatrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_xoatrong.Image = ((System.Drawing.Image)(resources.GetObject("ptb_xoatrong.Image")));
            this.ptb_xoatrong.Location = new System.Drawing.Point(40, 524);
            this.ptb_xoatrong.Name = "ptb_xoatrong";
            this.ptb_xoatrong.Size = new System.Drawing.Size(35, 35);
            this.ptb_xoatrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoatrong.TabIndex = 29;
            this.ptb_xoatrong.TabStop = false;
            this.ptb_xoatrong.Click += new System.EventHandler(this.ptb_xoatrong_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(546, 529);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 25);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 522);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(654, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // dgv_banghanghoa
            // 
            this.dgv_banghanghoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_banghanghoa.DataSource = this.spDochanghoaBindingSource;
            this.dgv_banghanghoa.Location = new System.Drawing.Point(0, 252);
            this.dgv_banghanghoa.MainView = this.grv_banghanghoa;
            this.dgv_banghanghoa.Name = "dgv_banghanghoa";
            this.dgv_banghanghoa.Size = new System.Drawing.Size(654, 271);
            this.dgv_banghanghoa.TabIndex = 0;
            this.dgv_banghanghoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_banghanghoa});
            // 
            // spDochanghoaBindingSource
            // 
            this.spDochanghoaBindingSource.DataMember = "sp_Dochanghoa";
            this.spDochanghoaBindingSource.DataSource = this.gSale_AppDataSet2;
            // 
            // gSale_AppDataSet2
            // 
            this.gSale_AppDataSet2.DataSetName = "GSale_AppDataSet2";
            this.gSale_AppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grv_banghanghoa
            // 
            this.grv_banghanghoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahh,
            this.coltenhh,
            this.colmadm,
            this.coldvt,
            this.colgiagoc,
            this.colgiaban,
            this.coltienloi});
            this.grv_banghanghoa.GridControl = this.dgv_banghanghoa;
            this.grv_banghanghoa.Name = "grv_banghanghoa";
            // 
            // colmahh
            // 
            this.colmahh.Caption = "Mã hàng hóa";
            this.colmahh.FieldName = "mahh";
            this.colmahh.Name = "colmahh";
            this.colmahh.Visible = true;
            this.colmahh.VisibleIndex = 0;
            this.colmahh.Width = 77;
            // 
            // coltenhh
            // 
            this.coltenhh.Caption = "Tên hàng hóa";
            this.coltenhh.FieldName = "tenhh";
            this.coltenhh.Name = "coltenhh";
            this.coltenhh.Visible = true;
            this.coltenhh.VisibleIndex = 1;
            this.coltenhh.Width = 92;
            // 
            // colmadm
            // 
            this.colmadm.Caption = "Mã danh mục hàng hóa";
            this.colmadm.FieldName = "madm";
            this.colmadm.Name = "colmadm";
            this.colmadm.Visible = true;
            this.colmadm.VisibleIndex = 2;
            this.colmadm.Width = 126;
            // 
            // coldvt
            // 
            this.coldvt.Caption = "Đơn vị tính";
            this.coldvt.FieldName = "dvt";
            this.coldvt.Name = "coldvt";
            this.coldvt.Visible = true;
            this.coldvt.VisibleIndex = 3;
            this.coldvt.Width = 66;
            // 
            // colgiagoc
            // 
            this.colgiagoc.Caption = "Giá gốc";
            this.colgiagoc.FieldName = "giagoc";
            this.colgiagoc.Name = "colgiagoc";
            this.colgiagoc.Visible = true;
            this.colgiagoc.VisibleIndex = 4;
            this.colgiagoc.Width = 87;
            // 
            // colgiaban
            // 
            this.colgiaban.Caption = "Giá bán";
            this.colgiaban.FieldName = "giaban";
            this.colgiaban.Name = "colgiaban";
            this.colgiaban.Visible = true;
            this.colgiaban.VisibleIndex = 5;
            this.colgiaban.Width = 87;
            // 
            // coltienloi
            // 
            this.coltienloi.Caption = "Tiền lời";
            this.coltienloi.FieldName = "tienloi";
            this.coltienloi.Name = "coltienloi";
            this.coltienloi.OptionsColumn.ReadOnly = true;
            this.coltienloi.Visible = true;
            this.coltienloi.VisibleIndex = 6;
            this.coltienloi.Width = 101;
            // 
            // sp_DochanghoaTableAdapter
            // 
            this.sp_DochanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // ptb_in
            // 
            this.ptb_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_in.Image = ((System.Drawing.Image)(resources.GetObject("ptb_in.Image")));
            this.ptb_in.Location = new System.Drawing.Point(340, 524);
            this.ptb_in.Name = "ptb_in";
            this.ptb_in.Size = new System.Drawing.Size(35, 35);
            this.ptb_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_in.TabIndex = 31;
            this.ptb_in.TabStop = false;
            this.ptb_in.Click += new System.EventHandler(this.ptb_in_Click);
            // 
            // ptb_excel
            // 
            this.ptb_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_excel.Image = ((System.Drawing.Image)(resources.GetObject("ptb_excel.Image")));
            this.ptb_excel.Location = new System.Drawing.Point(400, 524);
            this.ptb_excel.Name = "ptb_excel";
            this.ptb_excel.Size = new System.Drawing.Size(35, 35);
            this.ptb_excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_excel.TabIndex = 32;
            this.ptb_excel.TabStop = false;
            this.ptb_excel.Click += new System.EventHandler(this.ptb_excel_Click);
            // 
            // frm_hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 562);
            this.ControlBox = false;
            this.Controls.Add(this.ptb_excel);
            this.Controls.Add(this.ptb_in);
            this.Controls.Add(this.dgv_banghanghoa);
            this.Controls.Add(this.ptb_tim);
            this.Controls.Add(this.ptb_chinhsua);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_luu);
            this.Controls.Add(this.ptb_xoatrong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_tienloi);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_giagoc);
            this.Controls.Add(this.cbo_donvitinh);
            this.Controls.Add(this.cbo_danhmuc);
            this.Controls.Add(this.txt_tenhanghoa);
            this.Controls.Add(this.txt_mahanghoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_hanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_hanghoa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_hanghoa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banghanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDochanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSale_AppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_banghanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mahanghoa;
        private System.Windows.Forms.TextBox txt_tenhanghoa;
        private System.Windows.Forms.ComboBox cbo_danhmuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_donvitinh;
        private System.Windows.Forms.TextBox txt_giagoc;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.TextBox txt_tienloi;
        private System.Windows.Forms.PictureBox ptb_tim;
        private System.Windows.Forms.PictureBox ptb_chinhsua;
        private System.Windows.Forms.PictureBox ptb_xoa;
        private System.Windows.Forms.PictureBox ptb_luu;
        private System.Windows.Forms.PictureBox ptb_xoatrong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl dgv_banghanghoa;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_banghanghoa;
        private GSale_AppDataSet2 gSale_AppDataSet2;
        private System.Windows.Forms.BindingSource spDochanghoaBindingSource;
        private GSale_AppDataSet2TableAdapters.sp_DochanghoaTableAdapter sp_DochanghoaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmahh;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhh;
        private DevExpress.XtraGrid.Columns.GridColumn colmadm;
        private DevExpress.XtraGrid.Columns.GridColumn coldvt;
        private DevExpress.XtraGrid.Columns.GridColumn colgiagoc;
        private DevExpress.XtraGrid.Columns.GridColumn colgiaban;
        private DevExpress.XtraGrid.Columns.GridColumn coltienloi;
        private System.Windows.Forms.PictureBox ptb_in;
        private System.Windows.Forms.PictureBox ptb_excel;
    }
}