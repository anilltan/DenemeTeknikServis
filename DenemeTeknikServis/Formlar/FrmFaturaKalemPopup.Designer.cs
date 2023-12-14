
namespace DenemeTeknikServis.Formlar
{
    partial class FrmFaturaKalemPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemPopup));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pePdf = new DevExpress.XtraEditors.PictureEdit();
            this.peExcel = new DevExpress.XtraEditors.PictureEdit();
            this.peClose = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePdf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 175);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 275);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 110);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Fatura Bilgileri";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(800, 89);
            this.gridControl2.TabIndex = 19;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(135, 135);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 19);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "FATURAYA AİT KALEMLER";
            // 
            // pePdf
            // 
            this.pePdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pePdf.EditValue = ((object)(resources.GetObject("pePdf.EditValue")));
            this.pePdf.Location = new System.Drawing.Point(636, 118);
            this.pePdf.Name = "pePdf";
            this.pePdf.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePdf.Properties.Appearance.Options.UseBackColor = true;
            this.pePdf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePdf.Size = new System.Drawing.Size(79, 51);
            this.pePdf.TabIndex = 21;
            this.pePdf.Click += new System.EventHandler(this.pePdf_Click);
            // 
            // peExcel
            // 
            this.peExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peExcel.EditValue = ((object)(resources.GetObject("peExcel.EditValue")));
            this.peExcel.Location = new System.Drawing.Point(551, 118);
            this.peExcel.Name = "peExcel";
            this.peExcel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peExcel.Properties.Appearance.Options.UseBackColor = true;
            this.peExcel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peExcel.Size = new System.Drawing.Size(79, 51);
            this.peExcel.TabIndex = 22;
            this.peExcel.Click += new System.EventHandler(this.peExcel_Click);
            // 
            // peClose
            // 
            this.peClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peClose.EditValue = ((object)(resources.GetObject("peClose.EditValue")));
            this.peClose.Location = new System.Drawing.Point(721, 118);
            this.peClose.Name = "peClose";
            this.peClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peClose.Properties.Appearance.Options.UseBackColor = true;
            this.peClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose.Size = new System.Drawing.Size(79, 51);
            this.peClose.TabIndex = 23;
            this.peClose.Click += new System.EventHandler(this.peClose_Click);
            // 
            // FrmFaturaKalemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.peClose);
            this.Controls.Add(this.peExcel);
            this.Controls.Add(this.pePdf);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaturaKalemPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturaKalemPopup";
            this.Load += new System.EventHandler(this.FrmFaturaKalemPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePdf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pePdf;
        private DevExpress.XtraEditors.PictureEdit peExcel;
        private DevExpress.XtraEditors.PictureEdit peClose;
    }
}