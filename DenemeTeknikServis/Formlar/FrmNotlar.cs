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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        private DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gcOkunmayan.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gcOkunan.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = txtBaslik.Text;
            t.ICERIK = txtIcerik.Text;
            t.DURUM = false;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLNOTLARIM.Find(id);
            db.TBLNOTLARIM.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (ceDurum.Checked==true)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gcOkunmayan.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gcOkunan.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }

        private void gvOkunmayan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gvOkunmayan.GetFocusedRowCellValue("ID").ToString();
            //txtBaslik.Text = gvOkunmayan.GetFocusedRowCellValue("BASLIK").ToString();
            //txtIcerik.Text = gvOkunmayan.GetFocusedRowCellValue("ICERIK").ToString();
        }

        private void gvOkunan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gvOkunan.GetFocusedRowCellValue("ID").ToString();
            //txtBaslik.Text = gvOkunan.GetFocusedRowCellValue("BASLIK").ToString();
            //txtIcerik.Text = gvOkunan.GetFocusedRowCellValue("ICERIK").ToString();
        }
    }
}
