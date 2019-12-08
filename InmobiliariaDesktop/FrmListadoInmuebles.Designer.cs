namespace InmobiliariaDesktop
{
    partial class FrmListadoInmuebles
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
            this.InmuebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerInmuebles = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.InmuebleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InmuebleBindingSource
            // 
            this.InmuebleBindingSource.DataSource = typeof(Datos.Models.Inmueble);
            // 
            // reportViewerInmuebles
            // 
            this.reportViewerInmuebles.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Inmuebles";
            reportDataSource1.Value = this.InmuebleBindingSource;
            this.reportViewerInmuebles.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerInmuebles.LocalReport.ReportEmbeddedResource = "InmobiliariaDesktop.ListadoInmuebles.rdlc";
            this.reportViewerInmuebles.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInmuebles.Name = "reportViewerInmuebles";
            this.reportViewerInmuebles.ServerReport.BearerToken = null;
            this.reportViewerInmuebles.Size = new System.Drawing.Size(800, 450);
            this.reportViewerInmuebles.TabIndex = 0;
            // 
            // FrmListadoInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerInmuebles);
            this.Name = "FrmListadoInmuebles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de inmuebles";
            this.Load += new System.EventHandler(this.FrmListadoInmuebles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InmuebleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInmuebles;
        private System.Windows.Forms.BindingSource InmuebleBindingSource;
    }
}