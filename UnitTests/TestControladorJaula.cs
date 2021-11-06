using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestControladorJaula
    {
        [TestMethod]
        public void TestAltaJaula()
        {
            try
            {
                CapaLogica.ControladorJaula.AltaJaula("sdsadsadad", 3);

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestBajaJaula()
        {
            try
            {
                CapaLogica.ControladorJaula.BajaJaula(7);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestModificarJaula()
        {
            try
            {
                CapaLogica.ControladorJaula.ModificarJaula("llllkkkjj", 6, 8);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListararJaula()
        {
            try
            {
                CapaLogica.ControladorJaula.Obtener();
                Assert.IsNotNull(tabla);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
