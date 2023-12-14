using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeTeknikServis.Formlar
{
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIPP t = new TBLURUNTAKIPP();
            t.SERINO = txtSeriNo.Text;  
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.ACIKLAMA = richTextBox1.Text;
            db.TBLURUNTAKIPP.Add(t);
            
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunid = int.Parse(id.ToString());
            var deger = db.TBLURUNKABUL.Find(urunid);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün arıza detayları güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtSeriNo.Focus();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " " ;
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id, serino;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            txtSeriNo.Text = serino;
        }
    }
}
