namespace InmobiliariaDesktop
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoInquilinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarInquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inmueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInmueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarInmueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoPropietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevaLocalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inquilinosToolStripMenuItem,
            this.inmueblesToolStripMenuItem,
            this.propietariosToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoInquilinoToolStripMenuItem,
            this.listadoDeInquilinosToolStripMenuItem,
            this.gestionarInquilinosToolStripMenuItem});
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            // 
            // ingresarNuevoInquilinoToolStripMenuItem
            // 
            this.ingresarNuevoInquilinoToolStripMenuItem.Name = "ingresarNuevoInquilinoToolStripMenuItem";
            this.ingresarNuevoInquilinoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.ingresarNuevoInquilinoToolStripMenuItem.Text = "Ingresar nuevo inquilino";
            this.ingresarNuevoInquilinoToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoInquilinoToolStripMenuItem_Click);
            // 
            // listadoDeInquilinosToolStripMenuItem
            // 
            this.listadoDeInquilinosToolStripMenuItem.Name = "listadoDeInquilinosToolStripMenuItem";
            this.listadoDeInquilinosToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.listadoDeInquilinosToolStripMenuItem.Text = "Listado de inquilinos";
            // 
            // gestionarInquilinosToolStripMenuItem
            // 
            this.gestionarInquilinosToolStripMenuItem.Name = "gestionarInquilinosToolStripMenuItem";
            this.gestionarInquilinosToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gestionarInquilinosToolStripMenuItem.Text = "Gestionar inquilinos";
            this.gestionarInquilinosToolStripMenuItem.Click += new System.EventHandler(this.gestionarInquilinosToolStripMenuItem_Click);
            // 
            // inmueblesToolStripMenuItem
            // 
            this.inmueblesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoInmuebleToolStripMenuItem,
            this.listadoDeInmueblesToolStripMenuItem,
            this.gestionarInmueblesToolStripMenuItem});
            this.inmueblesToolStripMenuItem.Name = "inmueblesToolStripMenuItem";
            this.inmueblesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inmueblesToolStripMenuItem.Text = "Inmuebles";
            // 
            // ingresarNuevoInmuebleToolStripMenuItem
            // 
            this.ingresarNuevoInmuebleToolStripMenuItem.Name = "ingresarNuevoInmuebleToolStripMenuItem";
            this.ingresarNuevoInmuebleToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ingresarNuevoInmuebleToolStripMenuItem.Text = "Ingresar nuevo inmueble";
            // 
            // listadoDeInmueblesToolStripMenuItem
            // 
            this.listadoDeInmueblesToolStripMenuItem.Name = "listadoDeInmueblesToolStripMenuItem";
            this.listadoDeInmueblesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.listadoDeInmueblesToolStripMenuItem.Text = "Listado de inmuebles";
            // 
            // gestionarInmueblesToolStripMenuItem
            // 
            this.gestionarInmueblesToolStripMenuItem.Name = "gestionarInmueblesToolStripMenuItem";
            this.gestionarInmueblesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.gestionarInmueblesToolStripMenuItem.Text = "Gestionar inmuebles";
            // 
            // propietariosToolStripMenuItem
            // 
            this.propietariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoPropietarioToolStripMenuItem,
            this.listadoDePropietariosToolStripMenuItem,
            this.gestionarPropietariosToolStripMenuItem});
            this.propietariosToolStripMenuItem.Name = "propietariosToolStripMenuItem";
            this.propietariosToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.propietariosToolStripMenuItem.Text = "Propietarios";
            // 
            // ingresarNuevoPropietarioToolStripMenuItem
            // 
            this.ingresarNuevoPropietarioToolStripMenuItem.Name = "ingresarNuevoPropietarioToolStripMenuItem";
            this.ingresarNuevoPropietarioToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.ingresarNuevoPropietarioToolStripMenuItem.Text = "Ingresar nuevo propietario";
            // 
            // listadoDePropietariosToolStripMenuItem
            // 
            this.listadoDePropietariosToolStripMenuItem.Name = "listadoDePropietariosToolStripMenuItem";
            this.listadoDePropietariosToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.listadoDePropietariosToolStripMenuItem.Text = "Listado de propietarios";
            // 
            // gestionarPropietariosToolStripMenuItem
            // 
            this.gestionarPropietariosToolStripMenuItem.Name = "gestionarPropietariosToolStripMenuItem";
            this.gestionarPropietariosToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.gestionarPropietariosToolStripMenuItem.Text = "Gestionar propietarios";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevaLocalidadToolStripMenuItem,
            this.listadoDeLocalidadesToolStripMenuItem,
            this.gestionarLocalidadesToolStripMenuItem});
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            // 
            // ingresarNuevaLocalidadToolStripMenuItem
            // 
            this.ingresarNuevaLocalidadToolStripMenuItem.Name = "ingresarNuevaLocalidadToolStripMenuItem";
            this.ingresarNuevaLocalidadToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.ingresarNuevaLocalidadToolStripMenuItem.Text = "Ingresar nueva localidad";
            // 
            // listadoDeLocalidadesToolStripMenuItem
            // 
            this.listadoDeLocalidadesToolStripMenuItem.Name = "listadoDeLocalidadesToolStripMenuItem";
            this.listadoDeLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.listadoDeLocalidadesToolStripMenuItem.Text = "Listado de localidades";
            // 
            // gestionarLocalidadesToolStripMenuItem
            // 
            this.gestionarLocalidadesToolStripMenuItem.Name = "gestionarLocalidadesToolStripMenuItem";
            this.gestionarLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.gestionarLocalidadesToolStripMenuItem.Text = "Gestionar localidades";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Inmobiliaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inmueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarInquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInmueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarInmueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLocalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarLocalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoInquilinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoInmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoPropietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevaLocalidadToolStripMenuItem;
    }
}

