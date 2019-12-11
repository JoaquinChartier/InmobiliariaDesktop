using Datos;
using Datos.Models;
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
    public partial class FrmGestionAlquileres : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmGestionAlquileres()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            var alquileresAListar = from alquiler in db.Alquileres
                                    select new { Id = alquiler.Id, Duracion = alquiler.Duracion, PorMes = alquiler.PorMesBool, Inquilino= alquiler.Inquilino.Nombre, Inmueble = alquiler.Inmueble.Nombre, Precio = alquiler.Precio};
            grid.DataSource = alquileresAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var alquileresAListar = from alquiler in db.Alquileres
                                    select new { Id = alquiler.Id, Duracion = alquiler.Duracion, PorMes = alquiler.PorMesBool, Inquilino = alquiler.Inquilino.Nombre, Inmueble = alquiler.Inmueble.Nombre, Precio = alquiler.Precio };
            grid.DataSource = alquileresAListar.Where(p => p.Inquilino.Contains(textoABuscar)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoAlquiler frmNuevoAlquiler = new FrmNuevoAlquiler(db);
            frmNuevoAlquiler.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string inquilinoSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar el alquiler: " + inquilinoSeleccionado + "?";
            string titulo = "Eliminación de un alquiler";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Alquiler alquiler = db.Alquileres.Find(idSeleccionado);
                db.Alquileres.Remove(alquiler);
                db.SaveChanges();
                //recargamos el listado de categorias
                actualizarGrilla();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevoAlquiler frmNuevoAlquiler = new FrmNuevoAlquiler(db, idSeleccionado);
            frmNuevoAlquiler.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmComprobante frmComprobante = new FrmComprobante(idSeleccionado);
            frmComprobante.ShowDialog();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedRows != null) { btnComprobante.Enabled = true; }
        }
    }
}
