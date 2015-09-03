using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Collections;
using System.Data.OleDb;
using System.Runtime.Serialization.Formatters.Binary;

namespace G_Sale_App
{
    public class Common
    {
        //
        //---------------------FIELDS
        //
        public static string Manhanvien = "";
        public static string TenNguoiTruyCap = "";
        public static int TinhTrangDangNhap = 1;//dang nhap that bai
        public static string Mabanquyen = "";
        public static string DocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\G-Sale\database";

        public static string Tencuahang = "";
        public static byte[] logo;
        public static string diachi="";
        public static string sdt = "";
        //
        //---------------------MENTHOD
        //
        public static string[] License()
        {
            string[] lic = new string[] { "A123-B123-C123-D123", "V58D-5A2C-10GT-DX36", "TR47-AC68-QCX3-9ALK", "2030-ZX5X-AW5W-203H" };
            return lic;
        }
        public static string MaHoaMD5(string text)
        {
            UTF32Encoding utf = new UTF32Encoding();
            MD5CryptoServiceProvider mcsp = new MD5CryptoServiceProvider();
            byte[] bit1 = utf.GetBytes(text);
            byte[] bit2 = mcsp.ComputeHash(bit1);
            return Convert.ToBase64String(bit2);
        }

        public static void ChuyenDong(PictureBox img, int length)
        {
            int i = 0;
            while (i < length)
            {
                img.Location = new Point(img.Location.X, img.Location.Y + 1);
                Application.DoEvents();
                Thread.Sleep(3);
                i++;
            }
        }

        public static Image FromImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            Image result = Image.FromStream(ms);
            return result;
        }

        public static byte[] ToImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static void UpLoad(string path, string hostname, string user, string password)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(hostname + file.Name);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, password);
                Stream ftpstream = request.GetRequestStream();
                FileStream filestream = File.OpenRead(path);
                int length = 1024;
                byte[] buffer = new byte[length];
                int byteread = 0;
                do
                {
                    byteread = filestream.Read(buffer, 0, length);
                    ftpstream.Write(buffer, 0, byteread);
                } while (byteread != 0);
                filestream.Close();
                MessageBox.Show("Upload tệp tin vào Hosting thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SendMail(string from, string to, string subject, string content, string password, string path)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = content;

                Attachment attach = new Attachment(path);
                mail.Attachments.Add(attach);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Cám ơn bạn đã gửi phản hồi cho chúng tôi. Thư của bạn sẽ được trả lời sớm nhất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void BurnFTP(string hostname, string user, string password)
        {
            ArrayList ftp = new ArrayList();
            ftp.Add(hostname);
            ftp.Add(user);
            ftp.Add(password);
            FileStream s2 = new FileStream(@"C:\G-Sale\FTP_setting\ftp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();
            bf2.Serialize(s2, ftp);
            s2.Close();
        }

        public static ArrayList LoadFTP()
        {
            ArrayList user_pass = new ArrayList();
            FileStream s1 = new FileStream(@"C:\G-Sale\FTP_setting\ftp.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            user_pass = (ArrayList)bf1.Deserialize(s1);
            s1.Close();
            return user_pass;
        }
    }
}
