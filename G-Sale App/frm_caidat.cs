using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Sale_App
{
    public partial class frm_caidat : Form
    {
        public frm_caidat()
        {
            InitializeComponent();
        }

        private void frm_caidat_Load(object sender, EventArgs e)
        {

        }

        private void frm_caidat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_apdung.PerformClick();
            }

            if(e.KeyCode==Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void btn_apdung_Click(object sender, EventArgs e)
        {
            DialogResult apdung;
            apdung = MessageBox.Show("Bạn có chắn là muốn thay đổi thiết lập? Việc thay đổi này sẽ ảnh hưởng đến toàn bộ hệ thống", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(apdung==DialogResult.Yes)
            {

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_macdinh_Click(object sender, EventArgs e)
        {
            DialogResult macdinh;
            macdinh = MessageBox.Show("Bạn có chắn là muốn thay đổi thiết lập về mặc định không? Việc thay đổi này sẽ ảnh hưởng đến toàn bộ hệ thống", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (macdinh == DialogResult.Yes)
            {
                lbl_chuoiketnoi.Text = @"Data Source=.\sqlexpress;Initial Catalog=GSale_App;Integrated Security=True";
            }      
        }

        private void btn_xemchuoiketnoi_Click(object sender, EventArgs e)
        {
            if(chb_chungthuc.Checked==true)
            {
                if(txt_taikhoan.Text=="" && txt_matkhau.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lbl_chuoiketnoi.Text = @"Data Source=" + txt_server.Text + ";Initial Catalog=" + txt_csdl.Text + ";Integrated Security=SSPI;User ID=" + txt_taikhoan.Text + ";Password=" + txt_matkhau.Text + "";
                }
            }
            else
            {
                lbl_chuoiketnoi.Text = @"Data Source=" + txt_server.Text + ";Initial Catalog=" + txt_csdl.Text + ";Integrated Security=True";
            }
        }

        private void chb_chungthuc_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_chungthuc.Checked==true)
            {
                txt_taikhoan.Enabled = true;
                txt_matkhau.Enabled = true;
                txt_taikhoan.Focus();
            }
            else
            {
                txt_taikhoan.Enabled = false;
                txt_matkhau.Enabled = false;
            }
        }
    }
}
