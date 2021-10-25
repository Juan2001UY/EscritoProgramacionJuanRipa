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
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorCompra.AltaCompra(txtCedulaComprador.Text, cbProductos.Text);
            MessageBox.Show("Compra Realizada Correctamente");
            txtCedulaComprador.Text = String.Empty;
            cbProductos.Text = "Seleccione un Ticket" ;
        }
    }
}
