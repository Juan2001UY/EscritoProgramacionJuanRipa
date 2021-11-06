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
                v.Cedula = "33333";
                v.NombreVisitante = "Jorgepp";
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
            v.IdVisitante = 13;
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
                v.IdVisitante = 12;
                v.Cedula = "1144888";
                v.NombreVisitante = "Pedro";
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
