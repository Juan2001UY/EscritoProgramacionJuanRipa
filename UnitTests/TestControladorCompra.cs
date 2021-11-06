using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestControladorCompra
    {
        [TestMethod]
        public void TestAltaCompra()
        {
            try
            {
                CapaLogica.ControladorCompra.AltaCompra("112233", "6 Espacios", "$50");

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestAltaVisitanteDesdeCompra()
        {
            try
            {
                CapaLogica.ControladorCompra.AltaVisitanteDesdeCompra("111111", "Armando");
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestObtenerVisitanteDesdeCompra()
        {
            try
            {
                CapaLogica.ControladorCompra.ObtenerVisitanteParaCompra("111111");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
