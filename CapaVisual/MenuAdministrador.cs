using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnMenuVisitantes_Click(object sender, EventArgs e)
        {
            AdministracionVisitantes frm = new AdministracionVisitantes();
            frm.Show();
           

        }

        private void btnMenuEspacios_Click(object sender, EventArgs e)
        {
            AdministracionEspacios frm1 = new AdministracionEspacios();
            frm1.Show();
           
        }

        private void BtnMenuJaulas_Click(object sender, EventArgs e)
        {
            AdministracionJaulas frm2 = new AdministracionJaulas();
            frm2.Show();
           
        }

        private void btnMenuAnimales_Click(object sender, EventArgs e)
        {
            AdministracionAnimales frm3 = new AdministracionAnimales();
            frm3.Show();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
