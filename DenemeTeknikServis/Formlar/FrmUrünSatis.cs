using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeTeknikServis.Formlar
{
    public partial class FrmUrünSatis : Form
    {
        public FrmUrünSatis()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse(lueUrun.EditValue.ToString());
            t.MUSTERI = int.Parse(lueCari.EditValue.ToString());
            t.PERSONEL = short.Parse(luePersonel.EditValue.ToString());
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtSatisFiyati.Text);
            t.URUNSERINO = txtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }   

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUrünSatis_Load(object sender, EventArgs e)
        {
            lueUrun.Properties.DataSource = (from x in db.TBLURUN
                                             select new
                                             {
                                                 x.ID,
                                                 x.AD
                                             }).ToList();
            lueCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 x.ID,
                                                 AD = x.AD + " " + x.SOYAD
                                             }).ToList();
            luePersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }
    }
}
