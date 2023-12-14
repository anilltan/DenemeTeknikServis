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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lueMusteri.EditValue.ToString());
            t.PERSONEL = short.Parse(luePersonel.EditValue.ToString());
            t.GELISTARIHI=DateTime.Parse(txtTarih.Text);
            t.URUNSERINO = lueSeriNo.EditValue.ToString();
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı ürün başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //MÜŞTERİ
            lueMusteri.Properties.DataSource = (from x in db.TBLCARI
                select new
                {
                    x.ID,
                    ADSOYAD = x.AD + " " + x.SOYAD
                }).ToList();

            //PERSONEL
            luePersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                select new
                {
                    x.ID,
                    ADSOYAD = x.AD + " " + x.SOYAD
                }).ToList();

            //SeriNo
            lueSeriNo.Properties.DataSource = (from x in db.TBLURUNHAREKET
                select new
                {
                    x.URUNSERINO
                }).ToList();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
