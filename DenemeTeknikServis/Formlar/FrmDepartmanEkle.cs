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
    public partial class FrmDepartmanEkle : Form
    {
        public FrmDepartmanEkle()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (txtAd.Text.Length <= 50 && txtAd.Text != "" )
            {
                t.AD = txtAd.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman başarıyla kaydedildi !", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı !", "Hata!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
