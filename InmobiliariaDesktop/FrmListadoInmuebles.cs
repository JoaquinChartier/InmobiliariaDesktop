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
    public partial class FrmListadoInmuebles : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmListadoInmuebles()
        {
            InitializeComponent();
        }

        private void FrmListadoInmuebles_Load(object sender, EventArgs e)
        {
            var Inmuebles = from inmueble in db.Inmuebles
                            select new { Id = inmueble.Id, Nombre = inmueble.Nombre, Propietario = inmueble.Propietario.Nombre, TipoDeInmueble = inmueble.TipoDeInmueble.ToString(), PrecioAlquiler = inmueble.PrecioAlquiler};

            this.InmuebleBindingSource.DataSource = Inmuebles.ToList();
            this.reportViewerInmuebles.RefreshReport();
        }
    }
}
