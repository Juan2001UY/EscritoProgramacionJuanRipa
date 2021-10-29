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
    public partial class AgregarVisitanteDesdeCompra : Form
    {
        public AgregarVisitanteDesdeCompra()
        {
            InitializeComponent();
        }

        private void btnGuardarDesdeCompra_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorCompra.AltaVisitanteDesdeCompra(txtCedulaDesdeCompra.Text, txtNombreDesdeCompra.Text);
            MessageBox.Show("Visitante Agregado Correctamente");
            this.Hide();
        }
    }
}
