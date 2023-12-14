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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void getData()
        {
            var degerler = from u in db.TBLDEPARTMAN
                select new
                {
                    u.ID,
                    u.AD
                };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            getData();

            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (txtAd.Text.Length<=50 && txtAd.Text!="" && rtxtAciklama.Text.Length >=1)
            {
                t.AD = txtAd.Text;
                t.ACIKLAMA = rtxtAciklama.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman başarıyla kaydedildi !", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı !", "Hata!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
