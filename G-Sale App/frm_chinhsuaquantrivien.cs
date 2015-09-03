using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;

namespace G_Sale_App
{
    public partial class frm_chinhsuaquantrivien : Form
    {
        SqlConnection cnn;
        ToolTip der;
        public frm_chinhsuaquantrivien()
        {
            InitializeComponent();
            cnn = SQL.cnn;
            der = new ToolTip();
        }

        private void frm_chinhsuaquantrivien_Load(object sender, EventArgs e)
        {
            string tenquantrivien, tencuahang, diachi, sdt, email, website;
            SqlCommand cmd = new SqlCommand("sp_Layquantrivien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter spm_tenquantrivien = new SqlParameter("@tenquantrivien", SqlDbType.NVarChar, 30);
            spm_tenquantrivien.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_tenquantrivien);

            SqlParameter spm_tencuahang = new SqlParameter("@tencuahang", SqlDbType.NVarChar, 30);
            spm_tencuahang.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_tencuahang);

            SqlParameter spm_logo = new SqlParameter("@logo", SqlDbType.VarBinary, 8000);
            spm_logo.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_logo);

            SqlParameter spm_diachi = new SqlParameter("@diachi", SqlDbType.NVarChar, 50);
            spm_diachi.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_diachi);

            SqlParameter spm_sdt = new SqlParameter("@sdt", SqlDbType.VarChar, 12);
            spm_sdt.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_sdt);

            SqlParameter spm_email = new SqlParameter("@email", SqlDbType.VarChar, 25);
            spm_email.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_email);

            SqlParameter spm_website = new SqlParameter("@website", SqlDbType.VarChar, 20);
            spm_website.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_website);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                tenquantrivien = spm_tenquantrivien.Value.ToString();
                tencuahang = spm_tencuahang.Value.ToString();
               
                diachi = spm_diachi.Value.ToString();
                sdt = spm_sdt.Value.ToString();
                email = spm_email.Value.ToString();
                website = spm_website.Value.ToString();
                ptb_logo.Image=Common.FromImage((byte[])spm_logo.Value);
                txt_tennguoiquanli.Text = tenquantrivien;
                txt_tencuahang.Text = tencuahang;
                txt_diachi.Text = diachi;
                txt_sodienthoai.Text = sdt;
                txt_email.Text = email;
                txt_website.Text = website;

                Common.Tencuahang = tencuahang;
                Common.logo = (byte[])spm_logo.Value;
                Common.diachi = diachi;
                Common.sdt = sdt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể load thông tin của quản trị viên");
            }
            finally
            {
                if(cnn!=null)
                {
                    cnn.Close();
                }
            }
        }

        private void frm_chinhsuaquantrivien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_chinhsua.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void btn_chontep_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Logo| *.jpg; *.png; *.gif";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                FileInfo info_ = new FileInfo(file.FileName);
                MessageBox.Show(info_.Length.ToString());
                if (info_.Length > 7900)
                {
                    MessageBox.Show("Kích thước File quá lớn. Bạn vui lòng resize hoặc chọn lại ảnh khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ptb_logo.ImageLocation = file.FileName;
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (ptb_tennguoiquanli.Visible == true && lbl_nhaplaimatkhau.Text.Equals("Khớp") && ptb_tencuahang.Visible == true && ptb_diachi.Visible == true && ptb_sdt.Visible == true)
            {
                SqlCommand cmd = new SqlCommand("sp_Suaquantrivien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenquantrivien", txt_tennguoiquanli.Text);
                cmd.Parameters.AddWithValue("@matkhau", Common.MaHoaMD5(txt_matkhau.Text));
                cmd.Parameters.AddWithValue("@tencuahang", txt_tencuahang.Text);
                cmd.Parameters.AddWithValue("@logo", Common.ToImage(ptb_logo.Image));
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txt_sodienthoai.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@website", txt_website.Text);

                try
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin hoặc mật khẩu không trùng khớp", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //---------------------TEXTCHANGE EVENTS
        //
        private void txt_tennguoiquanli_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_tennguoiquanli.Text, @"^[a-z\sA-Z\D]+$"))
            {
                ptb_tennguoiquanli.Visible = true;
            }
            else
            {
                ptb_tennguoiquanli.Visible = false;
            }
        }

        private void txt_tennguoiquanli_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = e.KeyChar.ToString();
            if (Regex.IsMatch(text, @"^[`~!@#$%^&*()_+-={};:'\|,<.>/?*-+.]$") || text == "[" || text == "]" || text == "\"" || text == "\\")
            {
                e.Handled = true;
            }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_matkhau.Text != "" && txt_matkhau.Text.Length <= 15)
            {
                ptb_matkhau.Visible = true;
            }
            else
            {
                ptb_matkhau.Visible = false;
            }
        }

        private void txt_nhaplaimatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhaplaimatkhau.Text.Equals(txt_matkhau.Text))
            {
                lbl_nhaplaimatkhau.Text = "Khớp";
            }
            else
            {
                lbl_nhaplaimatkhau.Text = "";
            }
        }

        private void txt_tencuahang_TextChanged(object sender, EventArgs e)
        {
            if (txt_tencuahang.Text == "")
            {
                ptb_tencuahang.Visible = false;
            }
            else
            {
                ptb_tencuahang.Visible = true;
            }
        }

        private void txt_sodienthoai_TextChanged(object sender, EventArgs e)
        {
            if (txt_sodienthoai.Text == "")
            {
                ptb_sdt.Visible = false;
                return;
            }
            else
            {
                if (txt_sodienthoai.Text.Substring(0, 1) == "1" || txt_sodienthoai.Text.Substring(0, 1) == "9")
                {
                    if (Regex.IsMatch(txt_sodienthoai.Text, @"^[0-9]+$"))
                    {
                        if (txt_sodienthoai.Text.Length == 9 || txt_sodienthoai.Text.Length == 10)
                        {
                            ptb_sdt.Visible = true;
                        }
                        else
                        {
                            ptb_sdt.Visible = false;
                        }
                    }
                    else
                    {
                        ptb_sdt.Visible = false;
                    }
                }
                else
                {
                    ptb_sdt.Visible = false;
                }
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_email.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                ptb_email.Visible = true;
            }
            else
            {
                ptb_email.Visible = false;
            }
        }

        private void txt_website_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_website.Text, @"^\w+\.\w+$"))
            {
                ptb_website.Visible = true;
            }
            else
            {
                ptb_website.Visible = false;
            }
        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            if (txt_diachi.Text != "")
            {
                ptb_diachi.Visible = true;
            }
            else
            {
                ptb_diachi.Visible = false;
            }
        }
        //
        //---------------------MOUSEUP, MOUSERDOWN AND MOUSERHOVER EVENTS
        //
        private void btn_eye_MouseDown(object sender, MouseEventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = false;
        }

        private void btn_eye_MouseUp(object sender, MouseEventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = true;
        }

        private void btn_eye_MouseHover(object sender, EventArgs e)
        {
            der.SetToolTip(btn_eye, "Hiện mật khẩu");
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_Layquantrivien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter spm_tenquantrivien = new SqlParameter("@tenquantrivien", SqlDbType.NVarChar, 30);
            spm_tenquantrivien.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_tenquantrivien);

            SqlParameter spm_tencuahang = new SqlParameter("@tencuahang", SqlDbType.NVarChar, 30);
            spm_tencuahang.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spm_tencuahang);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                txt_tennguoiquanli.Text = spm_tenquantrivien.Value.ToString();
                txt_tencuahang.Text = spm_tencuahang.Value.ToString();
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
                this.Close();
            }
        }
    }
}
