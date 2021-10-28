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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                MySqlDataReader usuarios = CapaLogica.ControladorLogin.ObtenerUsuario(txtUsuario.Text, txtContraseña.Text);
                while (usuarios.Read())
                {
                string NombreIngresado = usuarios.GetString(0);
                string ContraseñaIngresada = usuarios.GetString(1);
                string TipoUsuario = usuarios.GetString(2);
                if ((NombreIngresado == txtUsuario.Text) && (ContraseñaIngresada == txtContraseña.Text))
                {
                    if (TipoUsuario == "Admin")
                   {
                        MenuAdministrador frm = new MenuAdministrador();
                        frm.Show();
                    }
                    else
                    {
                        MenuVendedor frm = new MenuVendedor();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de Usuario o Contraseña Incorrectos");
                }
            }
        }

    }
}