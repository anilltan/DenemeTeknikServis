
namespace DenemeTeknikServis.Formlar
{
    partial class FrmFaturaListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeri = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.txtSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.lueCari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.luePersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, -4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1014, 552);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(69, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "SERI:";
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(102, 78);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(222, 20);
            this.txtSeri.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_SaveLarge;
            this.btnKaydet.Location = new System.Drawing.Point(102, 273);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(222, 39);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreviewLarge;
            this.btnSil.Location = new System.Drawing.Point(102, 318);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 39);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_CustomizeLarge;
            this.btnGüncelle.Location = new System.Drawing.Point(102, 363);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(222, 39);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ParametersLarge;
            this.btnListele.Location = new System.Drawing.Point(102, 408);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(222, 39);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(78, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "ID: ";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(102, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 20);
            this.txtId.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "SIRA NO:";
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(102, 104);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Properties.Mask.EditMask = "AAAAAA";
            this.txtSiraNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSiraNo.Size = new System.Drawing.Size(222, 20);
            this.txtSiraNo.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "TARIH:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(66, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "SAAT:";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(102, 130);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Mask.EditMask = "99/99/00";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTarih.Size = new System.Drawing.Size(222, 20);
            this.txtTarih.TabIndex = 3;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(102, 158);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Properties.Mask.EditMask = "90:00";
            this.txtSaat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSaat.Size = new System.Drawing.Size(222, 20);
            this.txtSaat.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(19, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "VERGI DAIRESI:";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(102, 184);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(222, 20);
            this.txtVergiDairesi.TabIndex = 6;
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(102, 210);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.DisplayMember = "AD";
            this.lueCari.Properties.NullText = "";
            this.lueCari.Properties.ValueMember = "ID";
            this.lueCari.Size = new System.Drawing.Size(222, 20);
            this.lueCari.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(64, 213);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "CARI: ";
            // 
            // luePersonel
            // 
            this.luePersonel.Location = new System.Drawing.Point(102, 239);
            this.luePersonel.Name = "luePersonel";
            this.luePersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePersonel.Properties.DisplayMember = "AD";
            this.luePersonel.Properties.NullText = "";
            this.luePersonel.Properties.ValueMember = "ID";
            this.luePersonel.Size = new System.Drawing.Size(222, 20);
            this.luePersonel.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(38, 242);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "PERSONEL: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.luePersonel);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lueCari);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSaat);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSiraNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtSeri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1020, -4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(345, 552);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "FATURA İŞLEMLERİ";
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaListesi";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSeri;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSiraNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LookUpEdit lueCari;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit luePersonel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}