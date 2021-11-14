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
                CapaLogica.ControladorJaula.AltaJaula("200 * 200", 3);

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
                CapaLogica.ControladorJaula.BajaJaula(5);
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
                CapaLogica.ControladorJaula.ModificarJaula("79 * 21", 1, 1);
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
                Assert.IsNotNull(CapaLogica.ControladorJaula.ListarTodoJaula());
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
