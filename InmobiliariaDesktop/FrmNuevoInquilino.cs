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
    public partial class FrmNuevoInquilino : Form
    {
        InmobiliariaDesktopContext db;
        Inquilino inquilino;

        public FrmNuevoInquilino(InmobiliariaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            inquilino = new Inquilino();
        }

        public FrmNuevoInquilino(InmobiliariaDesktopContext dbRecibido, int idSeleccionado)
        {
            InitializeComponent();
            db = dbRecibido;
            inquilino = db.Inquilinos.Find(idSeleccionado);
            cargarElementoModificable();
        }

        private void cargarElementoModificable()
        {
            txtNombre.Text = inquilino.Nombre;
            txtDNI.Text= inquilino.DNI;
            if (inquilino.Jubilado==true) { rbJubilado.Checked = true; }
            txtTelefono.Text = inquilino.Telefono;
            txtCorreo.Text = inquilino.Email;
        }

        public FrmNuevoInquilino()
        {
            InitializeComponent();
            db = new InmobiliariaDesktopContext();
            inquilino = new Inquilino();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            inquilino.Nombre = txtNombre.Text;
            inquilino.DNI = txtDNI.Text;
            inquilino.Jubilado = rbJubilado.Checked;
            inquilino.Telefono = txtTelefono.Text;
            inquilino.Email = txtCorreo.Text;

            if (inquilino.Id > 0)
            {
                db.Entry(inquilino).State = EntityState.Modified;
            }
            else
            {
                db.Inquilinos.Add(inquilino);
            }
            db.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
