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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Text = "Inmobiliaria - "+DateTime.Now.ToString();
        }

        private void gestionarInquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionInquilinos frmGestionInquilinos = new FrmGestionInquilinos();
            frmGestionInquilinos.ShowDialog();
        }

        private void ingresarNuevoInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoInquilino frmNuevoInquilino = new FrmNuevoInquilino();
            frmNuevoInquilino.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
