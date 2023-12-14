using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DenemeTeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();

            lblArizaliUrunSayisi.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            lblTadilatiBiten.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            lblToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblParcaBekleyen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            lblMesajMusteri.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            lblIptalEdilen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();



            SqlConnection baglanti = new SqlConnection(@"Data Source=DTITAN\SQLEXPRESS02;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select URUNDURUMDETAY,count(*) from TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            baglanti.Close();


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino= gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
