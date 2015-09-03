namespace G_Sale_App
{
    partial class frm_danhmuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_danhmuc));
            this.ptb_tim = new System.Windows.Forms.PictureBox();
            this.ptb_chinhsua = new System.Windows.Forms.PictureBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_luu = new System.Windows.Forms.PictureBox();
            this.ptb_xoatrong = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_madanhmuc = new System.Windows.Forms.TextBox();
            this.txt_tendanhmuc = new System.Windows.Forms.TextBox();
            this.dgv_bangdanhmuc = new DevExpress.XtraGrid.GridControl();
            this.BindingSource_Danhmuc = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Danhmuc = new G_Sale_App.GSale_AppDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmadm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltendm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adapter_Danhmuc = new G_Sale_App.GSale_AppDataSet1TableAdapters.sp_DocdanhmucTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdanhmuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Danhmuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Danhmuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_tim
            // 
            this.ptb_tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_tim.Image = ((System.Drawing.Image)(resources.GetObject("ptb_tim.Image")));
            this.ptb_tim.Location = new System.Drawing.Point(280, 423);
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
            this.ptb_chinhsua.Location = new System.Drawing.Point(220, 423);
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
            this.ptb_xoa.Location = new System.Drawing.Point(160, 423);
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
            this.ptb_luu.Location = new System.Drawing.Point(100, 423);
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
            this.ptb_xoatrong.Location = new System.Drawing.Point(40, 423);
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
            this.btn_thoat.Location = new System.Drawing.Point(506, 428);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(80, 25);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(633, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(54, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(306, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên danh mục";
            // 
            // txt_madanhmuc
            // 
            this.txt_madanhmuc.Location = new System.Drawing.Point(143, 107);
            this.txt_madanhmuc.Name = "txt_madanhmuc";
            this.txt_madanhmuc.Size = new System.Drawing.Size(138, 20);
            this.txt_madanhmuc.TabIndex = 1;
            // 
            // txt_tendanhmuc
            // 
            this.txt_tendanhmuc.Location = new System.Drawing.Point(399, 106);
            this.txt_tendanhmuc.Name = "txt_tendanhmuc";
            this.txt_tendanhmuc.Size = new System.Drawing.Size(188, 20);
            this.txt_tendanhmuc.TabIndex = 2;
            // 
            // dgv_bangdanhmuc
            // 
            this.dgv_bangdanhmuc.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_bangdanhmuc.DataSource = this.BindingSource_Danhmuc;
            this.dgv_bangdanhmuc.Location = new System.Drawing.Point(0, 149);
            this.dgv_bangdanhmuc.MainView = this.gridView1;
            this.dgv_bangdanhmuc.Name = "dgv_bangdanhmuc";
            this.dgv_bangdanhmuc.Size = new System.Drawing.Size(633, 273);
            this.dgv_bangdanhmuc.TabIndex = 0;
            this.dgv_bangdanhmuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BindingSource_Danhmuc
            // 
            this.BindingSource_Danhmuc.DataMember = "sp_Docdanhmuc";
            this.BindingSource_Danhmuc.DataSource = this.DataSet_Danhmuc;
            // 
            // DataSet_Danhmuc
            // 
            this.DataSet_Danhmuc.DataSetName = "GSale_AppDataSet1";
            this.DataSet_Danhmuc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmadm,
            this.coltendm});
            this.gridView1.GridControl = this.dgv_bangdanhmuc;
            this.gridView1.Name = "gridView1";
            // 
            // colmadm
            // 
            this.colmadm.Caption = "Mã danh mục hàng hóa";
            this.colmadm.FieldName = "madm";
            this.colmadm.Name = "colmadm";
            this.colmadm.Visible = true;
            this.colmadm.VisibleIndex = 0;
            // 
            // coltendm
            // 
            this.coltendm.Caption = "Tên danh mục hàng hóa";
            this.coltendm.FieldName = "tendm";
            this.coltendm.Name = "coltendm";
            this.coltendm.Visible = true;
            this.coltendm.VisibleIndex = 1;
            // 
            // Adapter_Danhmuc
            // 
            this.Adapter_Danhmuc.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frm_danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 460);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_bangdanhmuc);
            this.Controls.Add(this.txt_tendanhmuc);
            this.Controls.Add(this.txt_madanhmuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_tim);
            this.Controls.Add(this.ptb_chinhsua);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_luu);
            this.Controls.Add(this.ptb_xoatrong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_danhmuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_danhmuc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_danhmuc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_tim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_chinhsua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoatrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdanhmuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Danhmuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Danhmuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_tim;
        private System.Windows.Forms.PictureBox ptb_chinhsua;
        private System.Windows.Forms.PictureBox ptb_xoa;
        private System.Windows.Forms.PictureBox ptb_luu;
        private System.Windows.Forms.PictureBox ptb_xoatrong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_madanhmuc;
        private System.Windows.Forms.TextBox txt_tendanhmuc;
        private DevExpress.XtraGrid.GridControl dgv_bangdanhmuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GSale_AppDataSet1 DataSet_Danhmuc;
        private System.Windows.Forms.BindingSource BindingSource_Danhmuc;
        private GSale_AppDataSet1TableAdapters.sp_DocdanhmucTableAdapter Adapter_Danhmuc;
        private DevExpress.XtraGrid.Columns.GridColumn colmadm;
        private DevExpress.XtraGrid.Columns.GridColumn coltendm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}