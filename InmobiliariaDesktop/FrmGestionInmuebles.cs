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
    public partial class FrmGestionInmuebles : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmGestionInmuebles()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            var inmueblesAListar = from inmueble in db.Inmuebles
                                    select new { Id = inmueble.Id, Nombre = inmueble.Nombre, Propietario = inmueble.Propietario.Nombre, TipoDeInmueble = inmueble.TipoDeInmueble, Direccion = inmueble.Direccion, PrecioAlquilerMes = inmueble.PrecioAlquilerMes, PrecioAlquilerDia = inmueble.PrecioAlquilerDia, Descripcion = inmueble.Descripcion };
            grid.DataSource = inmueblesAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var inmueblesAListar = from inmueble in db.Inmuebles
                                   select new { Id = inmueble.Id, Nombre = inmueble.Nombre, Propietario = inmueble.Propietario.Nombre, TipoDeInmueble = inmueble.TipoDeInmueble, Direccion = inmueble.Direccion, PrecioAlquilerMes = inmueble.PrecioAlquilerMes, PrecioAlquilerDia = inmueble.PrecioAlquilerDia, Descripcion = inmueble.Descripcion };
            grid.DataSource = inmueblesAListar.Where(p => p.Nombre.Contains(textoABuscar)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoInmueble frmNuevoInmueble = new FrmNuevoInmueble();
            frmNuevoInmueble.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevoInmueble frmNuevoInmueble = new FrmNuevoInmueble(db, 0);
            frmNuevoInmueble.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string inmuebleSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar el inmueble: " + inmuebleSeleccionado + "?";
            string titulo = "Eliminación de un inmueble";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Inmueble inmueble = db.Inmuebles.Find(idSeleccionado);
                db.Inmuebles.Remove(inmueble);
                db.SaveChanges();
                //recargamos el listado de categorias
                actualizarGrilla();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }
    }
}
