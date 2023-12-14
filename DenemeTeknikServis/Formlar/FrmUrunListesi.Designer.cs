
namespace DenemeTeknikServis.Formlar
{
    partial class FrmUrunListesi
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1009, 550);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(108, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 20);
            this.txtId.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 76);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "ÜRÜN ID:";
            // 
            // btnListele
            // 
            this.btnListele.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ParametersLarge;
            this.btnListele.Location = new System.Drawing.Point(108, 409);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(222, 39);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_CustomizeLarge;
            this.btnGüncelle.Location = new System.Drawing.Point(108, 364);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(222, 39);
            this.btnGüncelle.TabIndex = 9;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreviewLarge;
            this.btnSil.Location = new System.Drawing.Point(108, 319);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 39);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_SaveLarge;
            this.btnKaydet.Location = new System.Drawing.Point(108, 274);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(222, 39);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 238);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "KATEGORİ:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(108, 235);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(222, 20);
            this.lookUpEdit1.TabIndex = 6;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(108, 205);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(222, 20);
            this.txtStok.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 208);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "STOK: ";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(108, 179);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(222, 20);
            this.txtSatisFiyat.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 182);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "SATIŞ FİYAT:";
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(108, 153);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(222, 20);
            this.txtAlisFiyat.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "ALIŞ FİYAT:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(108, 127);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(222, 20);
            this.txtMarka.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "MARKA: ";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(108, 101);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(222, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "ÜRÜN ADI:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.txtStok);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSatisFiyat);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAlisFiyat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtUrunAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1020, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(345, 550);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_PaperKind_Tabloid;
            this.btnTemizle.Location = new System.Drawing.Point(108, 454);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(222, 39);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}