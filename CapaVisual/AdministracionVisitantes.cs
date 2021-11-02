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
using MySql.Data.MySqlClient;



namespace CapaVisual
{
    public partial class AdministracionVisitantes : Form
    {
        public AdministracionVisitantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorVisitante.AltaVisitante(txtCedula.Text, txtNombre.Text);
            MessageBox.Show("Agregado Correctamente");
            txtCedula.Text = String.Empty;
            txtNombre.Text = String.Empty;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorVisitante.ModificarVisitante(txtNombre.Text, txtCedula.Text);
            MessageBox.Show("Modificado Correctamente");
            txtCedula.Text = String.Empty;
            txtNombre.Text = String.Empty;
        }

        private void btnEliminarVisitantes_Click(object sender, EventArgs e)
        {
            CapaLogica.ControladorVisitante.BajaVisitante(txtCedula.Text);
            MessageBox.Show("Eliminado Correctamente");
            txtCedula.Text = String.Empty;
            txtNombre.Text = String.Empty;
        }

        private void btnListarVisitantes_Click(object sender, EventArgs e)
        {
          
            dgvVisitantes.DataSource = CapaLogica.ControladorVisitante.Obtener(); ;
        }
    }
}