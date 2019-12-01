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
            this.nudPrecioAlquiler = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioAlquiler = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(202, 174);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 22);
            this.txtDescripcion.TabIndex = 30;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(106, 177);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblDescripcion.TabIndex = 29;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // nudPrecioAlquiler
            // 
            this.nudPrecioAlquiler.Location = new System.Drawing.Point(202, 146);
            this.nudPrecioAlquiler.Name = "nudPrecioAlquiler";
            this.nudPrecioAlquiler.Size = new System.Drawing.Size(170, 22);
            this.nudPrecioAlquiler.TabIndex = 28;
            // 
            // lblPrecioAlquiler
            // 
            this.lblPrecioAlquiler.AutoSize = true;
            this.lblPrecioAlquiler.Location = new System.Drawing.Point(71, 148);
            this.lblPrecioAlquiler.Name = "lblPrecioAlquiler";
            this.lblPrecioAlquiler.Size = new System.Drawing.Size(126, 17);
            this.lblPrecioAlquiler.TabIndex = 27;
            this.lblPrecioAlquiler.Text = "Precio de alquiler: ";
            // 
            // cboTipoInmueble
            // 
            this.cboTipoInmueble.FormattingEnabled = true;
            this.cboTipoInmueble.Location = new System.Drawing.Point(202, 85);
            this.cboTipoInmueble.Name = "cboTipoInmueble";
            this.cboTipoInmueble.Size = new System.Drawing.Size(170, 24);
            this.cboTipoInmueble.TabIndex = 26;
            // 
            // cboPropietario
            // 
            this.cboPropietario.FormattingEnabled = true;
            this.cboPropietario.Location = new System.Drawing.Point(202, 55);
            this.cboPropietario.Name = "cboPropietario";
            this.cboPropietario.Size = new System.Drawing.Size(170, 24);
            this.cboPropietario.TabIndex = 25;
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(111, 58);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(85, 17);
            this.lblPropietario.TabIndex = 24;
            this.lblPropietario.Text = "Propietario: ";
            // 
            // lblTipoInmueble
            // 
            this.lblTipoInmueble.AutoSize = true;
            this.lblTipoInmueble.Location = new System.Drawing.Point(71, 88);
            this.lblTipoInmueble.Name = "lblTipoInmueble";
            this.lblTipoInmueble.Size = new System.Drawing.Size(125, 17);
            this.lblTipoInmueble.TabIndex = 23;
            this.lblTipoInmueble.Text = "Tipo de inmueble: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(202, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 22);
            this.txtDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(121, 118);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 17);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 22);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(130, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 271);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.nudPrecioAlquiler);
            this.Controls.Add(this.lblPrecioAlquiler);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown nudPrecioAlquiler;
        private System.Windows.Forms.Label lblPrecioAlquiler;
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
    }
}