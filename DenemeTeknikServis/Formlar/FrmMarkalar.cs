using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Data.SqlClient;

namespace DenemeTeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmMarkaIstatistik_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();

            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = (from x in db.TBLURUN
                                  select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending
                                  select x.AD).FirstOrDefault();
            labelControl5.Text = db.encokmarka().FirstOrDefault();

         
            //1.Chart
            SqlConnection baglanti = new SqlConnection(@"Data Source=DTITAN\SQLEXPRESS02;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,count(*) from TBLURUN GROUP BY MARKA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            baglanti.Close();

            //2.Chart
            SqlConnection baglanti2 = new SqlConnection(@"Data Source=DTITAN\SQLEXPRESS02;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti2.Open();
            SqlCommand komut2 = new SqlCommand("select TBLKATEGORI.AD,count(*) from TBLURUN inner join TBLKATEGORI on TBLKATEGORI.ID=tblurun.KATEGORI group by TBLKATEGORI.AD", baglanti2);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));
            }
            baglanti2.Close();



        }
    }
}
