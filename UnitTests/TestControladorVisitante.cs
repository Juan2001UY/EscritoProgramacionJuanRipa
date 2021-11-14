using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
using MySql.Data.MySqlClient;
using System.Data;

namespace UnitTests
{
    [TestClass]
    public class TestControladorVisitante
    {
        [TestMethod]
        public void TestAltaVisitante()
        {
            try
            {
                CapaLogica.ControladorVisitante.AltaVisitante("77777777", "Francisco");

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestBajaVisitante()
        {
            try
            {
                CapaLogica.ControladorVisitante.BajaVisitante(4);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestModificarVisitante()
        {
            try
            {
                CapaLogica.ControladorVisitante.ModificarVisitante("10101010", "Martin", 3);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListararVisitante()
        {
            try
            {
                Assert.IsNotNull(CapaLogica.ControladorVisitante.ListarTodoVisitante());
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}

