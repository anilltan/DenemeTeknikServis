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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        void getData()
        {
            var degerler = from u in db.TBLPERSONEL
                select new
                {
                    u.ID,
                    u.AD,
                    u.SOYAD,
                    DEPARTMAN = u.TBLDEPARTMAN.AD,
                    u.MAIL,
                    u.TELEFON
                };
            gridControl1.DataSource = degerler.ToList();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            getData();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                select new
                {
                    x.ID,
                    x.AD
                }).ToList();

            //1.Personel
            labelControl30.Text = db.TBLPERSONEL.First(x => x.ID == 1).AD + " " +
                                  db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl28.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl26.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;

            //2.Personel
            labelControl12.Text = db.TBLPERSONEL.First(x => x.ID == 2).AD + " " +
                                  db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl10.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl8.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;

            //3.Personel
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 3).AD + " " +
                                  db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl14.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;

            //4.Personel
            labelControl24.Text = db.TBLPERSONEL.First(x => x.ID == 4).AD + " " +
                                  db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl22.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl20.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;


            //diğer yol..
            //string ad1, soyad1;
            //ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            //soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;

            //labelControl30.Text = ad1 + " " + soyad1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MAIL = txtMail.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            deger.AD = txtAd.Text;
            deger.SOYAD = txtSoyad.Text;
            deger.MAIL = txtMail.Text;
            deger.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
        }
    }
}
