using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloConexión
    {
        [TestMethod]
        public void TestConexion()
        {
            try
            {
                ModeloConexionBdd m = new ModeloConexionBdd();
                Assert.AreEqual("Open", m.Conexion.State.ToString());
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
