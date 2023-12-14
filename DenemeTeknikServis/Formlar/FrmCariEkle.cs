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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private int secilen;
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lueIller.Properties.DataSource = (from x in db.TBLILLER
                select new
                {
                    x.id,
                    x.sehiradi
                }).ToList();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLCARI t = new TBLCARI();
                t.AD = txtAd.Text;
                t.SOYAD = txtSoyad.Text;
                t.IL = lueIller.Text;
                t.ILCE = lueIlceler.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni cari sisteme başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hatalı Giriş! Yeniden Deneyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureEdit15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lueIller_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lueIller.EditValue.ToString());
            lueIlceler.Properties.DataSource = (from y in db.TBLILCELER
                select new
                {
                    y.id,
                    y.ilceadi,
                    y.sehirid
                }).Where(z => z.sehirid == secilen).ToList();
        }
    }
}
    