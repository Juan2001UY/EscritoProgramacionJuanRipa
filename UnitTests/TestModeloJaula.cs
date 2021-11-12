using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloJaula
    {
        [TestMethod]
        public void TestAltaJaula()
        {
            try
            {
                ModeloJaula j = new ModeloJaula();
                j.DescripcionJaula = "sgfdsfdsdsf";
                j.IdUbicacion = 2;
                j.DarAltaJaula();

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
                ModeloJaula j = new ModeloJaula();
                j.IdJaula = 5;
                j.DarBajaJaula();
                Assert.IsTrue(true);
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
                ModeloJaula j = new ModeloJaula();
                j.IdJaula = 3;
                j.DescripcionJaula = "bbbbbb";
                j.IdUbicacion = 4;
                j.ModificarJaula();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListaraJaula()
        {
            try
            {
                ModeloJaula j = new ModeloJaula();

                j.ObtenerJaula();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
