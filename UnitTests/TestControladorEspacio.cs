using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestControladorEspacio
    {
        [TestMethod]
        public void TestAltaEspacio()
        {
            try
            {
                CapaLogica.ControladorEspacio.AltaEspacio("fdfdsfs", "gfbfgbfgbfg");

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestBajaEspacio()
        {
            try
            {
                CapaLogica.ControladorEspacio.BajaEspacio(5);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestModificarEspacio()
        {
            try
            {
                CapaLogica.ControladorEspacio.ModificarEspacio("ascavbfb", "xvcbggfbdff", 8);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListararEspacio()
        {
            try
            {
                CapaLogica.ControladorEspacio.Obtener();
                Assert.IsNotNull(tabla);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
