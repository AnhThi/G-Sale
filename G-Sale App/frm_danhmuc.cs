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
    public partial class frm_danhmuc : Form
    {
        SqlConnection cnn;
        public frm_danhmuc()
        {
            InitializeComponent();
            cnn = SQL.cnn;
        }

        private void frm_danhmuc_Load(object sender, EventArgs e)
        {
            dgv_bangdanhmuc.DataSource = SQL.DocBang("sp_Docdanhmuc");
            BinDing_();
        }

        private void frm_danhmuc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void ptb_xoatrong_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            txt_madanhmuc.Clear();
            txt_tendanhmuc.Clear();
            txt_madanhmuc.Focus();
        }

        private void ptb_luu_Click(object sender, EventArgs e)
        {
            if(txt_madanhmuc.Text == "" || txt_tendanhmuc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập danh mục", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Themdanhmuc", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", txt_madanhmuc.Text.ToUpper());
            cmd.Parameters.AddWithValue("@tendm", txt_tendanhmuc.Text);
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction=ParameterDirection.ReturnValue;
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                int check = (int)cmd.Parameters["@check"].Value;
                if(check==1)
                {
                    MessageBox.Show("Mã danh mục bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                if(cnn!=null)
                {
                    cnn.Close();
                }
            }
            dgv_bangdanhmuc.DataSource = SQL.DocBang("sp_Docdanhmuc");
            BinDing_();
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Xoadanhmuc", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", txt_madanhmuc.Text);
            
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không thể xoa danh mục này vì trong danh mục này đã tồn tại hàng hóa");
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            dgv_bangdanhmuc.DataSource = SQL.DocBang("sp_Docdanhmuc");
            BinDing_();
        }

        private void ptb_chinhsua_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Suadanhmuc", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", txt_madanhmuc.Text.ToUpper());
            cmd.Parameters.AddWithValue("@tendm", txt_tendanhmuc.Text);
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
            dgv_bangdanhmuc.DataSource = SQL.DocBang("sp_Docdanhmuc");
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
            txt_madanhmuc.DataBindings.Add("Text", dgv_bangdanhmuc.DataSource, "madm");
            txt_tendanhmuc.DataBindings.Add("Text", dgv_bangdanhmuc.DataSource, "tendm");
        }

        public void ClearBinDing_()
        {
            if(txt_madanhmuc.DataBindings!=null)
            {
                txt_madanhmuc.DataBindings.Clear();
            }
            
            if(txt_tendanhmuc.DataBindings!=null)
            {
                txt_tendanhmuc.DataBindings.Clear();
            }
        }
        //
        //--------------------------------MENTHOD
        //
    }
}
