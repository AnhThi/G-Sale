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

namespace G_Sale_App
{
    public partial class frm_vegsale : Form
    {
        public frm_vegsale()
        {
            InitializeComponent();
        }

        private void frm_vegsale_Load(object sender, EventArgs e)
        {
            if(Common.Mabanquyen!="")
            {
                lbl_banquyen.Text = "Đã đăng kí";
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_trangchu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://g-sale.com");
        }
    }
}
