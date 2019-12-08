namespace InmobiliariaDesktop
{
    partial class FrmListadoInquilinos
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
            this.reportViewerInquilinos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InquilinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InquilinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerInquilinos
            // 
            this.reportViewerInquilinos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InquilinoBindingSource;
            this.reportViewerInquilinos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerInquilinos.LocalReport.ReportEmbeddedResource = "InmobiliariaDesktop.ListadoInquilinos.rdlc";
            this.reportViewerInquilinos.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInquilinos.Name = "reportViewerInquilinos";
            this.reportViewerInquilinos.ServerReport.BearerToken = null;
            this.reportViewerInquilinos.Size = new System.Drawing.Size(800, 450);
            this.reportViewerInquilinos.TabIndex = 0;
            // 
            // InquilinoBindingSource
            // 
            this.InquilinoBindingSource.DataSource = typeof(Datos.Models.Inquilino);
            // 
            // FrmListadoInquilinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerInquilinos);
            this.Name = "FrmListadoInquilinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de inquilinos";
            this.Load += new System.EventHandler(this.FrmListadoInquilinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InquilinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInquilinos;
        private System.Windows.Forms.BindingSource InquilinoBindingSource;
    }
}