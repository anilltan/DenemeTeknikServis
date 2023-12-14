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
    public partial class FrmArizaliUrunDetayListesi : Form
    {
        public FrmArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNTAKIPP
                select new
                {
                    x.TAKIPID,
                    x.SERINO,
                    x.TARIH,
                    x.ACIKLAMA
                };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
