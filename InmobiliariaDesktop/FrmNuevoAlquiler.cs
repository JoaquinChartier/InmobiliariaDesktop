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
    public partial class FrmNuevoAlquiler : Form
    {
        InmobiliariaDesktopContext db;
        Alquileres alquiler;

        public FrmNuevoAlquiler()
        {
            InitializeComponent();
            db = new InmobiliariaDesktopContext();
            cargarComboInquilino(0);
            cargarComboInmueble(0);
            alquiler = new Alquileres();
        }

        public FrmNuevoAlquiler(InmobiliariaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            cargarComboInquilino(0);
            cargarComboInmueble(0);
            alquiler = new Alquileres();
        }

        public FrmNuevoAlquiler(InmobiliariaDesktopContext dbRecibido, int idSeleccionado)
        {
            InitializeComponent();
            db = dbRecibido;
            alquiler = db.Alquileres.Find(idSeleccionado);
            cargarElementoModificable();
            cargarComboInquilino(alquiler.InquilinoId);
            cargarComboInmueble(alquiler.InmuebleId);
        }

        private void cargarElementoModificable()
        {
            dtpDesde.Value = alquiler.Desde;
            dtpHasta.Value = alquiler.Hasta;
            nudPrecio.Value = CalculadorPrecio(alquiler.Desde,alquiler.Hasta,alquiler.Inmueble.PrecioAlquiler);
        }

        private void cargarComboInquilino(int idInquilino)
        {
            cboInquilino.DataSource = db.Inquilinos.ToList();
            cboInquilino.DisplayMember = "Nombre";
            cboInquilino.ValueMember = "Id";
            cboInquilino.SelectedValue = idInquilino;
        }

        private void cargarComboInmueble(int idInmueble)
        {
            cboInmueble.DataSource = db.Inmuebles.ToList();
            cboInmueble.DisplayMember = "Nombre";
            cboInmueble.ValueMember = "Id";
            cboInmueble.SelectedValue = idInmueble;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            alquiler.InquilinoId = (int)cboInquilino.SelectedValue;
            alquiler.InmuebleId = (int)cboInmueble.SelectedValue;
            alquiler.Desde = dtpDesde.Value;
            alquiler.Hasta = dtpHasta.Value;
            alquiler.Precio = CalculadorPrecio(alquiler.Desde,alquiler.Hasta, alquiler.Inmueble.PrecioAlquiler);

            if (alquiler.Id > 0)
            {
                db.Entry(alquiler).State = EntityState.Modified;
            }
            else
            {
                db.Alquileres.Add(alquiler);
            }
            db.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int CalculadorPrecio(DateTime desde,DateTime hasta, int costo) {
            
            TimeSpan cantDias = hasta - desde;
            var precio = cantDias.Days * costo;
            return precio;
        }
    }
}
