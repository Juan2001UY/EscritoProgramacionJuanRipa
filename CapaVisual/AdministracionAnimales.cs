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
    public partial class AdministracionAnimales : Form
    {
        public AdministracionAnimales()
        {
            InitializeComponent();
        }

        private void btnGuardarAnimales_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorAnimal.AltaAnimal(txtNombreAnimal.Text, txtDescripcionAnimal.Text, Int32.Parse(txtIdJ.Text));
            MessageBox.Show("Agregado Correctamente");
            txtNombreAnimal.Text = String.Empty;
            txtDescripcionAnimal.Text = String.Empty;
            txtIdJ.Text = String.Empty;
            txtIdAnimal.Text = String.Empty;

        }

        private void btnEliminarAnimales_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorAnimal.BajaAnimal(Int32.Parse(txtIdAnimal.Text));
            MessageBox.Show("Eliminado Correctamente");
            txtNombreAnimal.Text = String.Empty;
            txtDescripcionAnimal.Text = String.Empty;
            txtIdJ.Text = String.Empty;
            txtIdAnimal.Text = String.Empty;
        }

        private void btnModificarAnimales_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorAnimal.ModificarAnimal(Int32.Parse(txtIdJ.Text), txtNombreAnimal.Text, txtDescripcionAnimal.Text, Int32.Parse(txtIdAnimal.Text));
            MessageBox.Show("Modificado Correctamente");
            txtNombreAnimal.Text = String.Empty;
            txtDescripcionAnimal.Text = String.Empty;
            txtIdJ.Text = String.Empty;
            txtIdAnimal.Text = String.Empty;
        }

        private void btnlistarAnimales_Click(object sender, EventArgs e)
        {
            dgvAnimales.DataSource = CapaLogica.ControladorAnimal.Obtener();
        }
    }
}
