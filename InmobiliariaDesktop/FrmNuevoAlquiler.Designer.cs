namespace InmobiliariaDesktop
{
    partial class FrmNuevoAlquiler
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
            this.lblInquilino = new System.Windows.Forms.Label();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.cboInquilino = new System.Windows.Forms.ComboBox();
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbDias = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInquilino
            // 
            this.lblInquilino.AutoSize = true;
            this.lblInquilino.Location = new System.Drawing.Point(87, 26);
            this.lblInquilino.Name = "lblInquilino";
            this.lblInquilino.Size = new System.Drawing.Size(68, 17);
            this.lblInquilino.TabIndex = 0;
            this.lblInquilino.Text = "Inquilino: ";
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Location = new System.Drawing.Point(82, 56);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(73, 17);
            this.lblInmueble.TabIndex = 9;
            this.lblInmueble.Text = "Inmueble: ";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(83, 114);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(73, 17);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duración: ";
            // 
            // cboInquilino
            // 
            this.cboInquilino.FormattingEnabled = true;
            this.cboInquilino.Location = new System.Drawing.Point(162, 26);
            this.cboInquilino.Name = "cboInquilino";
            this.cboInquilino.Size = new System.Drawing.Size(199, 24);
            this.cboInquilino.TabIndex = 1;
            // 
            // cboInmueble
            // 
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(162, 56);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(199, 24);
            this.cboInmueble.TabIndex = 2;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(162, 140);
            this.nudPrecio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(199, 22);
            this.nudPrecio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(170, 168);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(162, 114);
            this.nudDuracion.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(199, 22);
            this.nudDuracion.TabIndex = 5;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Checked = true;
            this.rbMes.Location = new System.Drawing.Point(280, 87);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(81, 21);
            this.rbMes.TabIndex = 4;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Por mes";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // rbDias
            // 
            this.rbDias.AutoSize = true;
            this.rbDias.Location = new System.Drawing.Point(170, 87);
            this.rbDias.Name = "rbDias";
            this.rbDias.Size = new System.Drawing.Size(81, 21);
            this.rbDias.TabIndex = 3;
            this.rbDias.TabStop = true;
            this.rbDias.Text = "Por dias";
            this.rbDias.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 206);
            this.Controls.Add(this.rbDias);
            this.Controls.Add(this.rbMes);
            this.Controls.Add(this.nudDuracion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.cboInmueble);
            this.Controls.Add(this.cboInquilino);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblInmueble);
            this.Controls.Add(this.lblInquilino);
            this.Name = "FrmNuevoAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar nuevo alquiler";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInquilino;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ComboBox cboInquilino;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbDias;
    }
}