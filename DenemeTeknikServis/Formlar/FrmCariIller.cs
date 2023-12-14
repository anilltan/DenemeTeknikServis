using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DenemeTeknikServis.Formlar
{
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private SqlConnection baglanti =
            new SqlConnection(
                @"Data Source=DTITAN\SQLEXPRESS02;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("ANKARA", 22));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("ISTANBUL", 67));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("IZMIR", 50));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("ADANA", 40));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("TEKIRDAG", 37));
            //chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("BURSA", 24));

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new
            {
                İL = z.Key,
                TOPLAM = z.Count()
            }).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT IL,COUNT(*) FROM TBLCARI GROUP BY IL",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0],dr[1]));
            }
            baglanti.Close();
        }
    }
}
