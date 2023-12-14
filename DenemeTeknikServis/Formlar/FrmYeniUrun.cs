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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = txtUrunAd.Text;
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.KATEGORI = byte.Parse(lueKategori.EditValue.ToString());
            t.MARKA = txtMarka.Text;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler Başarıyla Kaydedildi !");
            this.Close();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrunAd_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "";
            txtUrunAd.Focus();
        }

        private void txtMarka_Click(object sender, EventArgs e)
        {
            txtMarka.Text = "";
            txtMarka.Focus();
        }

        private void txtAlisFiyat_Click(object sender, EventArgs e)
        {
            txtAlisFiyat.Text = "";
            txtAlisFiyat.Focus();
        }

        private void txtSatisFiyat_Click(object sender, EventArgs e)
        {
            txtSatisFiyat.Text = "";
            txtSatisFiyat.Focus();
        }

        private void txtStok_Click(object sender, EventArgs e)
        {
            txtStok.Text = "";
            txtStok.Focus();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lueKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                select new
                {
                    x.ID,
                    x.AD
                }).ToList();
        }
    }
}
