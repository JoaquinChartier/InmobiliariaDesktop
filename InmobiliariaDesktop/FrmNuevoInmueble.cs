using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaDesktop
{
    public partial class FrmNuevoInmueble : Form
    {
        InmobiliariaDesktopContext db;
        Inmueble inmueble;

        public FrmNuevoInmueble(InmobiliariaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            cargarComboPropietario(0);
            cargarComboTipoInmueble(0);
            inmueble = new Inmueble();
        }

        public FrmNuevoInmueble(InmobiliariaDesktopContext dbRecibido, int idSeleccionado)
        {
            InitializeComponent();
            db = dbRecibido;
            inmueble = db.Inmuebles.Find(idSeleccionado);
            cargarElementoModificable();
            cargarComboPropietario(inmueble.PropietarioId);
            cargarComboTipoInmueble(0);
        }

        private void cargarElementoModificable()
        {
            txtNombre.Text = inmueble.Nombre;
            txtDireccion.Text = inmueble.Direccion;
            txtDescripcion.Text = inmueble.Descripcion;
            nudAlquilerMes.Value = inmueble.PrecioAlquilerMes;
            nudAlquilerDia.Value = inmueble.PrecioAlquilerDia;
        }

        public FrmNuevoInmueble()
        {
            InitializeComponent();
            db = new InmobiliariaDesktopContext();
            cargarComboPropietario(0);
            cargarComboTipoInmueble(0);
            inmueble = new Inmueble();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarComboPropietario(int idPropietario)
        {
            cboPropietario.DataSource = db.Propietarios.ToList();
            cboPropietario.DisplayMember = "Nombre";
            cboPropietario.ValueMember = "Id";
            cboPropietario.SelectedValue = idPropietario;
        }

        private void cargarComboTipoInmueble(int selectedValue)
        {
            cboTipoInmueble.DataSource = Enum.GetValues(typeof(TipoInmuebleEnum));
            cboTipoInmueble.SelectedIndex = selectedValue;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            inmueble.Nombre = txtNombre.Text;
            inmueble.PropietarioId = (int)cboPropietario.SelectedValue;
            inmueble.PrecioAlquilerMes = (int)nudAlquilerMes.Value;
            inmueble.PrecioAlquilerDia = (int)nudAlquilerDia.Value;
            inmueble.TipoDeInmueble= (TipoInmuebleEnum)cboTipoInmueble.SelectedIndex + 1;
            inmueble.Descripcion = txtDescripcion.Text;
            inmueble.Direccion = txtDireccion.Text;
            
            if (inmueble.Id > 0)
            {
                db.Entry(inmueble).State = EntityState.Modified;
            }
            else
            {
                db.Inmuebles.Add(inmueble);
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
