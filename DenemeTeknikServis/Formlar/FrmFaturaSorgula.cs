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
    public partial class FrmFaturaSorgula : Form
    {
        public FrmFaturaSorgula()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmFaturaSorgula_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
                var degerler = (from x in db.TBLFATURADETAY
                    select new
                    {
                        x.FATURADETAYID,
                        x.URUN,
                        x.ADET,
                        x.FIYAT,
                        x.TUTAR,
                        x.FATURAID
                    }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler.ToList();
        }
    }
}
