using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVisual
{
    public partial class AdministracionJaulas : Form
    {
        public AdministracionJaulas()
        {
            InitializeComponent();
        }

        private void btnAltaJaula_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorJaula.AltaJaula(txtDescripcionJaula.Text, Int32.Parse(txtIdUbicacion.Text));
            MessageBox.Show("Agregado Correctamente");
            txtIdJaula.Text = String.Empty;
            txtDescripcionJaula.Text = String.Empty;
            txtIdUbicacion.Text = String.Empty;
        }

        private void btnBajaJaula_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorJaula.BajaJaula(Int32.Parse(txtIdJaula.Text));
            MessageBox.Show("Eliminado Correctamente");
            txtIdJaula.Text = String.Empty;
            txtDescripcionJaula.Text = String.Empty;
            txtIdUbicacion.Text = String.Empty;
        }

        private void btnModificarJaula_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorJaula.ModificarJaula(txtDescripcionJaula.Text, Int32.Parse(txtIdUbicacion.Text), Int32.Parse(txtIdJaula.Text));
            MessageBox.Show("Modificado Correctamente");
            txtIdJaula.Text = String.Empty;
            txtDescripcionJaula.Text = String.Empty;
            txtIdUbicacion.Text = String.Empty;
        }

        private void btnListarJaula_Click(object sender, EventArgs e)
        {
            
            dgvJaula.DataSource = CapaLogica.ControladorJaula.ListarTodoJaula();

        }
    }
}
