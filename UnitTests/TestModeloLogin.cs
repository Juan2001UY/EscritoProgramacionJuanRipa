using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloLogin
    {
        [TestMethod]
        public void TestBuscarUsuario()
        {
            try
            {
                ModeloLogin l = new ModeloLogin();
                l.NombreDeUsuario = "Luis";
                l.Contraseña = "1234";
                l.BuscarUsuario();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

    }
}
