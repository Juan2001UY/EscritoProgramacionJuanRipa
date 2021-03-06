using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaVisual
{
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MySqlDataReader visitante = CapaLogica.ControladorCompra.ObtenerVisitanteParaCompra(txtCedulaComprador.Text);
            if (visitante.Read())
            {
                string Cedula = visitante.GetString(0);
                if (Cedula == txtCedulaComprador.Text)
                {
                    CapaLogica.ControladorCompra.AltaCompra(txtCedulaComprador.Text, LbTickets.GetItemText(LbTickets.SelectedItem), lblMostrarPrecio.Text);
                    MessageBox.Show("Compra Realizada Correctamente");
                    txtCedulaComprador.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("No existe un visitante con esta Cedula, agreguelo para continuar");
                AgregarVisitanteDesdeCompra frm = new AgregarVisitanteDesdeCompra();
                frm.Show();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = LbTickets.SelectedIndex;
            switch (indice)
            {
                case 0:
                    lblMostrarPrecio.Text = "30$";
                    break;
                case 1:
                    lblMostrarPrecio.Text = "50$";
                    break;
                case 2:
                    lblMostrarPrecio.Text = "100$";
                    break;
                case 3:
                    lblMostrarPrecio.Text = "250$";
                    break;
                default:
                    lblMostrarPrecio.Text = "";
                    break;
            }
        }






        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblCedulaComprador_Click(object sender, EventArgs e)
        {

        }

    }
}
