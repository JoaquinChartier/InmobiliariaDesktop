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
    public partial class FrmGestionInquilinos : Form
    {
        InmobiliariaDesktopContext db = new InmobiliariaDesktopContext();

        public FrmGestionInquilinos()
        {
            InitializeComponent();
            grid.DataSource = db.Inquilinos.ToList();
        }
        
    }
}
