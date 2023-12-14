
namespace DenemeTeknikServis.Formlar
{
    partial class FrmYoutube
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
            this.wbYoutube = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbYoutube
            // 
            this.wbYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbYoutube.Location = new System.Drawing.Point(0, 0);
            this.wbYoutube.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbYoutube.Name = "wbYoutube";
            this.wbYoutube.Size = new System.Drawing.Size(1352, 541);
            this.wbYoutube.TabIndex = 1;
            // 
            // FrmYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 541);
            this.Controls.Add(this.wbYoutube);
            this.Name = "FrmYoutube";
            this.Text = "FrmYoutube";
            this.Load += new System.EventHandler(this.FrmYoutube_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbYoutube;
    }
}