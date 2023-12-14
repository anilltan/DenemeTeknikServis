
namespace DenemeTeknikServis.Formlar
{
    partial class FrmNotlar
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
            this.gcOkunmayan = new DevExpress.XtraGrid.GridControl();
            this.gvOkunmayan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ceDurum = new DevExpress.XtraEditors.CheckEdit();
            this.txtIcerik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcOkunan = new DevExpress.XtraGrid.GridControl();
            this.gvOkunan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcOkunmayan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOkunmayan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOkunan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOkunan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOkunmayan
            // 
            this.gcOkunmayan.Location = new System.Drawing.Point(5, 31);
            this.gcOkunmayan.MainView = this.gvOkunmayan;
            this.gcOkunmayan.Name = "gcOkunmayan";
            this.gcOkunmayan.Size = new System.Drawing.Size(978, 235);
            this.gcOkunmayan.TabIndex = 21;
            this.gcOkunmayan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOkunmayan});
            // 
            // gvOkunmayan
            // 
            this.gvOkunmayan.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gvOkunmayan.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.gvOkunmayan.Appearance.Row.Options.UseBackColor = true;
            this.gvOkunmayan.GridControl = this.gcOkunmayan;
            this.gvOkunmayan.Name = "gvOkunmayan";
            this.gvOkunmayan.OptionsView.ShowGroupPanel = false;
            this.gvOkunmayan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOkunmayan_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.ceDurum);
            this.groupControl1.Controls.Add(this.txtIcerik);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtBaslik);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(989, -5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(376, 552);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "AJANDA İŞLEMLERİ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "DURUM:";
            // 
            // ceDurum
            // 
            this.ceDurum.Location = new System.Drawing.Point(103, 156);
            this.ceDurum.Name = "ceDurum";
            this.ceDurum.Properties.Caption = "Okundu Olarak İşaretle";
            this.ceDurum.Size = new System.Drawing.Size(143, 19);
            this.ceDurum.TabIndex = 4;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(105, 105);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(222, 20);
            this.txtIcerik.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(48, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "ICERIK:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(105, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 20);
            this.txtId.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 54);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "NOT ID: ";
            // 
            // btnListele
            // 
            this.btnListele.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ParametersLarge;
            this.btnListele.Location = new System.Drawing.Point(105, 367);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(222, 39);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_CustomizeLarge;
            this.btnGüncelle.Location = new System.Drawing.Point(105, 322);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(222, 39);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreviewLarge;
            this.btnSil.Location = new System.Drawing.Point(105, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 39);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_SaveLarge;
            this.btnKaydet.Location = new System.Drawing.Point(105, 232);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(222, 39);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(105, 79);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(222, 20);
            this.txtBaslik.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "BASLIK: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Okunmayan Notlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Okunan Notlar";
            // 
            // gcOkunan
            // 
            this.gcOkunan.Location = new System.Drawing.Point(5, 299);
            this.gcOkunan.MainView = this.gvOkunan;
            this.gcOkunan.Name = "gcOkunan";
            this.gcOkunan.Size = new System.Drawing.Size(978, 235);
            this.gcOkunan.TabIndex = 24;
            this.gcOkunan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOkunan});
            // 
            // gvOkunan
            // 
            this.gvOkunan.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(185)))), ((int)(((byte)(139)))));
            this.gvOkunan.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(107)))));
            this.gvOkunan.Appearance.Row.Options.UseBackColor = true;
            this.gvOkunan.GridControl = this.gcOkunan;
            this.gvOkunan.Name = "gvOkunan";
            this.gvOkunan.OptionsView.ShowGroupPanel = false;
            this.gvOkunan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOkunan_FocusedRowChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(105, 130);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Mask.EditMask = "d";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtTarih.Size = new System.Drawing.Size(222, 20);
            this.txtTarih.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(48, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "TARİH:";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcOkunan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcOkunmayan);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmNotlar";
            this.Text = "FrmNotlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcOkunmayan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOkunmayan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOkunan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOkunan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcOkunmayan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOkunmayan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gcOkunan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOkunan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit ceDurum;
        private DevExpress.XtraEditors.TextEdit txtIcerik;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTarih;
    }
}