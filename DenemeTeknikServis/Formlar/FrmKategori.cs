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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void getData()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtAd.Text != "" && txtAd.Text.Length <= 30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = txtAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi !");
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Uzun Olamaz!");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtId.Text = "";
        }
    }
}
