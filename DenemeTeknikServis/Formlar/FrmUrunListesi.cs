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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void getData()
        {
            var degerler = from u in db.TBLURUN
                select new
                {
                    u.ID, 
                    u.AD,
                    u.MARKA,
                    KATEGORI = u.TBLKATEGORI.AD,
                    u.STOK,
                    u.ALISFIYAT,
                    u.SATISFIYAT
                };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            // Listeleme ToList Add Remove
            // var degerler = db.TBLURUN.ToList();
            getData();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                select new
                {
                    x.ID,
                    x.AD
                }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = txtUrunAd.Text;
            t.MARKA = txtMarka.Text;
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.DURUM = false;
            t.KATEGORI =byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata!");
                throw;
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = txtUrunAd.Text;
            deger.MARKA = txtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            deger.STOK = short.Parse(txtStok.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtUrunAd.Text = "";
            txtMarka.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            txtStok.Text = "";
            lookUpEdit1.Text = "";
        }
    }
}
