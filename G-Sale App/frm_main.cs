using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.IO;

namespace G_Sale_App
{
    public partial class frm_main : Form
    {
        SqlConnection cnn;
        frm_dangnhap dangnhap;
        SoundPlayer player;
        DirectoryInfo doc;

        string tenhh, giaban;
        int soluong;
        double giaban_tinh, thanhtien, dong, tongtien;

        DataTable dt;
        public frm_main()
        {
            InitializeComponent();
            cnn = SQL.cnn;
            dangnhap = new frm_dangnhap();
            player = new SoundPlayer(@"audio\beep.wav");
            doc = new DirectoryInfo(Common.DocumentPath);

            tongtien = 0;
            dong = 0;
            //
            //-----------------------TAO BANG VA ADD VAO DATAGRIDVIEW
            //
            dt = new DataTable();
            dt.Columns.Add("Tên hàng hóa");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Giá bán");
            dgv_bang.DataSource = dt;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\G-Sale\database"))
            {

            }
            else
            {
                doc.Create();
            }
            //
            //-------------------------------------THÔNG SỐ ĐẦU CHO COMBOBOX
            //
            cbo_quay.SelectedIndex = 0;
            cbo_giamgia.SelectedIndex = 0;
            //
            //---------------------------------------KIỂM TRA ĐĂNG KÍ
            //
            DataTable kiemtradangky = new DataTable();
            kiemtradangky = SQL.DocBang("sp_Kiemtradangky");
            if (kiemtradangky.Rows.Count == 0)
            {
                frm_dangky dangky = new frm_dangky();
                dangky.ShowDialog();
            }
            else
            {
                dangnhap.ShowDialog();
            }
            //
            //---------------------------------------LOAD THÔNG TIN CỬA HÀNG
            //
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

                Common.Tencuahang = spm_tencuahang.Value.ToString();
                Common.logo = (byte[])spm_logo.Value;
                Common.diachi = spm_diachi.Value.ToString();
                Common.sdt = "0" + spm_sdt.Value.ToString();

                lbl_tencuahang.Text = Common.Tencuahang;
                lbl_diachi.Text = "Địa chỉ: " + Common.diachi;
                lbl_sodienthoai.Text = "Số điện thoại: " + Common.sdt;
                ptb_logo.Image = Common.FromImage(Common.logo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load thông tin của quản trị viên" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                mnu_hethong.RaiseClick();
            }

            if (e.KeyCode == Keys.F2)
            {
                mnu_nhanvien.RaiseClick();
            }

            if (e.KeyCode == Keys.F3)
            {
                mnu_hanghoa.RaiseClick();
            }

            if (e.KeyCode == Keys.F4)
            {
                mnu_nhacungcap.RaiseClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                mnu_hoadon.RaiseClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                mnu_trogiup.RaiseClick();
            }

            if (e.KeyData == (Keys.Control | Keys.X))
            {
                frm_dangnhap dangnhap = new frm_dangnhap();
                dangnhap.ShowDialog();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btn_themvaohoadon.PerformClick();
            }

            if (e.KeyData == (Keys.Control | Keys.M))
            {
                btn_hoadonmoi.PerformClick();
            }

            if (e.KeyData == (Keys.Control | Keys.L))
            {
                btn_luu.PerformClick();
            }

            if (e.KeyData == (Keys.Control | Keys.I))
            {
                btn_inhd.PerformClick();
            }
        }

        private void frm_main_Activated(object sender, EventArgs e)
        {
            if (Common.TinhTrangDangNhap == 0)//đăng nhập thành công
            {
                lbl_tennguoitruycap.Text = Common.TenNguoiTruyCap;
                lbl_manhanvien.Text = Common.Manhanvien;
                ptb_dangxuat.Visible = true;

                mnu_hethong.Enabled = true;
                mnu_nhanvien.Enabled = true;
                mnu_hanghoa.Enabled = true;
                mnu_nhacungcap.Enabled = true;
                mnu_hoadon.Enabled = true;
                mnu_trogiup.Enabled = true;

                pan_hethong.Visible = true;
                pan_hanghoa.Visible = true;
                pan_hoadon.Visible = true;
                pan_trogiup.Visible = true;
            }
            else
            {
                ptb_dangxuat.Visible = false;
                lbl_manhanvien.Text = Common.Manhanvien;
                lbl_tennguoitruycap.Text = Common.TenNguoiTruyCap;
                mnu_hethong.Enabled = false;
                mnu_nhanvien.Enabled = false;
                mnu_hanghoa.Enabled = false;
                mnu_nhacungcap.Enabled = false;
                mnu_hoadon.Enabled = false;
                mnu_trogiup.Enabled = false;

                pan_hethong.Visible = false;
                pan_hanghoa.Visible = false;
                pan_hoadon.Visible = false;
                pan_trogiup.Visible = false;
            }
        }
        //
        //----------------------XỬ LÍ NGHIỆP VỤ BÁN HÀNG
        //
        private void txt_tenhanghoatim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_tenhanghoatim.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_Layhanghoa", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenhh", txt_tenhanghoatim.Text);

                SqlParameter spm_tenhh = new SqlParameter("@tenhh_lay", SqlDbType.NVarChar, 100);
                spm_tenhh.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(spm_tenhh);

                SqlParameter spm_giaban = new SqlParameter("@giaban", SqlDbType.Money);
                spm_giaban.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(spm_giaban);

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    tenhh = spm_tenhh.Value.ToString();
                    giaban = spm_giaban.Value.ToString();
                    if (tenhh != null)
                    {
                        txt_tenhanghoa.Text = tenhh;
                        //SendKeys.Send("{BS}");
                        txt_giaban.Text = giaban;
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
            else
            {
                txt_tenhanghoa.Clear();
                txt_giaban.Clear();
            }
        }
        //
        //-----------------------------------------NÚT HÓA ĐƠN MỚI
        //
        private void btn_hoadonmoi_Click(object sender, EventArgs e)
        {
            btn_themvaohoadon.Enabled = true;
            btn_luu.Enabled = true;
            btn_inhd.Enabled = true;
            btn_hoadonmoi.Enabled = false;

            txt_mahoadon.Enabled = true;
            txt_ngaylaphd.Enabled = true;
            cbo_quay.Enabled = true;
            txt_tenhanghoatim.Enabled = true;
            txt_soluong.Enabled = true;
            txt_tenhanghoa.Enabled = true;
            txt_giaban.Enabled = true;
            cbo_giamgia.Enabled = false;
            txt_giamgia.Enabled = true;
            txt_tongtien.Enabled = true;


            txt_mahoadon.Text = DateTime.Now.ToString("yyMMddhhmmss");
            txt_ngaylaphd.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_tenhanghoa.Clear();
            txt_tenhanghoatim.Focus();
            txt_soluong.Text = "1";
            txt_giaban.Clear();
            //foreach (DataGridViewRow i in dgv_bang.Rows)
            //{
            //    dgv_bang.Rows.RemoveAt(i.Index);
            //}
            cbo_giamgia.SelectedIndex = 1;
            txt_giamgia.Clear();
            txt_tongtien.Clear();
        }

        private void btn_themvaohoadon_Click(object sender, EventArgs e)
        {
            if(txt_tenhanghoa.Text=="" || txt_soluong.Text=="" || txt_giaban.Text=="")
            {
                txt_tenhanghoatim.Focus();
                return;
            }
            
            giaban_tinh = double.Parse(txt_giaban.Text);
            soluong = int.Parse(txt_soluong.Text.Trim());
            thanhtien = soluong * giaban_tinh;
            txt_tenhanghoatim.Clear();
            txt_tenhanghoatim.Focus();

            DataRow row_ = dt.NewRow();
            row_[0] = txt_tenhanghoa.Text;
            row_[1] = txt_soluong.Text;
            row_[2] = thanhtien.ToString();
            dt.Rows.Add(row_);
            dgv_bang.DataSource = dt;

            txt_soluong.Text = "1";

            try
            {
                string val = (dgv_bang.Rows[dgv_bang.Rows.Count - 2].Cells[2].Value.ToString());
                dong = double.Parse(val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tongtien = tongtien + dong;
            txt_tongtien.Text = tongtien.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            report_hanghoa hanghoa = new report_hanghoa();
            hanghoa.ShowDialog();
        }
        //
        //-----------------------------------------------TIMER THỜI GIAN
        //
        private void tim_Tick(object sender, EventArgs e)
        {
            lbl_ngaythang.Text = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
        }

        
        //
        //-----------------------------------------------MOUSE HOVER EVENT
        //
        private void ptb_caidat_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_caidat, 13);
            player.PlaySync();
        }

        private void ptb_saoluu_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_saoluu, 13);
            player.PlaySync();
        }

        private void ptb_phuchoi_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_phuchoi, 13);
            player.PlaySync();
        }

        private void ptb_chinhsuathongtin_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_chinhsuathongtin, 13);
            player.PlaySync();
        }

        private void ptb_danhmuchanghoa_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_danhmuchanghoa, 13);
            player.PlaySync();
        }

        private void ptb_tatcahanghoa_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_tatcahanghoa, 13);
            player.PlaySync();
        }

        private void ptb_lapdondathang_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_lapdondathang, 13);
            player.PlaySync();
        }

        private void ptb_hoadondalap_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_hoadondalap, 13);
            player.PlaySync();
        }

        private void ptb_hotro_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_hotro, 13);
            player.PlaySync();
        }

        private void ptb_banquyen_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_banquyen, 13);
            player.PlaySync();
        }

        private void ptb_vegsale_MouseHover(object sender, EventArgs e)
        {
            Common.ChuyenDong(ptb_vegsale, 13);
            player.PlaySync();
        }

        private void ptb_dangxuat_MouseHover(object sender, EventArgs e)
        {
            player.PlaySync();
        }
        //
        //------------------------------------MOUSER LEAVE
        //
        private void ptb_caidat_MouseLeave(object sender, EventArgs e)
        {
            ptb_caidat.Location = new Point(70, 15);
        }

        private void ptb_saoluu_MouseLeave(object sender, EventArgs e)
        {
            ptb_saoluu.Location = new Point(200, 15);
        }

        private void ptb_phuchoi_MouseLeave(object sender, EventArgs e)
        {
            ptb_phuchoi.Location = new Point(330, 15);
        }

        private void ptb_chinhsuathongtin_MouseLeave(object sender, EventArgs e)
        {
            ptb_chinhsuathongtin.Location = new Point(460, 15);
        }

        private void ptb_danhmuchanghoa_MouseLeave(object sender, EventArgs e)
        {
            ptb_danhmuchanghoa.Location = new Point(70, 15);
        }

        private void ptb_tatcahanghoa_MouseLeave(object sender, EventArgs e)
        {
            ptb_tatcahanghoa.Location = new Point(200, 15);
        }

        private void ptb_lapdondathang_MouseLeave(object sender, EventArgs e)
        {
            ptb_lapdondathang.Location = new Point(70, 15);
        }

        private void ptb_hoadondalap_MouseLeave(object sender, EventArgs e)
        {
            ptb_hoadondalap.Location = new Point(200, 15);
        }

        private void ptb_hotro_MouseLeave(object sender, EventArgs e)
        {
            ptb_hotro.Location = new Point(70, 15);
        }

        private void ptb_banquyen_MouseLeave(object sender, EventArgs e)
        {
            ptb_banquyen.Location = new Point(200, 15);
        }

        private void ptb_vegsale_MouseLeave(object sender, EventArgs e)
        {
            ptb_vegsale.Location = new Point(330, 15);
        }
        //
        //-------------------------------------------MOUSE CLICK
        //
        private void ptb_caidat_Click(object sender, EventArgs e)
        {

        }

        private void ptb_saoluu_Click(object sender, EventArgs e)
        {
            frm_saoluu saoluu = new frm_saoluu();
            saoluu.ShowDialog();
        }

        private void ptb_phuchoi_Click(object sender, EventArgs e)
        {
            frm_phuchoi phuchoi = new frm_phuchoi();
            phuchoi.ShowDialog();
        }

        private void ptb_chinhsuathongtin_Click(object sender, EventArgs e)
        {
            frm_chinhsuaquantrivien chinhsua = new frm_chinhsuaquantrivien();
            chinhsua.ShowDialog();
        }

        private void mnu_nhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien nhanvien = new frm_nhanvien();
            nhanvien.ShowDialog();
        }

        private void ptb_danhmuchanghoa_Click(object sender, EventArgs e)
        {
            frm_danhmuc danhmuc = new frm_danhmuc();
            danhmuc.ShowDialog();
        }

        private void ptb_tatcahanghoa_Click(object sender, EventArgs e)
        {
            frm_hanghoa hanghoa = new frm_hanghoa();
            hanghoa.ShowDialog();
        }

        private void mnu_nhacungcap_Click(object sender, EventArgs e)
        {
            frm_nhacungcap nhacc = new frm_nhacungcap();
            nhacc.ShowDialog();
        }

        private void ptb_lapdondathang_Click(object sender, EventArgs e)
        {

        }

        private void ptb_hoadondalap_Click(object sender, EventArgs e)
        {

        }

        private void ptb_hotro_Click(object sender, EventArgs e)
        {
            frm_guimail gui = new frm_guimail();
            gui.ShowDialog();
        }

        private void ptb_banquyen_Click(object sender, EventArgs e)
        {
            frm_banquyen banquyen = new frm_banquyen();
            banquyen.ShowDialog();
        }

        private void ptb_vegsale_Click(object sender, EventArgs e)
        {
            frm_vegsale vegsale = new frm_vegsale();
            vegsale.ShowDialog();
        }

        private void ptb_dangxuat_Click(object sender, EventArgs e)
        {
            frm_dangnhap dangnhap = new frm_dangnhap();
            dangnhap.ShowDialog();
        }
        //
        //----------------------------------XU LI GIAM GIA
        //
        private void rdb_giamgiaphantram_CheckedChanged(object sender, EventArgs e)
        {
            txt_giamgia.Text = "0";
            if(rdb_giamgiaphantram.Checked==true)
            {
                cbo_giamgia.Enabled = true;
                txt_giamgia.Enabled = false;
            }
        }

        private void rdb_giamgiatext_CheckedChanged(object sender, EventArgs e)
        {
            cbo_giamgia.SelectedIndex = 0;
            if (rdb_giamgiatext.Checked == true)
            {
                cbo_giamgia.Enabled = false;
                txt_giamgia.Enabled = true;
            }
        }

        private void cbo_giamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            double tongtien_moi;
            string phantram_text = cbo_giamgia.Text.Substring(0,cbo_giamgia.Text.LastIndexOf("%"));
            int phantram = int.Parse(phantram_text);
            tongtien_moi = (tongtien * phantram) / 100;
            txt_tongtien.Text = (tongtien - tongtien_moi).ToString();
        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            if(txt_giamgia.Text!="")
            {
                double giamgia_text;
                giamgia_text = double.Parse(txt_giamgia.Text);
                txt_tongtien.Text = (tongtien - giamgia_text).ToString();
            }
            else
            {
                txt_giamgia.Text = "0";
            }
        }
        //
        //------------------------------------CHUYEN FOCUS
        //
        private void txt_tenhanghoatim_KeyDown(object sender, KeyEventArgs e)
        {
            txt_soluong.Text = "1";
            if(e.KeyCode==Keys.Enter)
            {
                txt_soluong.Focus();
            }
        }

        private void txt_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            txt_soluong.Text = "1";
            if(e.KeyCode==Keys.Enter)
            {
                txt_tenhanghoatim.Focus();
            }
        }
    }
}
