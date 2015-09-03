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
    public partial class frm_guimail : Form
    {
        public frm_guimail()
        {
            InitializeComponent();
        }

        private void frm_guimail_Load(object sender, EventArgs e)
        {

        }

        private void frm_guimail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_gui.PerformClick();
            }

            if(e.KeyCode==Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            Common.SendMail("gsale.team@gmail.com", "kiris.nat@gmail.com", txt_tieude.Text, txt_noidung.Text, "g-sale.123", lbl_duongdan.Text);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_teptin_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image | *.jpg; *.png; *.gif";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            if(file.ShowDialog()==DialogResult.OK)
            {
                lbl_duongdan.Text = file.FileName;
            }
        }
    }
}
