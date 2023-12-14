
namespace DenemeTeknikServis.Formlar
{
    partial class FrmDepartmanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmanEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(76, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 31;
            // 
            // txtAd
            // 
            this.txtAd.EditValue = "Departman Adı";
            this.txtAd.Location = new System.Drawing.Point(76, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Properties.Appearance.Options.UseForeColor = true;
            this.txtAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAd.Size = new System.Drawing.Size(143, 26);
            this.txtAd.TabIndex = 30;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ExportFileLarge;
            this.btnKaydet.Location = new System.Drawing.Point(96, 105);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 35);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ZoomLarge;
            this.pictureEdit1.Location = new System.Drawing.Point(29, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(41, 32);
            this.pictureEdit1.TabIndex = 29;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(288, 1);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(30, 28);
            this.pictureEdit8.TabIndex = 33;
            this.pictureEdit8.Click += new System.EventHandler(this.pictureEdit8_Click);
            // 
            // FrmDepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(320, 168);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartmanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDepartmanEkle";
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
    }
}