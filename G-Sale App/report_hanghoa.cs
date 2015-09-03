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
    public partial class report_hanghoa : Form
    {
        public report_hanghoa()
        {
            InitializeComponent();
        }

        private void report_hanghoa_Load(object sender, EventArgs e)
        {
            rpt_hanghoa hh = new rpt_hanghoa();
            crv_danhsachhanghoa.ReportSource = hh;
;
        }
    }
}
