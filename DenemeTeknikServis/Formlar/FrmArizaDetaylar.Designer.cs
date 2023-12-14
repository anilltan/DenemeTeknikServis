
namespace DenemeTeknikServis.Formlar
{
    partial class FrmArizaDetaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetaylar));
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVazgeç = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(12, 362);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 38);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(296, 25);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "ARIZALI ÜRÜN KAYDI AÇIKLAMA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "ARIZA DETAYLARI";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(323, -4);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(30, 28);
            this.pictureEdit8.TabIndex = 31;
            this.pictureEdit8.Click += new System.EventHandler(this.pictureEdit8_Click);
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.EditValue = "Seri No";
            this.txtSeriNo.Location = new System.Drawing.Point(13, 68);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.txtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSeriNo.Properties.Mask.EditMask = "d";
            this.txtSeriNo.Size = new System.Drawing.Size(143, 26);
            this.txtSeriNo.TabIndex = 0;
            this.txtSeriNo.Click += new System.EventHandler(this.txtSeriNo_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = "Tarih";
            this.txtTarih.Location = new System.Drawing.Point(12, 126);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.txtTarih.Properties.Appearance.Options.UseFont = true;
            this.txtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.txtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTarih.Properties.Mask.EditMask = "d";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtTarih.Size = new System.Drawing.Size(143, 26);
            this.txtTarih.TabIndex = 1;
            this.txtTarih.Click += new System.EventHandler(this.txtTarih_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(13, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 3);
            this.panel4.TabIndex = 143;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 144;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(12, 207);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 3);
            this.panel7.TabIndex = 155;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi"});
            this.comboBox1.Location = new System.Drawing.Point(12, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.Image = global::DenemeTeknikServis.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreviewLarge;
            this.btnVazgeç.Location = new System.Drawing.Point(177, 362);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(143, 38);
            this.btnVazgeç.TabIndex = 5;
            this.btnVazgeç.Text = "VAZGEÇ";
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // FrmArizaDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(349, 412);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetaylar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arızalu Ürün Kaydı Açıklama";
            this.Load += new System.EventHandler(this.FrmArizaDetaylar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton btnVazgeç;
    }
}