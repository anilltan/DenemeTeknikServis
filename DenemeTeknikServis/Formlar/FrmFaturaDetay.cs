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
    public partial class FrmFaturaDetay : Form
    {
        public FrmFaturaDetay()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void getData()
        {
            var degerler = (from x in db.TBLFATURADETAY
                select new
                {
                    x.FATURADETAYID,
                    x.URUN,
                    x.ADET,
                    x.FIYAT,
                    x.TUTAR,
                    x.FATURAID
                }).ToList();
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = txtUrun.Text;
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.TUTAR = decimal.Parse(txtTutar.Text);
            t.FATURAID = int.Parse(txtFaturaId.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya ait kalem girişi başarı ile yapılmıştır.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDetayId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = txtUrun.Text;
            deger.ADET = short.Parse(txtAdet.Text);
            deger.FIYAT = decimal.Parse(txtFiyat.Text);
            deger.TUTAR = decimal.Parse(txtTutar.Text);
            deger.FATURAID = int.Parse(txtFaturaId.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemleri Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDetayId.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            txtUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            txtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            txtFaturaId.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDetayId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemlerii Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
