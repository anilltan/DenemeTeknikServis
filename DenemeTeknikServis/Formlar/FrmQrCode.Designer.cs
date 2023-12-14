
namespace DenemeTeknikServis.Formlar
{
    partial class FrmQrCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrCode));
            this.btnQrCode = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.btnVazgeç = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQrCode
            // 
            this.btnQrCode.Location = new System.Drawing.Point(85, 70);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Size = new System.Drawing.Size(95, 35);
            this.btnQrCode.TabIndex = 0;
            this.btnQrCode.Text = "QR OLUŞTUR";
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(326, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "SERİ NO İÇİN QR CODE OLUŞTURMA";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(85, 111);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(200, 185);
            this.pictureEdit1.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(85, 46);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Properties.Mask.EditMask = "AAAAA";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textEdit1.Size = new System.Drawing.Size(200, 18);
            this.textEdit1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(23, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "SERİ NO: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(85, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 5;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(344, 2);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(27, 19);
            this.pictureEdit8.TabIndex = 31;
            this.pictureEdit8.Click += new System.EventHandler(this.pictureEdit8_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.Location = new System.Drawing.Point(190, 70);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(95, 35);
            this.btnVazgeç.TabIndex = 32;
            this.btnVazgeç.Text = "VAZGEÇ";
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // FrmQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(370, 312);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnQrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQrCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnQrCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.SimpleButton btnVazgeç;
    }
}