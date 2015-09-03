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
    public partial class frm_banquyen : Form
    {
        SqlConnection cnn;
        public frm_banquyen()
        {
            InitializeComponent();
            cnn = SQL.cnn;
        }

        private void frm_banquyen_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_kichhoat_Click(object sender, EventArgs e)
        {
            string[] license = Common.License();
            foreach (string i in license)
            {
                if(txt_serial.Text.Equals(i))
                {
                    SqlCommand cmd = new SqlCommand("sp_Nhapbanquyen", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@banquyen", txt_serial.Text);

                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cảm ơn bạn đã dùng phần mềm G-Sale", "Mã bản quyền hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        
                    }
                    finally
                    {
                        if(cnn!=null)
                        {
                            cnn.Close();
                        }
                    }
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Mã bản quyền bạn nhập không đúng. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
