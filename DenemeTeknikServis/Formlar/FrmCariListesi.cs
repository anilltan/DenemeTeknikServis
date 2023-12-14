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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private int secilen;
        void getData()
        {
            var degerler = from u in db.TBLCARI
                select new
                {
                    u.ID,
                    u.AD,
                    u.SOYAD,
                    u.IL,
                    u.ILCE
                };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            getData();
            lblToplamCari.Text = db.TBLCARI.Count().ToString();
            lueIller.Properties.DataSource = (from x in db.TBLILLER
                select new
                {
                    x.id,
                    x.sehiradi
                }).ToList();
            lblToplamIl.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            lblToplamIlce.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text!="" && txtAd.Text.Length<=20 )
            {
                TBLCARI t = new TBLCARI();
                t.AD = txtAd.Text;
                t.SOYAD = txtSoyad.Text;
                t.IL = lueIller.Text;
                t.ILCE = lueIlceler.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                getData();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş! Yeniden Deneyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            getData();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLCARI.Find(id);
            deger.AD = txtAd.Text;
            deger.SOYAD = txtSoyad.Text;
            deger.TELEFON = txtTelefon.Text;
            deger.IL = lueIller.Text;
            deger.ILCE = lueIlceler.Text;
            deger.BANKA = txtBanka.Text;
            deger.VERGIDAIRESI = txtVergiDairesi.Text;
            deger.VERGINO = txtVergiNo.Text;
            deger.STATU = txtStatu.Text;
            deger.ADRES = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            getData();
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
                txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                lueIller.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
                lueIlceler.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata!");
                throw;
            }
        }
    }
}
