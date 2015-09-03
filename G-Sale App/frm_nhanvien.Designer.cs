namespace G_Sale_App
{
    partial class frm_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nhanvien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.cbo_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.cbo_loaicongviec = new System.Windows.Forms.ComboBox();
            this.txt_lcb = new System.Windows.Forms.TextBox();
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptb_tim = new System.Windows.Forms.PictureBox();
            this.ptb_chinhsua = new System.Windows.Forms.PictureBox();
            this.ptb_luu = new System.Windows.Forms.PictureBox();
            this.ptb_xoatrong = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_gioitinh = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BindingSource_Nhanvien = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_bangnhanvien = new DevExpress.XtraGrid.GridControl();
            this.BindingSource_Nhanvien_Proc = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Nhanvien = new G_Sale_App.GSale_AppDataSet();
            this.grv_nhanvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmanv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquequan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloaicongviec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collcb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adapter_Nhanvien = new G_Sale_App.GSale_AppDataSetTableAdapters.sp_DocnhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Nhanvien_Proc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.Items.AddRange(new object[] {
            "Đang làm việc",
            "Đã nghỉ việc"});
            this.cbo_tinhtrang.Location = new System.Drawing.Point(153, 194);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(121, 21);
            this.cbo_tinhtrang.TabIndex = 4;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(453, 26);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(225, 20);
            this.txt_cmnd.TabIndex = 5;
            // 
            // cbo_loaicongviec
            // 
            this.cbo_loaicongviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaicongviec.FormattingEnabled = true;
            this.cbo_loaicongviec.Items.AddRange(new object[] {
            "Bán Hàng",
            "Thủ Kho",
            "Thủ Quỹ",
            "Giao Hàng",
            "Khác"});
            this.cbo_loaicongviec.Location = new System.Drawing.Point(453, 60);
            this.cbo_loaicongviec.Name = "cbo_loaicongviec";
            this.cbo_loaicongviec.Size = new System.Drawing.Size(225, 21);
            this.cbo_loaicongviec.TabIndex = 6;
            // 
            // txt_lcb
            // 
            this.txt_lcb.Location = new System.Drawing.Point(453, 107);
            this.txt_lcb.Name = "txt_lcb";
            this.txt_lcb.Size = new System.Drawing.Size(225, 20);
            this.txt_lcb.TabIndex = 7;
            // 
            // txt_quequan
            // 
            this.txt_quequan.Location = new System.Drawing.Point(453, 154);
            this.txt_quequan.Multiline = true;
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(225, 56);
            this.txt_quequan.TabIndex = 8;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(108, 109);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaysinh.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(108, 63);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(200, 20);
            this.txt_hoten.TabIndex = 1;
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(108, 25);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 20);
            this.txt_manv.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Lương Căn Băn (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Loại Công Việc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "CMND (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Quê Quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tình Trạng Hoạt Động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Họ Tên (*)";
            // 
            // ptb_tim
            // 
            this.ptb_tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_tim.Image = ((System.Drawing.Image)(resources.GetObject("ptb_tim.Image")));
            this.ptb_tim.Location = new System.Drawing.Point(220, 560);
            this.ptb_tim.Name = "ptb_tim";
            this.ptb_tim.Size = new System.Drawing.Size(35, 35);
            this.ptb_tim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_tim.TabIndex = 32;
            this.ptb_tim.TabStop = false;
            this.ptb_tim.Click += new System.EventHandler(this.ptb_tim_Click);
            // 
            // ptb_chinhsua
            // 
            this.ptb_chinhsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_chinhsua.Image = ((System.Drawing.Image)(resources.GetObject("ptb_chinhsua.Image")));
            this.ptb_chinhsua.Location = new System.Drawing.Point(160, 560);
            this.ptb_chinhsua.Name = "ptb_chinhsua";
            this.ptb_chinhsua.Size = new System.Drawing.Size(35, 35);
            this.ptb_chinhsua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_chinhsua.TabIndex = 28;
            this.ptb_chinhsua.TabStop = false;
            this.ptb_chinhsua.Click += new System.EventHandler(this.ptb_chinhsua_Click);
            // 
            // ptb_luu
            // 
            this.ptb_luu.BackColor = System.Drawing.Color.Transparent;
            this.ptb_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_luu.Image = ((System.Drawing.Image)(resources.GetObject("ptb_luu.Image")));
            this.ptb_luu.Location = new System.Drawing.Point(100, 560);
            this.ptb_luu.Name = "ptb_luu";
            this.ptb_luu.Size = new System.Drawing.Size(35, 35);
            this.ptb_luu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_luu.TabIndex = 30;
            this.ptb_luu.TabStop = false;
            this.ptb_luu.Click += new System.EventHandler(this.ptb_luu_Click);
            // 
            // ptb_xoatrong
            // 
            this.ptb_xoatrong.BackColor = System.Drawing.Color.Transparent;
            this.ptb_xoatrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_xoatrong.Image = ((System.Drawing.Image)(resources.GetObject("ptb_xoatrong.Image")));
            this.ptb_xoatrong.Location = new System.Drawing.Point(40, 560);
            this.ptb_xoatrong.Name = "ptb_xoatrong";
            this.ptb_xoatrong.Size = new System.Drawing.Size(35, 35);
            this.ptb_xoatrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoatrong.TabIndex = 31;
            this.ptb_xoatrong.TabStop = false;
            this.ptb_xoatrong.Click += new System.EventHandler(this.ptb_xoatrong_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(616, 565);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 25);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbo_gioitinh);
            this.groupBox1.Controls.Add(this.cbo_tinhtrang);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.cbo_loaicongviec);
            this.groupBox1.Controls.Add(this.txt_lcb);
            this.groupBox1.Controls.Add(this.txt_quequan);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // cbo_gioitinh
            // 
            this.cbo_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gioitinh.FormattingEnabled = true;
            this.cbo_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioitinh.Location = new System.Drawing.Point(154, 152);
            this.cbo_gioitinh.Name = "cbo_gioitinh";
            this.cbo_gioitinh.Size = new System.Drawing.Size(85, 21);
            this.cbo_gioitinh.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 558);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(728, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // BindingSource_Nhanvien
            // 
            this.BindingSource_Nhanvien.DataMember = "sp_Docnhanvien";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_bangnhanvien
            // 
            this.dgv_bangnhanvien.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_bangnhanvien.DataSource = this.BindingSource_Nhanvien_Proc;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_bangnhanvien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_bangnhanvien.Location = new System.Drawing.Point(0, 327);
            this.dgv_bangnhanvien.MainView = this.grv_nhanvien;
            this.dgv_bangnhanvien.Name = "dgv_bangnhanvien";
            this.dgv_bangnhanvien.Size = new System.Drawing.Size(728, 232);
            this.dgv_bangnhanvien.TabIndex = 0;
            this.dgv_bangnhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_nhanvien});
            // 
            // BindingSource_Nhanvien_Proc
            // 
            this.BindingSource_Nhanvien_Proc.DataMember = "sp_Docnhanvien";
            this.BindingSource_Nhanvien_Proc.DataSource = this.DataSet_Nhanvien;
            // 
            // DataSet_Nhanvien
            // 
            this.DataSet_Nhanvien.DataSetName = "GSale_AppDataSet";
            this.DataSet_Nhanvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grv_nhanvien
            // 
            this.grv_nhanvien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmanv,
            this.colhoten,
            this.colngaysinh,
            this.colgioitinh,
            this.colquequan,
            this.colcmnd,
            this.colloaicongviec,
            this.collcb,
            this.coltinhtrang});
            this.grv_nhanvien.GridControl = this.dgv_bangnhanvien;
            this.grv_nhanvien.Name = "grv_nhanvien";
            // 
            // colmanv
            // 
            this.colmanv.Caption = "Mã nhân viên";
            this.colmanv.FieldName = "manv";
            this.colmanv.Name = "colmanv";
            this.colmanv.Visible = true;
            this.colmanv.VisibleIndex = 0;
            this.colmanv.Width = 78;
            // 
            // colhoten
            // 
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            this.colhoten.Width = 110;
            // 
            // colngaysinh
            // 
            this.colngaysinh.Caption = "Ngày sinh";
            this.colngaysinh.FieldName = "ngaysinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 2;
            this.colngaysinh.Width = 72;
            // 
            // colgioitinh
            // 
            this.colgioitinh.Caption = "Giới tính";
            this.colgioitinh.FieldName = "gioitinh";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.OptionsColumn.ReadOnly = true;
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 3;
            this.colgioitinh.Width = 72;
            // 
            // colquequan
            // 
            this.colquequan.Caption = "Quê quán";
            this.colquequan.FieldName = "quequan";
            this.colquequan.Name = "colquequan";
            this.colquequan.Visible = true;
            this.colquequan.VisibleIndex = 4;
            this.colquequan.Width = 72;
            // 
            // colcmnd
            // 
            this.colcmnd.Caption = "CMND";
            this.colcmnd.FieldName = "cmnd";
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.Visible = true;
            this.colcmnd.VisibleIndex = 5;
            this.colcmnd.Width = 72;
            // 
            // colloaicongviec
            // 
            this.colloaicongviec.Caption = "Loại công việc";
            this.colloaicongviec.FieldName = "loaicongviec";
            this.colloaicongviec.Name = "colloaicongviec";
            this.colloaicongviec.Visible = true;
            this.colloaicongviec.VisibleIndex = 6;
            this.colloaicongviec.Width = 72;
            // 
            // collcb
            // 
            this.collcb.Caption = "Lương";
            this.collcb.FieldName = "lcb";
            this.collcb.Name = "collcb";
            this.collcb.Visible = true;
            this.collcb.VisibleIndex = 7;
            this.collcb.Width = 72;
            // 
            // coltinhtrang
            // 
            this.coltinhtrang.Caption = "Tình trạng";
            this.coltinhtrang.FieldName = "tinhtrang";
            this.coltinhtrang.Name = "coltinhtrang";
            this.coltinhtrang.OptionsColumn.ReadOnly = true;
            this.coltinhtrang.Visible = true;
            this.coltinhtrang.VisibleIndex = 8;
            this.coltinhtrang.Width = 90;
            // 
            // Adapter_Nhanvien
            // 
            this.Adapter_Nhanvien.ClearBeforeFill = true;
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 598);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_bangnhanvien);
            this.Controls.Add(this.ptb_tim);
            this.Controls.Add(this.ptb_chinhsua);
            this.Controls.Add(this.ptb_luu);
            this.Controls.Add(this.ptb_xoatrong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_nhanvien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Nhanvien_Proc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_tinhtrang;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.ComboBox cbo_loaicongviec;
        private System.Windows.Forms.TextBox txt_lcb;
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_tim;
        private System.Windows.Forms.PictureBox ptb_chinhsua;
        private System.Windows.Forms.PictureBox ptb_luu;
        private System.Windows.Forms.PictureBox ptb_xoatrong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource BindingSource_Nhanvien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl dgv_bangnhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_nhanvien;
        private GSale_AppDataSet DataSet_Nhanvien;
        private System.Windows.Forms.BindingSource BindingSource_Nhanvien_Proc;
        private GSale_AppDataSetTableAdapters.sp_DocnhanvienTableAdapter Adapter_Nhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colmanv;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colquequan;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn colloaicongviec;
        private DevExpress.XtraGrid.Columns.GridColumn collcb;
        private DevExpress.XtraGrid.Columns.GridColumn coltinhtrang;
        private System.Windows.Forms.ComboBox cbo_gioitinh;
    }
}