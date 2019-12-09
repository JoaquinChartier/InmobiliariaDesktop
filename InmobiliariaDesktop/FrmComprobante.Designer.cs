namespace InmobiliariaDesktop
{
    partial class FrmComprobante
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
            this.reportViewerComprobante = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AlquileresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerComprobante
            // 
            this.reportViewerComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Alquileres";
            reportDataSource1.Value = this.AlquileresBindingSource;
            this.reportViewerComprobante.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerComprobante.LocalReport.ReportEmbeddedResource = "InmobiliariaDesktop.ComprobanteDePago.rdlc";
            this.reportViewerComprobante.Location = new System.Drawing.Point(0, 0);
            this.reportViewerComprobante.Name = "reportViewerComprobante";
            this.reportViewerComprobante.ServerReport.BearerToken = null;
            this.reportViewerComprobante.Size = new System.Drawing.Size(800, 450);
            this.reportViewerComprobante.TabIndex = 0;
            // 
            // AlquileresBindingSource
            // 
            this.AlquileresBindingSource.DataSource = typeof(Datos.Models.Alquileres);
            // 
            // FrmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerComprobante);
            this.Name = "FrmComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir comprobante";
            this.Load += new System.EventHandler(this.FrmComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlquileresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerComprobante;
        private System.Windows.Forms.BindingSource AlquileresBindingSource;
    }
}