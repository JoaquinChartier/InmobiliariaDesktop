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
        Alquiler alquiler;

        public FrmNuevoAlquiler()
        {
            InitializeComponent();
            db = new InmobiliariaDesktopContext();
            cargarComboInquilino(0);
            cargarComboInmueble(0);
            alquiler = new Alquiler();
        }

        public FrmNuevoAlquiler(InmobiliariaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            cargarComboInquilino(0);
            cargarComboInmueble(0);
            alquiler = new Alquiler();
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
            if (alquiler.PorMesBool == true)
            {
                rbDias.Checked = false;
                rbMes.Checked = true;
                nudDuracion.Value = alquiler.Duracion;
            }
            else
            {
                rbDias.Checked = true;
                rbMes.Checked = false;
                nudDuracion.Value = alquiler.Duracion;
            }
            
            nudPrecio.Value = CalculadorPrecio(alquiler.PorMesBool,alquiler.Duracion,alquiler.Inmueble.PrecioAlquilerDia, alquiler.Inmueble.PrecioAlquilerMes);
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
            alquiler.Duracion = (int)nudDuracion.Value;

            if (rbMes.Checked == true)
            {
                alquiler.PorMesBool = true;
            }
            else
            {
                alquiler.PorMesBool = false;
            }

            Inmueble inmueble = db.Inmuebles.Find((int)cboInmueble.SelectedValue);
            alquiler.Precio = CalculadorPrecio(alquiler.PorMesBool,alquiler.Duracion, inmueble.PrecioAlquilerDia, inmueble.PrecioAlquilerMes);

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

        private int CalculadorPrecio(bool rbElegido,int duracion, int costoDia, int costoMes) {
            int precio;
            if (rbElegido == true)
            {
                precio = costoMes * duracion;
                return precio;
            }
            else
            {
                precio = costoDia * duracion;
                return precio;
            }
            
        }
    }
}
