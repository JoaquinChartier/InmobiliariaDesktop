namespace InmobiliariaDesktop
{
    partial class FrmNuevoInquilino
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rbJubilado = new System.Windows.Forms.RadioButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(99, 186);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(108, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(180, 143);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(170, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(48, 143);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(132, 17);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo electrónico: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(108, 115);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 17);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(135, 61);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(39, 17);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(180, 112);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // rbJubilado
            // 
            this.rbJubilado.AutoSize = true;
            this.rbJubilado.Location = new System.Drawing.Point(180, 85);
            this.rbJubilado.Name = "rbJubilado";
            this.rbJubilado.Size = new System.Drawing.Size(98, 21);
            this.rbJubilado.TabIndex = 10;
            this.rbJubilado.TabStop = true;
            this.rbJubilado.Text = "Es jubilado";
            this.rbJubilado.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(180, 58);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(170, 22);
            this.txtDNI.TabIndex = 9;
            // 
            // FrmNuevoInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 230);
            this.Controls.Add(this.rbJubilado);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmNuevoInquilino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo inquilino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton rbJubilado;
        private System.Windows.Forms.TextBox txtDNI;
    }
}