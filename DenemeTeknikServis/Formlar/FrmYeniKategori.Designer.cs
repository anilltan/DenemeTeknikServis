
namespace DenemeTeknikServis.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(76, 97);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 45);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "KATEGORİ EKLE";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(76, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 25;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.EditValue = "Kategori Adı";
            this.txtKategoriAd.Location = new System.Drawing.Point(76, 45);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtKategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtKategoriAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtKategoriAd.Properties.Appearance.Options.UseFont = true;
            this.txtKategoriAd.Properties.Appearance.Options.UseForeColor = true;
            this.txtKategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtKategoriAd.Size = new System.Drawing.Size(143, 26);
            this.txtKategoriAd.TabIndex = 24;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ZoomLarge;
            this.pictureEdit1.Location = new System.Drawing.Point(29, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(41, 32);
            this.pictureEdit1.TabIndex = 23;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(285, -1);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(34, 34);
            this.pictureEdit2.TabIndex = 29;
            this.pictureEdit2.Click += new System.EventHandler(this.pictureEdit2_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(320, 168);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtKategoriAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}