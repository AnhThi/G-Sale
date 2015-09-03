namespace G_Sale_App
{
    partial class frm_nhacungcap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nhacungcap));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.txt_tennhacc = new System.Windows.Forms.TextBox();
            this.txt_manhacc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_tim = new System.Windows.Forms.PictureBox();
            this.ptb_chinhsua = new System.Windows.Forms.PictureBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_luu = new System.Windows.Forms.PictureBox();
            this.ptb_xoatrong = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgv_bangnhacungcap = new DevExpress.XtraGrid.GridControl();
            this.BindingSource_Nhacc = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Bangnhacc = new G_Sale_App.GSale_AppDataSet3();
            this.grv_bangnhacungcap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmanhacc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhacc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adapter_Nhacc = new G_Sale_App.GSale_AppDataSet3TableAdapters.sp_DocnhaccTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangnhacungcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Nhacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Bangnhacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_bangnhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-16, -16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-16, -16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_sodienthoai);
            this.groupBox1.Controls.Add(this.txt_tennhacc);
            this.groupBox1.Controls.Add(this.txt_manhacc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_diachi.Location = new System.Drawing.Point(388, 84);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(175, 61);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodienthoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sodienthoai.Location = new System.Drawing.Point(388, 45);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(175, 20);
            this.txt_sodienthoai.TabIndex = 2;
            // 
            // txt_tennhacc
            // 
            this.txt_tennhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennhacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tennhacc.Location = new System.Drawing.Point(125, 85);
            this.txt_tennhacc.Name = "txt_tennhacc";
            this.txt_tennhacc.Size = new System.Drawing.Size(142, 20);
            this.txt_tennhacc.TabIndex = 1;
            // 
            // txt_manhacc
            // 
            this.txt_manhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manhacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_manhacc.Location = new System.Drawing.Point(125, 45);
            this.txt_manhacc.Name = "txt_manhacc";
            this.txt_manhacc.Size = new System.Drawing.Size(142, 20);
            this.txt_manhacc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(300, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(300, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điệnt thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_tim
            // 
            this.ptb_tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_tim.Image = ((System.Drawing.Image)(resources.GetObject("ptb_tim.Image")));
            this.ptb_tim.Location = new System.Drawing.Point(270, 467);
            this.ptb_tim.Name = "ptb_tim";
            this.ptb_tim.Size = new System.Drawing.Size(35, 35);
            this.ptb_tim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_tim.TabIndex = 37;
            this.ptb_tim.TabStop = false;
            this.ptb_tim.Click += new System.EventHandler(this.ptb_tim_Click);
            // 
            // ptb_chinhsua
            // 
            this.ptb_chinhsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_chinhsua.Image = ((System.Drawing.Image)(resources.GetObject("ptb_chinhsua.Image")));
            this.ptb_chinhsua.Location = new System.Drawing.Point(210, 467);
            this.ptb_chinhsua.Name = "ptb_chinhsua";
            this.ptb_chinhsua.Size = new System.Drawing.Size(35, 35);
            this.ptb_chinhsua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_chinhsua.TabIndex = 33;
            this.ptb_chinhsua.TabStop = false;
            this.ptb_chinhsua.Click += new System.EventHandler(this.ptb_chinhsua_Click);
            // 
            // ptb_xoa
            // 
            this.ptb_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_xoa.Image = ((System.Drawing.Image)(resources.GetObject("ptb_xoa.Image")));
            this.ptb_xoa.Location = new System.Drawing.Point(150, 467);
            this.ptb_xoa.Name = "ptb_xoa";
            this.ptb_xoa.Size = new System.Drawing.Size(35, 35);
            this.ptb_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoa.TabIndex = 34;
            this.ptb_xoa.TabStop = false;
            this.ptb_xoa.Click += new System.EventHandler(this.ptb_xoa_Click);
            // 
            // ptb_luu
            // 
            this.ptb_luu.BackColor = System.Drawing.Color.Transparent;
            this.ptb_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_luu.Image = ((System.Drawing.Image)(resources.GetObject("ptb_luu.Image")));
            this.ptb_luu.Location = new System.Drawing.Point(90, 467);
            this.ptb_luu.Name = "ptb_luu";
            this.ptb_luu.Size = new System.Drawing.Size(35, 35);
            this.ptb_luu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_luu.TabIndex = 35;
            this.ptb_luu.TabStop = false;
            this.ptb_luu.Click += new System.EventHandler(this.ptb_luu_Click);
            // 
            // ptb_xoatrong
            // 
            this.ptb_xoatrong.BackColor = System.Drawing.Color.Transparent;
            this.ptb_xoatrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_xoatrong.Image = ((System.Drawing.Image)(resources.GetObject("ptb_xoatrong.Image")));
            this.ptb_xoatrong.Location = new System.Drawing.Point(30, 467);
            this.ptb_xoatrong.Name = "ptb_xoatrong";
            this.ptb_xoatrong.Size = new System.Drawing.Size(35, 35);
            this.ptb_xoatrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoatrong.TabIndex = 36;
            this.ptb_xoatrong.TabStop = false;
            this.ptb_xoatrong.Click += new System.EventHandler(this.ptb_xoatrong_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(496, 472);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 25);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 465);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // dgv_bangnhacungcap
            // 
            this.dgv_bangnhacungcap.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_bangnhacungcap.DataSource = this.BindingSource_Nhacc;
            this.dgv_bangnhacungcap.Location = new System.Drawing.Point(0, 279);
            this.dgv_bangnhacungcap.MainView = this.grv_bangnhacungcap;
            this.dgv_bangnhacungcap.Name = "dgv_bangnhacungcap";
            this.dgv_bangnhacungcap.Size = new System.Drawing.Size(605, 187);
            this.dgv_bangnhacungcap.TabIndex = 0;
            this.dgv_bangnhacungcap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_bangnhacungcap});
            // 
            // BindingSource_Nhacc
            // 
            this.BindingSource_Nhacc.DataMember = "sp_Docnhacc";
            this.BindingSource_Nhacc.DataSource = this.DataSet_Bangnhacc;
            // 
            // DataSet_Bangnhacc
            // 
            this.DataSet_Bangnhacc.DataSetName = "GSale_AppDataSet3";
            this.DataSet_Bangnhacc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grv_bangnhacungcap
            // 
            this.grv_bangnhacungcap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmanhacc,
            this.coltennhacc,
            this.coldiachi,
            this.colsdt});
            this.grv_bangnhacungcap.GridControl = this.dgv_bangnhacungcap;
            this.grv_bangnhacungcap.Name = "grv_bangnhacungcap";
            // 
            // colmanhacc
            // 
            this.colmanhacc.Caption = "Mã nhà cung cấp";
            this.colmanhacc.FieldName = "manhacc";
            this.colmanhacc.Name = "colmanhacc";
            this.colmanhacc.Visible = true;
            this.colmanhacc.VisibleIndex = 0;
            // 
            // coltennhacc
            // 
            this.coltennhacc.Caption = "Tên nhà cung cấp";
            this.coltennhacc.FieldName = "tennhacc";
            this.coltennhacc.Name = "coltennhacc";
            this.coltennhacc.Visible = true;
            this.coltennhacc.VisibleIndex = 1;
            // 
            // coldiachi
            // 
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 2;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "Số điệnt thoại";
            this.colsdt.FieldName = "sdt";
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 3;
            // 
            // Adapter_Nhacc
            // 
            this.Adapter_Nhacc.ClearBeforeFill = true;
            // 
            // frm_nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 505);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_bangnhacungcap);
            this.Controls.Add(this.ptb_tim);
            this.Controls.Add(this.ptb_chinhsua);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_luu);
            this.Controls.Add(this.ptb_xoatrong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_nhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_nhacungcap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_nhacungcap_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangnhacungcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Nhacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Bangnhacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_bangnhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_tennhacc;
        private System.Windows.Forms.TextBox txt_manhacc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptb_tim;
        private System.Windows.Forms.PictureBox ptb_chinhsua;
        private System.Windows.Forms.PictureBox ptb_xoa;
        private System.Windows.Forms.PictureBox ptb_luu;
        private System.Windows.Forms.PictureBox ptb_xoatrong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl dgv_bangnhacungcap;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_bangnhacungcap;
        private GSale_AppDataSet3 DataSet_Bangnhacc;
        private System.Windows.Forms.BindingSource BindingSource_Nhacc;
        private GSale_AppDataSet3TableAdapters.sp_DocnhaccTableAdapter Adapter_Nhacc;
        private DevExpress.XtraGrid.Columns.GridColumn colmanhacc;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhacc;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;

    }
}