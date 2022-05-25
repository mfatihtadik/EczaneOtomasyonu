
namespace Eczane_Otomasyonu
{
    partial class hastaraporForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ECZANEDataSet1 = new Eczane_Otomasyonu.ECZANEDataSet1();
            this.Hasta_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hasta_TableTableAdapter = new Eczane_Otomasyonu.ECZANEDataSet1TableAdapters.Hasta_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ECZANEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hasta_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Hasta_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Eczane_Otomasyonu.hastaRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // ECZANEDataSet1
            // 
            this.ECZANEDataSet1.DataSetName = "ECZANEDataSet1";
            this.ECZANEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Hasta_TableBindingSource
            // 
            this.Hasta_TableBindingSource.DataMember = "Hasta_Table";
            this.Hasta_TableBindingSource.DataSource = this.ECZANEDataSet1;
            // 
            // Hasta_TableTableAdapter
            // 
            this.Hasta_TableTableAdapter.ClearBeforeFill = true;
            // 
            // hastaraporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hastaraporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hastaraporForm";
            this.Load += new System.EventHandler(this.hastaraporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ECZANEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hasta_TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Hasta_TableBindingSource;
        private ECZANEDataSet1 ECZANEDataSet1;
        private ECZANEDataSet1TableAdapters.Hasta_TableTableAdapter Hasta_TableTableAdapter;
    }
}