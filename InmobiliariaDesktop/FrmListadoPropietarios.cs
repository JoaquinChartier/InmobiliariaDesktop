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
    public partial class FrmListadoPropietarios : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmListadoPropietarios()
        {
            InitializeComponent();
        }

        private void FrmListadoPropietarios_Load(object sender, EventArgs e)
        {
            var Propietarios = from propietario in db.Propietarios
                             select new { Id = propietario.Id, Nombre = propietario.Nombre, DNI = propietario.DNI, Telefono = propietario.Telefono, Direccion = propietario.Direccion, CuentaBancaria = propietario.CuentaBancaria, Localidad = propietario.Localidad.Nombre };

            this.PropietarioBindingSource.DataSource = Propietarios.ToList();
            this.reportViewerPropietarios.RefreshReport();
        }
    }
}
