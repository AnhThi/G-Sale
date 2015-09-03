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

namespace G_Sale_App
{
    public partial class frm_nhacungcap : Form
    {
        SqlConnection cnn;
        public frm_nhacungcap()
        {
            InitializeComponent();
            cnn = SQL.cnn;
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            dgv_bangnhacungcap.DataSource = SQL.DocBang("sp_Docnhacc");
            BinDing_();

        }

        private void frm_nhacungcap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void ptb_xoatrong_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            txt_manhacc.Clear();
            txt_tennhacc.Clear();
            txt_diachi.Clear();
            txt_sodienthoai.Clear();
            txt_manhacc.Focus();
        }

        private void ptb_luu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_Themnhacc", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhacc", txt_manhacc.Text);
            cmd.Parameters.AddWithValue("@tennhacc", txt_tennhacc.Text);
            cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
            cmd.Parameters.AddWithValue("@sdt", txt_sodienthoai.Text);
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                int check = (int)cmd.Parameters["@check"].Value;
                if (check == 1)
                {
                    MessageBox.Show("Mã nhà cung cấp bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            dgv_bangnhacungcap.DataSource = SQL.DocBang("sp_Docnhacc");
            BinDing_();
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Xoanhacc", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhacc", txt_manhacc.Text);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            dgv_bangnhacungcap.DataSource = SQL.DocBang("sp_Docnhacc");
            BinDing_();
        }

        private void ptb_chinhsua_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Suanhacc", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhacc", txt_manhacc.Text);
            cmd.Parameters.AddWithValue("@tennhacc", txt_tennhacc.Text);
            cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
            cmd.Parameters.AddWithValue("@sdt", txt_sodienthoai.Text);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            dgv_bangnhacungcap.DataSource = SQL.DocBang("sp_Docnhacc");
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
            txt_manhacc.DataBindings.Add("Text", dgv_bangnhacungcap.DataSource, "manhacc");
            txt_tennhacc.DataBindings.Add("Text", dgv_bangnhacungcap.DataSource, "tennhacc");
            txt_diachi.DataBindings.Add("Text", dgv_bangnhacungcap.DataSource, "diachi");
            txt_sodienthoai.DataBindings.Add("Text", dgv_bangnhacungcap.DataSource, "sdt");
        }

        public void ClearBinDing_()
        {
            if(txt_manhacc.DataBindings!=null)
            {
                txt_manhacc.DataBindings.Clear();
            }
            if(txt_tennhacc.DataBindings!=null)
            {
                txt_tennhacc.DataBindings.Clear();
            }
            if(txt_diachi.DataBindings!=null)
            {
                txt_diachi.DataBindings.Clear();
            }
            if(txt_sodienthoai.DataBindings!=null)
            {
                txt_sodienthoai.DataBindings.Clear();
            }
        }

       

    }
}
