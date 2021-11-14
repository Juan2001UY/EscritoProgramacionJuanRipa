using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloVisitantes
    {
        [TestMethod]
        public void TestAltaVisitante()
        {
            try
            {
                ModeloVisitante v = new ModeloVisitante();
                v.Cedula = "66666666";
                v.NombreVisitante = "Jorge";
                v.DarAltaVisitante();

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
            ModeloVisitante v = new ModeloVisitante();
            v.IdVisitante = 5;
            v.DarBajaVisitante();
            Assert.IsTrue(true);
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
                ModeloVisitante v = new ModeloVisitante();
                v.IdVisitante = 1;
                v.Cedula = "11111111";
                v.NombreVisitante = "Juan Andres";
                v.ModificarVisitante();

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
                ModeloVisitante v = new ModeloVisitante();
          
                v.ObtenerVisitante();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
