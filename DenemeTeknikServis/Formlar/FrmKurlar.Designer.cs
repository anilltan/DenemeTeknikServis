
namespace DenemeTeknikServis.Formlar
{
    partial class FrmKurlar
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
            this.wbKurlar = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbKurlar
            // 
            this.wbKurlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbKurlar.Location = new System.Drawing.Point(0, 0);
            this.wbKurlar.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbKurlar.Name = "wbKurlar";
            this.wbKurlar.Size = new System.Drawing.Size(1370, 541);
            this.wbKurlar.TabIndex = 0;
            // 
            // FrmKurlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.wbKurlar);
            this.Name = "FrmKurlar";
            this.Text = "FrmKurlar";
            this.Load += new System.EventHandler(this.FrmKurlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbKurlar;
    }
}