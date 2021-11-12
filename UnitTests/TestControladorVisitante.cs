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
                CapaLogica.ControladorVisitante.AltaVisitante("777777", "eeeeeeee");

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
                CapaLogica.ControladorVisitante.BajaVisitante(14);
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
                CapaLogica.ControladorVisitante.ModificarVisitante("999999", "iiiiiii", 12);
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

