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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void getData()
        {
            var degerler = from u in db.TBLFATURABILGI
                select new
                {
                    u.ID,
                    u.SERI,
                    u.SIRANO,
                    u.TARIH,
                    u.SAAT,
                    u.VERGIDAIRE,
                    CARI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                    PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            getData();
            lueCari.Properties.DataSource = (from x in db.TBLCARI
                select new
                {
                    x.ID,
                    AD= x.AD + " " + x.SOYAD
                }).ToList();
            luePersonel.Properties.DataSource = (from y in db.TBLPERSONEL
                select new
                {
                    y.ID,
                    AD= y.AD + " " + y.SOYAD
                }).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = txtSeri.Text;
            t.SIRANO = txtSiraNo.Text;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.SAAT = txtSaat.Text;
            t.VERGIDAIRE = txtVergiDairesi.Text;
            t.CARI = int.Parse(lueCari.EditValue.ToString());
            t.PERSONEL = short.Parse(luePersonel.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura sisteme kaydedilmiştir, kalem girişi yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtSiraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            txtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            lueCari.Text = gridView1.GetFocusedRowCellValue("CARI").ToString();
            luePersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            db.TBLFATURABILGI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            deger.SERI = txtSeri.Text;
            deger.SIRANO = txtSiraNo.Text;
            deger.TARIH = DateTime.Parse(txtTarih.Text);
            deger.SAAT = txtSaat.Text;
            deger.VERGIDAIRE = txtVergiDairesi.Text;
            deger.CARI = int.Parse(lueCari.EditValue.ToString());
            deger.PERSONEL = short.Parse(luePersonel.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public string id;
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
