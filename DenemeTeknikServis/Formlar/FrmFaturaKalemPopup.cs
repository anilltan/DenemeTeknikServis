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
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        public int id;
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            gridControl1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();
        }

        private void peExcel_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Xlsx";
            gridControl1.ExportToXlsx(path);
        }

        private void pePdf_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }

        private void peClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
