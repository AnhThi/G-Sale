using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace G_Sale_App
{
    public partial class frm_nhanvien : Form
    {
        SqlConnection cnn;
        public frm_nhanvien()
        {
            InitializeComponent();
            cnn = SQL.cnn;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            dgv_bangnhanvien.DataSource = SQL.DocBang("sp_Docnhanvien");
            BinDing_();
            cbo_loaicongviec.SelectedIndex = 0;
            cbo_tinhtrang.SelectedIndex = 0;
            cbo_gioitinh.SelectedIndex = 0;
        }

        private void frm_nhanvien_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void ptb_xoatrong_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            int sl = 0;
            sl = SQL.DemSL("sp_Docsoluongnhanvien");
            txt_manv.Clear();
            if (sl > 8)
            {
                txt_manv.Text = "NV" + (sl + 1).ToString();
            }
            else
            {
                txt_manv.Text = "NV0" + (sl + 1).ToString();
            }
            txt_hoten.Clear();
            dtp_ngaysinh.Value = DateTime.Parse("01/01/1995");
            cbo_gioitinh.SelectedIndex = 0;
            txt_cmnd.Clear();
            cbo_loaicongviec.SelectedIndex = 0;
            txt_lcb.Clear();
            txt_quequan.Clear();
            txt_manv.Focus();
            cbo_tinhtrang.SelectedIndex = 0;
            cbo_tinhtrang.Enabled = false;
            dgv_bangnhanvien.DataSource = SQL.DocBang("sp_Docnhanvien");
        }

        private void ptb_luu_Click(object sender, EventArgs e)
        {
            if(BatDieuKienNhap()==false)
            {
                return;
            }
            ClearBinDing_();
            bool gt=false;//la nu
            cbo_tinhtrang.Enabled = true;
            SqlCommand cmd = new SqlCommand("sp_Themnhanvien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
            cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", dtp_ngaysinh.Value);
            if(cbo_gioitinh.Text=="Nam")
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            cmd.Parameters.AddWithValue("@gioitinh", gt);
            cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text);
            cmd.Parameters.AddWithValue("@cmnd", txt_cmnd.Text);
            cmd.Parameters.AddWithValue("@loaicongviec", cbo_loaicongviec.Text);
            cmd.Parameters.AddWithValue("@lcb", txt_lcb.Text);
            cmd.Parameters.AddWithValue("@tinhtrang", 0);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm nhân viên" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if(cnn!=null)
                {
                    cnn.Close();
                }
            }
            dgv_bangnhanvien.DataSource = SQL.DocBang("sp_Docnhanvien");
            BinDing_();
        }

        private void ptb_chinhsua_Click(object sender, EventArgs e)
        {
            BatDieuKienNhap();
            ClearBinDing_();
            bool gt = false;//la nu
            cbo_tinhtrang.Enabled = true;
            SqlCommand cmd = new SqlCommand("sp_Suanhanvien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
            cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", dtp_ngaysinh.Value);
            if (cbo_gioitinh.Text=="Nam")
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            cmd.Parameters.AddWithValue("@gioitinh", gt);
            cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text);
            cmd.Parameters.AddWithValue("@cmnd", txt_cmnd.Text);
            cmd.Parameters.AddWithValue("@loaicongviec", cbo_loaicongviec.Text);
            MessageBox.Show(cbo_loaicongviec.Text);
            cmd.Parameters.AddWithValue("@lcb", txt_lcb.Text);
            if(cbo_tinhtrang.Text=="Đang làm việc")
            {
                cmd.Parameters.AddWithValue("@tinhtrang", 0);//dang lam viec
            }
            else
            {
                cmd.Parameters.AddWithValue("@tinhtrang", 1);//da nghi viec
            }

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa nhân viên" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            dgv_bangnhanvien.DataSource = SQL.DocBang("sp_Docnhanvien");
            BinDing_();
        }

        private void ptb_tim_Click(object sender, EventArgs e)
        {
            SendKeys.Send("(^){F}");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //---------------------MENTHOD
        //
        public void BinDing_()
        {
            txt_manv.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "manv");
            txt_hoten.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "hoten");
            dtp_ngaysinh.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "ngaysinh");
            cbo_gioitinh.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "gioitinh");
            txt_cmnd.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "cmnd");
            cbo_loaicongviec.DataBindings.Add("SelectedItem", dgv_bangnhanvien.DataSource, "loaicongviec");
            txt_lcb.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "lcb");
            txt_quequan.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "quequan");
            cbo_tinhtrang.DataBindings.Add("Text", dgv_bangnhanvien.DataSource, "tinhtrang");
        }

        public void ClearBinDing_()
        {
            if (txt_manv.DataBindings != null)
            {
                txt_manv.DataBindings.Clear();
            }
            if (txt_hoten.DataBindings != null)
            {
                txt_hoten.DataBindings.Clear();
            }
            if (dtp_ngaysinh.DataBindings != null)
            {
                dtp_ngaysinh.DataBindings.Clear();
            }
            if(cbo_gioitinh.DataBindings!=null)
            {
                cbo_gioitinh.DataBindings.Clear();
            }
            if (txt_cmnd.DataBindings != null)
            {
                txt_cmnd.DataBindings.Clear();
            }
            if (cbo_loaicongviec.DataBindings != null)
            {
                cbo_loaicongviec.DataBindings.Clear();
            }
            if (txt_lcb.DataBindings != null)
            {
                txt_lcb.DataBindings.Clear();
            }
            if (txt_quequan.DataBindings != null)
            {
                txt_quequan.DataBindings.Clear();
            }
            if(cbo_tinhtrang.DataBindings!=null)
            {
                cbo_tinhtrang.DataBindings.Clear();
            }
        }

        public bool BatDieuKienNhap()
        {
            bool check = true;
            if (txt_hoten.Text == "" || txt_cmnd.Text == "" || txt_lcb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }

            if (!Regex.IsMatch(txt_cmnd.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("CMND chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }

            if (dtp_ngaysinh.Value > DateTime.Now)
            {
                MessageBox.Show("Nhập sai ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            return check;
        }
    }
}
