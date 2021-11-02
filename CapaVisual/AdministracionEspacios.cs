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
    public partial class AdministracionEspacios : Form
    {
        public AdministracionEspacios()
        {
            InitializeComponent();
        }

        private void btnGuardarEspacio_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorEspacio.AltaEspacio(txtNombreEspacio.Text, txtDescripcionEspacio.Text);
            MessageBox.Show("Agregado Correctamente");
            txtIdEspacio.Text = String.Empty;
            txtDescripcionEspacio.Text = String.Empty;
            txtNombreEspacio.Text = String.Empty;
        }

        private void btnEliminarEspacio_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorEspacio.BajaEspacio(Int32.Parse(txtIdEspacio.Text));
            MessageBox.Show("Eliminado Correctamente");
            txtIdEspacio.Text = String.Empty;
            txtDescripcionEspacio.Text = String.Empty;
            txtNombreEspacio.Text = String.Empty;
        }

        private void btnModificarEspacio_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorEspacio.ModificarEspacio(txtNombreEspacio.Text, txtDescripcionEspacio.Text, Int32.Parse(txtIdEspacio.Text));
            MessageBox.Show("Modificado Correctamente");
            txtIdEspacio.Text = String.Empty;
            txtDescripcionEspacio.Text = String.Empty;
            txtNombreEspacio.Text = String.Empty;
        }

        private void btnListarEspacio_Click(object sender, EventArgs e)
        {
            dgvEspacio.DataSource = CapaLogica.ControladorEspacio.Obtener();;
        }
    }
}
