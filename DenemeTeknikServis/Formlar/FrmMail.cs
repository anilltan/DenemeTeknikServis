using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using DevExpress.XtraCharts.Native;

namespace DenemeTeknikServis.Formlar
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "gonderici";
            string password = "şifreniz";
            string alici = txtAlici.Text;
            string konu = txtKonu.Text;
            string icerik = txtIcerik.Text;
            mail.From = new MailAddress(frommail);
            mail.To.Add(alici); //mailin  kime yollanacagı
            mail.Subject = konu; //mailin konusu
            mail.Body = icerik; //mailin içeriği
            mail.IsBodyHtml = true; //içerik html
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);  //mail protokol //parantez içindeki --> hangi hostun kullanılacagı
            smtp.Credentials = new NetworkCredential(frommail,password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Mail gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
