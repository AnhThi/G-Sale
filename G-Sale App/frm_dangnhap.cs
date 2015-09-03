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
    public partial class frm_dangnhap : Form
    {
        ToolTip der;
        SqlConnection cnn;
        int solan;
        public frm_dangnhap()
        {
            InitializeComponent();
            der = new ToolTip();
            cnn = SQL.cnn;
            solan = 0;
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            try
            {
                cbo_chonnhanvien.DataSource = SQL.DocBang("sp_Docnhanvienbanhang");
                cbo_chonnhanvien.ValueMember = "manv";
                cbo_chonnhanvien.DisplayMember = "hoten";
                cbo_chonnhanvien.SelectedIndex = 0;
            }
            catch (Exception)
            {
                chb_quantrivien.Checked = true;//bật checkbox để set chỉ có quản trị viên đăng nhập trong thời gian hiện tại
                chb_quantrivien.Enabled = false;//tắt checkbox để người dùng không thể bật lại combobox dành cho nhân viên
            }
            //
            //--------------------------LẤY THÔNG TIN BẢN QUYỀN
            //
            SqlCommand cmd = new SqlCommand("sp_Tramabanquyen", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter spm_mabanquyen = new SqlParameter("@mabanquyen", SqlDbType.VarChar, 19);
            spm_mabanquyen.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_mabanquyen);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                Common.Mabanquyen = spm_mabanquyen.Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }

        }

        private void frm_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_dangnhap.PerformClick();
            }

            if(e.KeyCode == Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void chb_quantrivien_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_quantrivien.Checked==true)
            {
                txt_taikhoan.Enabled = true;
                txt_matkhau.Enabled = true;
                //cbo_chonnhanvien.SelectedIndex = 0;
                cbo_chonnhanvien.Enabled = false;
            }
            else
            {
                txt_taikhoan.Text = "Nhập tên tài khoản";
                txt_matkhau.Text = "Nhập mật khẩu";
                txt_taikhoan.Enabled = false;
                txt_matkhau.Enabled = false;
                cbo_chonnhanvien.SelectedIndex = 0;//combobox đã có dữ liệu vì nếu không đã bị bắt ở form Load
                cbo_chonnhanvien.Enabled = true;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        { 
            if(solan>=3)
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu quá 3 lần. Phần mềm sẽ bị đóng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            if(chb_quantrivien.Checked==true)
            {
                int kiemtradangnhap = 1;//gán giá trị ban đầu là đăng nhập thất bại
                kiemtradangnhap = SQL.KiemTraDangNhap("sp_Kiemtradangnhap", txt_taikhoan.Text, txt_matkhau.Text);
                if(kiemtradangnhap==0)
                {
                    Common.TinhTrangDangNhap = 0;//đăng nhập thành công
                    Common.Manhanvien = "Administrator";
                    Common.TenNguoiTruyCap = "Quản trị viên";
                    this.Close();
                }
                else
                {
                    solan = solan + 1;
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_matkhau.Clear();
                    txt_taikhoan.Focus();
                    txt_taikhoan.SelectAll();
                    Common.TinhTrangDangNhap = 1;//đăng nhập thất bại
                }
            }
            else
            {
                Common.Manhanvien = cbo_chonnhanvien.SelectedValue.ToString();
                Common.TenNguoiTruyCap = cbo_chonnhanvien.Text;
                Common.TinhTrangDangNhap = 1;//đăng nhập thất bại
                this.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //
        //---------------------MOUSERCLICK EVENT
        //
        private void txt_taikhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txt_taikhoan.Text = "";
        }

        private void txt_matkhau_MouseClick(object sender, MouseEventArgs e)
        {
            txt_matkhau.Text = "";
        }
        //
        //---------------------MOUSEDOWN, MOUSEUP AND MOUSEHOVER EVENT
        //
        private void btn_eye_MouseDown(object sender, MouseEventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = false;
        }

        private void btn_eye_MouseHover(object sender, EventArgs e)
        {
            der.SetToolTip(btn_eye, "Hiện mật khẩu");
        }

        private void btn_eye_MouseUp(object sender, MouseEventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = true;
        }
    }
}
