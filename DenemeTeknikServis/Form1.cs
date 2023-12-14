using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DenemeTeknikServis.Formlar;
using DevExpress.XtraRichEdit.Import.Html;

namespace DenemeTeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Formlar.FrmUrunListesi frU;
        private void btnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frU == null || frU.IsDisposed)
            {
                frU = new Formlar.FrmUrunListesi();
                frU.MdiParent = this;
                frU.Show();
            }
        }

        private Formlar.FrmYeniUrun frY;
        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frY == null || frY.IsDisposed)
            {
                frY = new Formlar.FrmYeniUrun();
                frY.Show();
            }
        }

        Formlar.FrmKategori frK;
        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frK == null || frK.IsDisposed)
            {
                frK = new Formlar.FrmKategori();
                frK.MdiParent = this;
                frK.Show();
            }
        }

        private Formlar.FrmYeniKategori frYk;
        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYk == null || frYk.IsDisposed)
            {
                frYk = new Formlar.FrmYeniKategori();
                frYk.Show();
            }
        }

        private Formlar.FrmIstatistik frI;
        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frI == null || frI.IsDisposed)
            {
                frI = new Formlar.FrmIstatistik();
                frI.MdiParent = this;
                frI.Show();
            }
        }

        private Formlar.FrmMarkalar frMi;
        private void btnMarkaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frMi == null || frMi.IsDisposed)
            {
                frMi = new Formlar.FrmMarkalar();
                frMi.MdiParent = this;
                frMi.Show();
            }
        }

        private Formlar.FrmCariListesi frCl;
        private void btnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCl == null || frCl.IsDisposed)
            {
                frCl = new Formlar.FrmCariListesi();
                frCl.MdiParent = this;
                frCl.Show();
            }
        }

        private Formlar.FrmCariIller frCi;
        private void btnCariIller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCi == null || frCi.IsDisposed)
            {
                frCi = new Formlar.FrmCariIller();
                frCi.MdiParent = this;
                frCi.Show();
            }
        }

        private Formlar.FrmCariEkle frYc;
        private void btnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYc == null || frYc.IsDisposed)
            {
                frYc = new Formlar.FrmCariEkle();
                frYc.Show();
            }
        }

        private Formlar.FrmDepartman frDl;
        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frDl == null || frDl.IsDisposed)
            {
                frDl = new Formlar.FrmDepartman();
                frDl.MdiParent = this;
                frDl.Show();
            }
        }

        private Formlar.FrmDepartmanEkle frYd;
        private void btnDepartmanEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYd == null || frYd.IsDisposed)
            {
                frYd = new Formlar.FrmDepartmanEkle();
                frYd.Show();
            }
        }

        private Formlar.FrmPersonel frPl;
        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frPl == null || frPl.IsDisposed)
            {
                frPl = new Formlar.FrmPersonel();
                frPl.MdiParent = this;
                frPl.Show();
            }
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private Formlar.FrmKurlar frDoK;
        private void btnDövizKurları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frDoK == null || frDoK.IsDisposed)
            {
                frDoK = new Formlar.FrmKurlar();
                frDoK.MdiParent = this;
                frDoK.Show();
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private Formlar.FrmYoutube frYo;
        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYo == null || frYo.IsDisposed)
            {
                frYo = new Formlar.FrmYoutube();
                frYo.MdiParent = this;
                frYo.Show();
            }
        }

        private Formlar.FrmNotlar frNot;
        private void btnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frNot == null || frNot.IsDisposed)
            {
                frNot = new Formlar.FrmNotlar();
                frNot.MdiParent = this;
                frNot.Show();
            }
        }

        private Formlar.FrmArizaListesi frAl;
        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frAl == null || frAl.IsDisposed)
            {
                frAl = new Formlar.FrmArizaListesi();
                frAl.MdiParent = this;
                frAl.Show();
            }
        }

        private Formlar.FrmUrünSatis frYu;
        private void btnYeniUrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYu == null || frYu.IsDisposed)
            {
                frYu = new Formlar.FrmUrünSatis();
                frYu.Show();
            }
        }

        private Formlar.FrmSatislar frSaL;
        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frSaL == null || frSaL.IsDisposed)
            {
                frSaL = new Formlar.FrmSatislar();
                frSaL.MdiParent = this;
                frSaL.Show();
            }
        }

        private Formlar.FrmArizaliUrunKaydi frAuk;
        private void btnArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frAuk == null || frAuk.IsDisposed)
            {
                frAuk = new Formlar.FrmArizaliUrunKaydi();
                frAuk.Show();
            }
        }

        private Formlar.FrmArizaDetaylar frAuac;
        private void btnArizaliUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frAuac == null || frAuac.IsDisposed)
            {
                frAuac = new Formlar.FrmArizaDetaylar();
                frAuac.Show();
            }
        }

        private Formlar.FrmArizaliUrunDetayListesi frAud;
        private void btnArizaliUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frAud == null || frAud.IsDisposed)
            {
                frAud = new Formlar.FrmArizaliUrunDetayListesi();
                frAud.MdiParent = this;
                frAud.Show();
            }
        }

        private Formlar.FrmQrCode frQr;
        private void btnQrCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frQr == null || frQr.IsDisposed)
            {
                frQr = new Formlar.FrmQrCode();
                frQr.Show();
            }
        }

        private Formlar.FrmFaturaListesi frFatL;
        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFatL == null || frFatL.IsDisposed)
            {
                frFatL = new Formlar.FrmFaturaListesi();
                frFatL.MdiParent = this;
                frFatL.Show();
            }
        }

        private Formlar.FrmFaturaDetay frFk;
        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFk == null || frFk.IsDisposed)
            {
                frFk = new Formlar.FrmFaturaDetay();
                frFk.MdiParent = this;
                frFk.Show();
            }
        }

        private Formlar.FrmFaturaSorgula frFad;
        private void btnFaturaDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFad == null || frFad.IsDisposed)
            {
                frFad = new Formlar.FrmFaturaSorgula();
                frFad.MdiParent = this;
                frFad.Show();
            }
        }

        private Formlar.FrmGauge frGa;
        private void btnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frGa == null || frGa.IsDisposed)
            {
                frGa = new Formlar.FrmGauge();
                frGa.MdiParent = this;
                frGa.Show();
            }
        }

        Formlar.FrmAnasayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnasayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnasayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        Formlar.FrmRehber frR;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frR == null || frR.IsDisposed)
            {
                frR = new Formlar.FrmRehber();
                frR.MdiParent = this;
                frR.Show();
            }
        }

        Formlar.FrmGelenMesajlar frGm;
        private void btnGelenMesaj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frGm == null || frGm.IsDisposed)
            {
                frGm = new Formlar.FrmGelenMesajlar();
                frGm.MdiParent = this;
                frGm.Show();
            }
        }

        Formlar.FrmMail frmM;
        private void btnYeniMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmM == null || frmM.IsDisposed)
            {
                frmM = new Formlar.FrmMail();
                frmM.Show();
            }
        }
    }
}
