using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloEspacio
    {
        [TestMethod]
        public void TestAltaEspacio()
        {
            try
            {
                ModeloEspacio e = new ModeloEspacio();
                e.NombreEspacio = "Jungla";
                e.DescripcionEspacio = "sgfdsfdsdsf";
                e.DarAltaEspacio();

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
                ModeloEspacio e = new ModeloEspacio();
                e.IdEspacio = 3;
                e.DarBajaEspacio();
                Assert.IsTrue(true);
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
                ModeloEspacio e = new ModeloEspacio();
                e.IdEspacio = 4;
                e.NombreEspacio = "Junglaaaa";
                e.DescripcionEspacio = "sgfdsfdsdsfaaaa";
                e.ModificarEspacio();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListaraEspacio()
        {
            try
            {
                ModeloEspacio e = new ModeloEspacio();

                e.ListarEspacio();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
 