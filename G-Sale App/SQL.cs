using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace G_Sale_App
{
    public class SQL
    {
        //
        //---------------------FIELDS
        //
        public static SqlConnection cnn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=GSale_App;Integrated Security=True");
        //
        //---------------------KIỂM TRA ĐĂNG NHẬP
        //
        public static int KiemTraDangNhap(string proc, string taikhoan, string matkhau)
        {
            int check = 0;
            SqlCommand cmd = new SqlCommand(proc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", Common.MaHoaMD5(matkhau));
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                check = (int)cmd.Parameters["@check"].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thực hiện thủ tục kiểm tra đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return check;
        }
        //
        //---------------------ĐẾM SỐ LƯỢNG
        //
        public static int DemSL(string proc)
        {
            int sl = 0;
            SqlCommand cmd = new SqlCommand(proc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter spm = new SqlParameter("@soluong", SqlDbType.Int);
            spm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                sl = (int)spm.Value;

            }
            catch (Exception)
            {
                throw new Exception("Không thể đếm");
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return sl;
        }
        //
        //---------------------PROC KHONG DOI SO
        //
        //
        public static void BackupandRestore(string proc, string csdl, string duongdan)
        {
            SqlCommand cmd = new SqlCommand(proc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tencsdl", csdl);
            cmd.Parameters.AddWithValue("@duongdan", duongdan);
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
        }
        //---------------------ĐỌC BẢNG
        //
        public static DataTable DocBang(string proc)
        {
            SqlCommand cmd = new SqlCommand(proc, cnn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {
                throw new Exception("Không thể đọc bảng");
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return dt;
        }
        //
        //---------------------THÊM ĐỐI TƯỢNG
        //
        public static void ThemDanhMuc(string proc, string sql_1, string text_1, string sql_2, string text_2)
        {
            int check = 0;
            SqlCommand cmd = new SqlCommand(proc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(sql_1, text_1);
            cmd.Parameters.AddWithValue(sql_2, text_2);
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                check = (int)cmd.Parameters["@check"].Value;
                if (check == 0)
                {
                    throw new Exception("Thêm Danh Mục thành công");
                }
                else
                {
                    throw new Exception("Mã Danh Mục bị trùng");
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
        }


    }
}
