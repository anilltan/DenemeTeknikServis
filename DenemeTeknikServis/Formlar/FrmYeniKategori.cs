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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text==" " && txtKategoriAd.Text.Length<=30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = txtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürünler Başarıyla Kaydedildi !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen karakter sayısını 0-30 arasında giriniz!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
