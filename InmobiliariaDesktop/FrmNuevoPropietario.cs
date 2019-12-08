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
    public partial class FrmNuevoPropietario : Form
    {
        InmobiliariaDesktopContext db;
        Propietario propietario;

        public FrmNuevoPropietario(InmobiliariaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            cargarComboPropietario(0);
            propietario = new Propietario();
        }

        public FrmNuevoPropietario(InmobiliariaDesktopContext dbRecibido, int idSeleccionado)
        {
            InitializeComponent();
            db = dbRecibido;
            propietario = db.Propietarios.Find(idSeleccionado);
            cargarElementoModificable();
            cargarComboPropietario(propietario.LocalidadId);
        }

        private void cargarElementoModificable()
        {
            txtNombre.Text = propietario.Nombre;
            txtDNI.Text = propietario.DNI;
            txtDireccion.Text = propietario.Direccion;
            txtCuentaBancaria.Text = propietario.CuentaBancaria;
            txtTelefono.Text = propietario.Telefono;
        }

        public FrmNuevoPropietario()
        {
            InitializeComponent();
            db = new InmobiliariaDesktopContext();
            cargarComboPropietario(0);
            propietario = new Propietario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            propietario.Nombre = txtNombre.Text;
            propietario.Telefono = txtTelefono.Text;
            propietario.DNI = txtDNI.Text;
            propietario.Direccion = txtDireccion.Text;
            propietario.CuentaBancaria = txtCuentaBancaria.Text;
            propietario.LocalidadId = (int)cboLocalidad.SelectedValue;

            if (propietario.Id > 0)
            {
                db.Entry(propietario).State = EntityState.Modified;
            }
            else
            {
                db.Propietarios.Add(propietario);
            }
            db.SaveChanges();
            this.Close();
        }

        private void cargarComboPropietario(int idLocalidad)
        {
            cboLocalidad.DataSource = db.Localidades.ToList();
            cboLocalidad.DisplayMember = "Nombre";
            cboLocalidad.ValueMember = "Id";
            cboLocalidad.SelectedValue = idLocalidad;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
