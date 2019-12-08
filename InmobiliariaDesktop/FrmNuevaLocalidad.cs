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
    public partial class FrmNuevaLocalidad : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();
        Localidad localidad;

        public FrmNuevaLocalidad(InmobiliariaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            localidad = new Localidad();
        }

        public FrmNuevaLocalidad(InmobiliariaDesktopContext dbRecibido, int idSeleccionado)
        {
            InitializeComponent();
            db = dbRecibido;
            localidad = db.Localidades.Find(idSeleccionado);
            cargarElementoModificable();
        }

        public FrmNuevaLocalidad()
        {
            InitializeComponent();
            db = new InmobiliariaDesktopContext();
            localidad = new Localidad();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            localidad.Nombre = txtNombre.Text;

            if (localidad.Id > 0)
            {
                db.Entry(localidad).State = EntityState.Modified;
            }
            else
            {
                db.Localidades.Add(localidad);
            }
            db.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarElementoModificable()
        {
            txtNombre.Text = localidad.Nombre;
        }
    }
}
