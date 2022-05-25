
namespace Eczane_Otomasyonu
{
    partial class kullaniciraporForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Kullanicigiris_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ECZANEDataSet1 = new Eczane_Otomasyonu.ECZANEDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Kullanicigiris_tabTableAdapter = new Eczane_Otomasyonu.ECZANEDataSet1TableAdapters.Kullanicigiris_tabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanicigiris_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECZANEDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kullanicigiris_tabBindingSource
            // 
            this.Kullanicigiris_tabBindingSource.DataMember = "Kullanicigiris_tab";
            this.Kullanicigiris_tabBindingSource.DataSource = this.ECZANEDataSet1;
            // 
            // ECZANEDataSet1
            // 
            this.ECZANEDataSet1.DataSetName = "ECZANEDataSet1";
            this.ECZANEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Kullanicigiris_tabBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Eczane_Otomasyonu.kullanicirapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Kullanicigiris_tabTableAdapter
            // 
            this.Kullanicigiris_tabTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciraporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "kullaniciraporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciraporForm";
            this.Load += new System.EventHandler(this.kullaniciraporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kullanicigiris_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECZANEDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Kullanicigiris_tabBindingSource;
        private ECZANEDataSet1 ECZANEDataSet1;
        private ECZANEDataSet1TableAdapters.Kullanicigiris_tabTableAdapter Kullanicigiris_tabTableAdapter;
    }
}