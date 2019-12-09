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
    public partial class FrmGestionPropietarios : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmGestionPropietarios()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            var propietariosAListar = from propietario in db.Propietarios
                                    select new { Id = propietario.Id, NombreApellido = propietario.Nombre, DNI = propietario.DNI, Direccion = propietario.Direccion, Telefono = propietario.Telefono, CBU = propietario.CuentaBancaria, Localidad = propietario.Localidad.Nombre };
            grid.DataSource = propietariosAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var propietariosAListar = from propietario in db.Propietarios
                                      select new { Id = propietario.Id, NombreApellido = propietario.Nombre, DNI = propietario.DNI, Direccion = propietario.Direccion, Telefono = propietario.Telefono, CBU = propietario.CuentaBancaria, Localidad = propietario.Localidad.Nombre };
            grid.DataSource = propietariosAListar.Where(p => p.NombreApellido.Contains(textoABuscar)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoPropietario frmNuevoPropietario = new FrmNuevoPropietario();
            frmNuevoPropietario.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string propietarioSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar el propietario: " + propietarioSeleccionado + "?";
            string titulo = "Eliminación de un propietario";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Propietario propietario = db.Propietarios.Find(idSeleccionado);
                db.Propietarios.Remove(propietario);
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
            FrmNuevoPropietario frmNuevoPropietario = new FrmNuevoPropietario(db, idSeleccionado);
            frmNuevoPropietario.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }
    }

}
