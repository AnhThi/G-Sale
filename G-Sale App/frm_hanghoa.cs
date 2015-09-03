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
using System.Data.OleDb;

namespace G_Sale_App
{
    public partial class frm_hanghoa : Form
    {
        SqlConnection cnn;
        DataTable dt;
        public frm_hanghoa()
        {
            InitializeComponent();
            cnn = SQL.cnn;
            dt = new DataTable();
        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_banghanghoa.DataSource = SQL.DocBang("sp_Dochanghoa");
                cbo_danhmuc.DataSource = SQL.DocBang("sp_Docdanhmuc");
                cbo_danhmuc.ValueMember = "madm";
                cbo_danhmuc.DisplayMember = "tendm";
                cbo_danhmuc.SelectedIndex = 0;
                cbo_donvitinh.SelectedIndex = 0;
                BinDing_();
            }
            catch (Exception)
            {
                MessageBox.Show("Hệ thống chưa có danh mục hàng hóa nào. Bạn phải tại ra các danh mục trước khi thêm hàng hóa vào hệ thống", "Nhắc nhơ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void frm_hanghoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void ptb_xoatrong_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            txt_mahanghoa.Clear();
            txt_tenhanghoa.Clear();
            cbo_danhmuc.SelectedIndex = 0;
            cbo_donvitinh.SelectedIndex = 0;
            txt_giaban.Clear();
            txt_giagoc.Clear();
            txt_mahanghoa.Focus();
        }

        private void ptb_luu_Click(object sender, EventArgs e)
        {
            if(txt_mahanghoa.Text == "" || txt_tenhanghoa.Text == "" || txt_giagoc.Text == "" || txt_giaban.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin hàng hóa", "Nhắc nhớ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Themhanghoa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahh", txt_mahanghoa.Text);
            cmd.Parameters.AddWithValue("@tenhh", txt_tenhanghoa.Text);
            cmd.Parameters.AddWithValue("@madm", cbo_danhmuc.SelectedValue);
            cmd.Parameters.AddWithValue("@dvt", cbo_donvitinh.Text);
            cmd.Parameters.AddWithValue("@giagoc", txt_giagoc.Text);
            cmd.Parameters.AddWithValue("@giaban", txt_giaban.Text);
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                int check = (int)cmd.Parameters["@check"].Value;
                if (check == 1)
                {
                    MessageBox.Show("Mã hàng hóa bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgv_banghanghoa.DataSource = SQL.DocBang("sp_Dochanghoa");
            BinDing_();
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Xoahanghoa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahh", txt_mahanghoa.Text);

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
            dgv_banghanghoa.DataSource = SQL.DocBang("sp_Dochanghoa");
            BinDing_();
        }

        private void ptb_chinhsua_Click(object sender, EventArgs e)
        {
            ClearBinDing_();
            SqlCommand cmd = new SqlCommand("sp_Suahanghoa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahh", txt_mahanghoa.Text);
            cmd.Parameters.AddWithValue("@tenhh", txt_tenhanghoa.Text);
            cmd.Parameters.AddWithValue("@madm", cbo_danhmuc.SelectedValue);
            cmd.Parameters.AddWithValue("@dvt", cbo_donvitinh.Text);
            cmd.Parameters.AddWithValue("@giagoc", txt_giagoc.Text);
            cmd.Parameters.AddWithValue("@giaban", txt_giaban.Text);

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
            dgv_banghanghoa.DataSource = SQL.DocBang("sp_Dochanghoa");
            BinDing_();
        }

        private void ptb_tim_Click(object sender, EventArgs e)
        {
            SendKeys.Send("(^){F}");
        }

        private void ptb_in_Click(object sender, EventArgs e)
        {
            report_hanghoa hanghoa = new report_hanghoa();
            hanghoa.ShowDialog();
        }

        private void ptb_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Excel File| *.xls; *.xlsx";
            excel.FilterIndex = 1;
            excel.RestoreDirectory = true;
            if(excel.ShowDialog()==DialogResult.OK)
            {
                DialogResult import;
                import = MessageBox.Show("Bạn muốn Import dữ liệu từ File Excel vào CSDL?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(import==DialogResult.OK)
                {
                    try
                    {
                        string ckn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + excel.FileName + ";Extended Properties=\"Excel 8.0; HDR=No\";";
                        OleDbConnection cnn = new OleDbConnection(ckn);
                        string ctv = @"select * from [Sheet1$]";
                        OleDbDataAdapter dap = new OleDbDataAdapter(ctv, cnn);
                        dt = new DataTable();
                        dap.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể load dữ liệu vào datatable" + ex.Message);
                    }
                    
                    foreach (DataRow i in dt.Rows)
                    {
                        SqlCommand cmd = new SqlCommand("sp_Themhanghoa", cnn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahh", i[0].ToString());
                        cmd.Parameters.AddWithValue("@tenhh", i[1].ToString());
                        cmd.Parameters.AddWithValue("@madm", i[2].ToString());
                        cmd.Parameters.AddWithValue("@dvt", i[3].ToString());
                        cmd.Parameters.AddWithValue("@giagoc", i[4].ToString());
                        cmd.Parameters.AddWithValue("@giaban", i[5].ToString());

                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            MessageBox.Show("Import dữ liệu thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_banghanghoa.DataSource = SQL.DocBang("sp_Dochanghoa");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể ghi dữ liệu vào CSDL" + ex.Message);
                        }
                        finally
                        {
                            if(cnn!=null)
                            {
                                cnn.Close();
                            }
                        }
                    }
                }
            }
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
            txt_mahanghoa.DataBindings.Add("Text", dgv_banghanghoa.DataSource, "mahh");
            txt_tenhanghoa.DataBindings.Add("Text", dgv_banghanghoa.DataSource, "tenhh");
            cbo_danhmuc.DataBindings.Add("SelectedValue", dgv_banghanghoa.DataSource, "madm");
            cbo_donvitinh.DataBindings.Add("Text", dgv_banghanghoa.DataSource, "dvt");
            txt_giagoc.DataBindings.Add("Text", dgv_banghanghoa.DataSource, "giagoc");
            txt_giaban.DataBindings.Add("Text", dgv_banghanghoa.DataSource, "giaban");
            txt_tienloi.DataBindings.Add("Text", dgv_banghanghoa.DataSource, "tienloi");
        }

        public void ClearBinDing_()
        {
            if(txt_mahanghoa.DataBindings!=null)
            {
                txt_mahanghoa.DataBindings.Clear();
            }
            if(txt_tenhanghoa.DataBindings!=null)
            {
                txt_tenhanghoa.DataBindings.Clear();
            }
            if(cbo_danhmuc.DataBindings!=null)
            {
                cbo_danhmuc.DataBindings.Clear();
            }
            if(cbo_donvitinh.DataBindings!=null)
            {
                cbo_donvitinh.DataBindings.Clear();
            }
            if(txt_giagoc.DataBindings!=null)
            {
                txt_giagoc.DataBindings.Clear();
            }
            if(txt_giaban.DataBindings!=null)
            {
                txt_giaban.DataBindings.Clear();
            }
            if(txt_tienloi.DataBindings!=null)
            {
                txt_tienloi.DataBindings.Clear();
            }
        }
    }
}
