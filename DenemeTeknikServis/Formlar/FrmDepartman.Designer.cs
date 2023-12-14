
namespace DenemeTeknikServis.Formlar
{
    partial class FrmDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartman));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.labelControl12);
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Location = new System.Drawing.Point(5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 116);
            this.panel1.TabIndex = 11;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(133, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 61);
            this.pictureEdit1.TabIndex = 3;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Location = new System.Drawing.Point(31, 35);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(54, 45);
            this.labelControl12.TabIndex = 2;
            this.labelControl12.Text = "584";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Location = new System.Drawing.Point(12, 12);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(149, 17);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "Toplam Departman Sayısı";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(974, 430);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(133, 35);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(62, 61);
            this.pictureEdit2.TabIndex = 3;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Location = new System.Drawing.Point(31, 35);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(54, 45);
            this.labelControl14.TabIndex = 2;
            this.labelControl14.Text = "584";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl15.Location = new System.Drawing.Point(12, 12);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(134, 17);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Toplam Personel Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.labelControl20);
            this.panel3.Controls.Add(this.pictureEdit3);
            this.panel3.Controls.Add(this.labelControl16);
            this.panel3.Controls.Add(this.labelControl17);
            this.panel3.Location = new System.Drawing.Point(740, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 116);
            this.panel3.TabIndex = 14;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl20.Location = new System.Drawing.Point(22, 12);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(180, 17);
            this.labelControl20.TabIndex = 4;
            this.labelControl20.Text = "En Az Çalışanı Olan Departman";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(133, 35);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(62, 61);
            this.pictureEdit3.TabIndex = 3;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Location = new System.Drawing.Point(31, 35);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(54, 45);
            this.labelControl16.TabIndex = 2;
            this.labelControl16.Text = "584";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl17.Location = new System.Drawing.Point(12, 12);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(4, 17);
            this.labelControl17.TabIndex = 1;
            this.labelControl17.Text = " ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.pictureEdit4);
            this.panel4.Controls.Add(this.labelControl18);
            this.panel4.Controls.Add(this.labelControl19);
            this.panel4.Location = new System.Drawing.Point(495, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 116);
            this.panel4.TabIndex = 13;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(133, 35);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(62, 61);
            this.pictureEdit4.TabIndex = 3;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl18.Location = new System.Drawing.Point(31, 35);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(54, 45);
            this.labelControl18.TabIndex = 2;
            this.labelControl18.Text = "584";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl19.Location = new System.Drawing.Point(12, 12);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(195, 17);
            this.labelControl19.TabIndex = 1;
            this.labelControl19.Text = "En Fazla Çalışanı Olan Departman";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.pictureEdit2);
            this.panel2.Controls.Add(this.labelControl14);
            this.panel2.Controls.Add(this.labelControl15);
            this.panel2.Location = new System.Drawing.Point(250, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 116);
            this.panel2.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(106, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 20);
            this.txtId.TabIndex = 24;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(106, 74);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(222, 20);
            this.txtAd.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "AD: ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "DEPARTMAN ID: ";
            // 
            // btnListele
            // 
            this.btnListele.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ParametersLarge;
            this.btnListele.Location = new System.Drawing.Point(106, 355);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(222, 39);
            this.btnListele.TabIndex = 22;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_CustomizeLarge;
            this.btnGüncelle.Location = new System.Drawing.Point(106, 310);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(222, 39);
            this.btnGüncelle.TabIndex = 21;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreviewLarge;
            this.btnSil.Location = new System.Drawing.Point(106, 265);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 39);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_SaveLarge;
            this.btnKaydet.Location = new System.Drawing.Point(106, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(222, 39);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.rtxtAciklama);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(985, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(380, 552);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "DEPARTMAN İŞLEMLERİ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "AÇIKLAMA: ";
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(106, 100);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(222, 114);
            this.rtxtAciklama.TabIndex = 25;
            this.rtxtAciklama.Text = "";
            // 
            // FrmDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDepartman";
            this.Text = "Departman Listesi";
            this.Load += new System.EventHandler(this.FrmDepartman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
    }
}