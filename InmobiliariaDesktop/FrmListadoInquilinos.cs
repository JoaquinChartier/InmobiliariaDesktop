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
    public partial class FrmListadoInquilinos : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmListadoInquilinos()
        {
            InitializeComponent();
        }

        private void FrmListadoInquilinos_Load(object sender, EventArgs e)
        {


            var Inquilinos = from inquilino in db.Inquilinos
                            select new { Id = inquilino.Id, Nombre = inquilino.Nombre, Jubilado = inquilino.Jubilado, Email = inquilino.Email, DNI = inquilino.DNI, Telefono = inquilino.Telefono };

            this.InquilinoBindingSource.DataSource = Inquilinos.ToList();
            this.reportViewerInquilinos.RefreshReport();
        }
    }
}
