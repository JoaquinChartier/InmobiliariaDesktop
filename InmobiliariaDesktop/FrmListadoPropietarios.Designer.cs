namespace InmobiliariaDesktop
{
    partial class FrmListadoPropietarios
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
            this.reportViewerPropietarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PropietarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PropietarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerPropietarios
            // 
            this.reportViewerPropietarios.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Propietarios";
            reportDataSource1.Value = this.PropietarioBindingSource;
            this.reportViewerPropietarios.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPropietarios.LocalReport.ReportEmbeddedResource = "InmobiliariaDesktop.ListadoPropietarios.rdlc";
            this.reportViewerPropietarios.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPropietarios.Name = "reportViewerPropietarios";
            this.reportViewerPropietarios.ServerReport.BearerToken = null;
            this.reportViewerPropietarios.Size = new System.Drawing.Size(800, 450);
            this.reportViewerPropietarios.TabIndex = 0;
            // 
            // PropietarioBindingSource
            // 
            this.PropietarioBindingSource.DataSource = typeof(Datos.Models.Propietario);
            // 
            // FrmListadoPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerPropietarios);
            this.Name = "FrmListadoPropietarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de propietarios";
            this.Load += new System.EventHandler(this.FrmListadoPropietarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PropietarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPropietarios;
        private System.Windows.Forms.BindingSource PropietarioBindingSource;
    }
}