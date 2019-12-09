using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaDesktop
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarInquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionInquilinos frmGestionInquilinos = new FrmGestionInquilinos();
            frmGestionInquilinos.ShowDialog();
        }

        private void ingresarNuevoInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoInquilino frmNuevoInquilino = new FrmNuevoInquilino();
            frmNuevoInquilino.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarNuevoInmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoInmueble frmNuevoInmueble = new FrmNuevoInmueble();
            frmNuevoInmueble.ShowDialog();
        }

        private void gestionarInmueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionInmuebles frmGestionInmuebles = new FrmGestionInmuebles();
            frmGestionInmuebles.ShowDialog();
        }

        private void ingresarNuevoPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPropietario frmNuevoPropietario = new FrmNuevoPropietario();
            frmNuevoPropietario.ShowDialog();
        }

        private void gestionarPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionPropietarios frmGestionPropietarios = new FrmGestionPropietarios();
            frmGestionPropietarios.ShowDialog();
        }

        private void ingresarNuevaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaLocalidad frmNuevaLocalidad = new FrmNuevaLocalidad();
            frmNuevaLocalidad.ShowDialog();
        }

        private void gestionarLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionLocalidades frmGestionLocalidades = new FrmGestionLocalidades();
            frmGestionLocalidades.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoAlquiler frmNuevoAlquiler = new FrmNuevoAlquiler();
            frmNuevoAlquiler.ShowDialog();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionAlquileres frmGestionAlquileres = new FrmGestionAlquileres();
            frmGestionAlquileres.ShowDialog();
        }

        private void listadoDeInmueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoInmuebles frmListadoInmuebles = new FrmListadoInmuebles();
            frmListadoInmuebles.ShowDialog();
        }

        private void listadoDeInquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoInquilinos frmListadoInquilinos = new FrmListadoInquilinos();
            frmListadoInquilinos.ShowDialog();
        }

        private void listadoDePropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPropietarios frmListadoPropietarios = new FrmListadoPropietarios();
            frmListadoPropietarios.ShowDialog();
        }
    }

}
