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
    public partial class frm_phuchoi : Form
    {
        public frm_phuchoi()
        {
            InitializeComponent();
        }

        private void frm_phuchoi_Load(object sender, EventArgs e)
        {

        }

        private void frm_phuchoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_thoat.PerformClick();
            }

            if(e.KeyCode==Keys.Enter)
            {
                btn_phuchoi.PerformClick();
            }
        }

        private void btn_phuchoi_Click(object sender, EventArgs e)
        {
            DialogResult phuchoi;
            phuchoi = MessageBox.Show("Hãy chắn rằng bạn muốn khôi phục lại toàn bộ CSDL?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (phuchoi == DialogResult.Yes)
            {
                try
                {
                    SQL.BackupandRestore("sp_Restore", "GSale_App", txt_duongdan.Text);
                    MessageBox.Show("Toàn bộ CSDL đã được phục hổi", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể phục hổi lại CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "File Bak| *.bak";
            file.RestoreDirectory = true;
            file.FilterIndex = 0;
            if(file.ShowDialog()==DialogResult.OK)
            {
                txt_duongdan.Text = file.FileName;
            }
        }
    }
}
