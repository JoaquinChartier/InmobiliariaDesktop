using Datos;
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
    public partial class FrmComprobante : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();
        int seleccion;

        public FrmComprobante(int idSeleccionado)
        {
            InitializeComponent();
            seleccion = idSeleccionado;

        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
            var Alquiler = from alquiler in db.Alquileres
                           where alquiler.Id == this.seleccion
                           select new { Id = alquiler.Id,
                                        Inquilino = alquiler.Inquilino.Nombre,
                                        Precio = alquiler.Precio,
                                        Inmueble = alquiler.Inmueble.Nombre };


            this.AlquileresBindingSource.DataSource = Alquiler.ToList();
            this.reportViewerComprobante.RefreshReport();
        }
    }
}
