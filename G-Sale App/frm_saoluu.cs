using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace G_Sale_App
{
    public partial class frm_saoluu : Form
    {
        DirectoryInfo fol;
        ToolTip der;
        public frm_saoluu()
        {
            InitializeComponent();
            fol = new DirectoryInfo(@"C:\G-Sale\FTP_setting");
            der = new ToolTip();
        }

        private void frm_saoluu_Load(object sender, EventArgs e)
        {
            lbl_csdl.Text = Common.DocumentPath + @"\GSale.bak";
            //lbl_csdl.Text = @"D:\Gsale.bak";
            if (File.Exists(@"C:\G-Sale\FTP_setting\ftp.txt"))
            {
                chb_cauhinh.Checked = true;
                ArrayList ftp = new ArrayList();
                ftp = Common.LoadFTP();
                txt_hostname.Text = ftp[0].ToString();
                txt_taikhoan.Text = ftp[1].ToString();
                txt_matkhau.Text = ftp[2].ToString();
            }
        }

        private void frm_saoluu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_upload.PerformClick();
            }

            if(e.KeyCode==Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void ptb_000webhost_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.000webhost.com/order.php");
        }

        private void ptb_byehost_Click(object sender, EventArgs e)
        {
            Process.Start("https://byethost.com/free-hosting/news");
        }

        private void ptb_matbao_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.matbao.net/Mo-tai-khoan.aspx");
        }

        private void ptb_000webhost_MouseHover(object sender, EventArgs e)
        {
            der.SetToolTip(ptb_000webhost, "Đăng kí tài khoản hosting của 000WebHost - Hosting nước ngoài");
        }

        private void ptb_byehost_MouseHover(object sender, EventArgs e)
        {
            der.SetToolTip(ptb_byehost, "Đăng kí tài khoản hosting của Byehost - Hosting nước ngoài");
        }

        private void ptb_matbao_MouseHover(object sender, EventArgs e)
        {
            der.SetToolTip(ptb_matbao, "Đăng kí tài khoản hosting của Mắt bão - Hosting trong nước");
        }

        private void btn_chontep_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()==DialogResult.OK)
            {
                lbl_file.Text = file.FileName;
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (chb_cauhinh.Checked == true)
            {
                try
                {
                    fol.Create();
                }
                catch (Exception)
                {

                }
                finally
                {
                    Common.BurnFTP(txt_hostname.Text, txt_taikhoan.Text, txt_matkhau.Text);
                }
            }
            else
            {
                if (File.Exists(@"C:\G-Sale\FTP_setting\ftp.txt"))
                {
                    File.Delete(@"C:\G-Sale\FTP_setting\ftp.txt");
                }
            }
            
            if(rdb_csdl.Checked==true)
            { 
                DialogResult saoluu;
                saoluu = MessageBox.Show("Bạn có muốn sao lưu CSDL trước khi Upload không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (saoluu == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(lbl_csdl.Text);
                        SQL.BackupandRestore("sp_Backup", "GSale_App", lbl_csdl.Text);
                        MessageBox.Show("Sao lưu CSDL thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể sao lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (!File.Exists(lbl_csdl.Text))
                {
                    MessageBox.Show("Đường dẫn của tệp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Common.UpLoad(lbl_csdl.Text, txt_hostname.Text, txt_taikhoan.Text, txt_matkhau.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể upload CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    Common.UpLoad(lbl_file.Text, txt_hostname.Text, txt_taikhoan.Text, txt_matkhau.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể upload File", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
            
            
            
            
            
            
            
            
            
            

            
            
            
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void rdb_file_CheckedChanged(object sender, EventArgs e)
        {
            btn_chontep.Enabled = true;
            lbl_file.Enabled = true;
            lbl_csdl.Enabled = false;
        }

        private void rdb_csdl_CheckedChanged(object sender, EventArgs e)
        {
            btn_chontep.Enabled = false;
            lbl_file.Enabled = false;
            lbl_csdl.Enabled = true;
        }

    }
}
