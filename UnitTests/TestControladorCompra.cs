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
                CapaLogica.ControladorCompra.AltaCompra("11111111", "6 Espacios", "$50");

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
                CapaLogica.ControladorCompra.AltaVisitanteDesdeCompra("99999999", "Jose");
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
                CapaLogica.ControladorCompra.ObtenerVisitanteParaCompra("11111111");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
