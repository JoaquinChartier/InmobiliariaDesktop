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
    public partial class FrmGestionLocalidades : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmGestionLocalidades()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            var localidadesAListar = from localidad in db.Localidades
                                    select new { Id = localidad.Id, Nombre = localidad.Nombre};
            grid.DataSource = localidadesAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var localidadesAListar = from localidad in db.Localidades
                                     select new { Id = localidad.Id, Nombre = localidad.Nombre };
            grid.DataSource = localidadesAListar.Where(p => p.Nombre.Contains(textoABuscar)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaLocalidad frmNuevaLocalidad = new FrmNuevaLocalidad(db);
            frmNuevaLocalidad.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevaLocalidad frmNuevaLocalidad = new FrmNuevaLocalidad(db, idSeleccionado);
            frmNuevaLocalidad.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string localidadSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar la localidad: " + localidadSeleccionado + "?";
            string titulo = "Eliminación de una localidad";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Localidad localidad = db.Localidades.Find(idSeleccionado);
                db.Localidades.Remove(localidad);
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
