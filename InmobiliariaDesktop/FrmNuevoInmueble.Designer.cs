namespace InmobiliariaDesktop
{
    partial class FrmNuevoInmueble
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.nudAlquilerMes = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioMes = new System.Windows.Forms.Label();
            this.cboTipoInmueble = new System.Windows.Forms.ComboBox();
            this.cboPropietario = new System.Windows.Forms.ComboBox();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblTipoInmueble = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudAlquilerDia = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlquilerMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlquilerDia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(202, 202);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(106, 205);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // nudAlquilerMes
            // 
            this.nudAlquilerMes.Location = new System.Drawing.Point(202, 174);
            this.nudAlquilerMes.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAlquilerMes.Name = "nudAlquilerMes";
            this.nudAlquilerMes.Size = new System.Drawing.Size(170, 22);
            this.nudAlquilerMes.TabIndex = 5;
            // 
            // lblPrecioMes
            // 
            this.lblPrecioMes.AutoSize = true;
            this.lblPrecioMes.Location = new System.Drawing.Point(16, 174);
            this.lblPrecioMes.Name = "lblPrecioMes";
            this.lblPrecioMes.Size = new System.Drawing.Size(181, 17);
            this.lblPrecioMes.TabIndex = 12;
            this.lblPrecioMes.Text = "Precio de alquiler por mes: ";
            // 
            // cboTipoInmueble
            // 
            this.cboTipoInmueble.FormattingEnabled = true;
            this.cboTipoInmueble.Location = new System.Drawing.Point(202, 85);
            this.cboTipoInmueble.Name = "cboTipoInmueble";
            this.cboTipoInmueble.Size = new System.Drawing.Size(170, 24);
            this.cboTipoInmueble.TabIndex = 2;
            // 
            // cboPropietario
            // 
            this.cboPropietario.FormattingEnabled = true;
            this.cboPropietario.Location = new System.Drawing.Point(202, 55);
            this.cboPropietario.Name = "cboPropietario";
            this.cboPropietario.Size = new System.Drawing.Size(170, 24);
            this.cboPropietario.TabIndex = 1;
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(111, 58);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(85, 17);
            this.lblPropietario.TabIndex = 9;
            this.lblPropietario.Text = "Propietario: ";
            // 
            // lblTipoInmueble
            // 
            this.lblTipoInmueble.AutoSize = true;
            this.lblTipoInmueble.Location = new System.Drawing.Point(71, 88);
            this.lblTipoInmueble.Name = "lblTipoInmueble";
            this.lblTipoInmueble.Size = new System.Drawing.Size(125, 17);
            this.lblTipoInmueble.TabIndex = 10;
            this.lblTipoInmueble.Text = "Tipo de inmueble: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(202, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 22);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(121, 118);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 17);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(130, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // nudAlquilerDia
            // 
            this.nudAlquilerDia.Location = new System.Drawing.Point(203, 146);
            this.nudAlquilerDia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudAlquilerDia.Name = "nudAlquilerDia";
            this.nudAlquilerDia.Size = new System.Drawing.Size(170, 22);
            this.nudAlquilerDia.TabIndex = 4;
            // 
            // lblPrecioDia
            // 
            this.lblPrecioDia.AutoSize = true;
            this.lblPrecioDia.Location = new System.Drawing.Point(23, 146);
            this.lblPrecioDia.Name = "lblPrecioDia";
            this.lblPrecioDia.Size = new System.Drawing.Size(174, 17);
            this.lblPrecioDia.TabIndex = 15;
            this.lblPrecioDia.Text = "Precio de alquiler por dia: ";
            // 
            // FrmNuevoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 288);
            this.Controls.Add(this.lblPrecioDia);
            this.Controls.Add(this.nudAlquilerDia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.nudAlquilerMes);
            this.Controls.Add(this.lblPrecioMes);
            this.Controls.Add(this.cboTipoInmueble);
            this.Controls.Add(this.cboPropietario);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblTipoInmueble);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmNuevoInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo inmueble";
            ((System.ComponentModel.ISupportInitialize)(this.nudAlquilerMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlquilerDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown nudAlquilerMes;
        private System.Windows.Forms.Label lblPrecioMes;
        private System.Windows.Forms.ComboBox cboTipoInmueble;
        private System.Windows.Forms.ComboBox cboPropietario;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblTipoInmueble;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudAlquilerDia;
        private System.Windows.Forms.Label lblPrecioDia;
    }
}