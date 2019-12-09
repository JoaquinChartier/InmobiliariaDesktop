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
    public partial class FrmGestionInquilinos : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmGestionInquilinos()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            var inquilinosAListar = from inquilino in db.Inquilinos
                                    select new { Id = inquilino.Id, NombreApellido = inquilino.Nombre, DNI = inquilino.DNI, Jubilado = inquilino.Jubilado, Telefono = inquilino.Telefono, Email = inquilino.Email };
            grid.DataSource = inquilinosAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var inquilinosAListar = from inquilino in db.Inquilinos
                                    select new { Id = inquilino.Id, NombreApellido = inquilino.Nombre, DNI = inquilino.DNI, Jubilado = inquilino.Jubilado, Telefono = inquilino.Telefono, Email = inquilino.Email };
            grid.DataSource = inquilinosAListar.Where(p => p.NombreApellido.Contains(textoABuscar)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoInquilino frmNuevoInquilino = new FrmNuevoInquilino(db);
            frmNuevoInquilino.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string inquilinoSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar el inquilino: " + inquilinoSeleccionado + "?";
            string titulo = "Eliminación de un inquilino";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Inquilino inquilino = db.Inquilinos.Find(idSeleccionado);
                db.Inquilinos.Remove(inquilino);
                db.SaveChanges();
                //recargamos el listado de categorias
                actualizarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevoInquilino frmNuevoInquilino = new FrmNuevoInquilino(db,idSeleccionado);
            frmNuevoInquilino.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }
    }
}
