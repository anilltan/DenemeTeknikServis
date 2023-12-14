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
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            labelControl12.Text = db.TBLILETISIM.Count().ToString();
            labelControl1.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            labelControl3.Text = db.TBLILETISIM.Where(x => x.KONU == "Rica").Count().ToString();
            labelControl5.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();
            labelControl7.Text = db.TBLILETISIM.Where(x => x.KONU == "Öneri").Count().ToString();
            labelControl7.Text = db.TBLPERSONEL.Count().ToString();
            labelControl9.Text = db.TBLCARI.Count().ToString();
            labelControl11.Text = db.TBLKATEGORI.Count().ToString();
            labelControl15.Text = db.TBLURUN.Count().ToString();

            gridControl1.DataSource = (from x in db.TBLILETISIM
                select new
                {
                    x.ID,
                    x.ADSOYAD,
                    x.MAIL,
                    x.KONU,
                    x.MESAJ
                }).ToList();
        }
    }
}
