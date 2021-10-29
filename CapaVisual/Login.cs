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
            if (usuarios.Read())
            {
                string Nombre = usuarios.GetString(0);
                string Contraseña = usuarios.GetString(1);
                string TipoUsuario = usuarios.GetString(2);
                if ((Nombre == txtUsuario.Text) && (Contraseña == txtContraseña.Text))
                {
                    if (TipoUsuario == "Admin")
                    {
                        MenuAdministrador frm = new MenuAdministrador();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MenuVendedor frm = new MenuVendedor();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}