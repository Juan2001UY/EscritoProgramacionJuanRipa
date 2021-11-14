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
                e.DescripcionEspacio = "vegetación muy abundante y espesa";
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
                e.IdEspacio = 4;
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
                e.IdEspacio = 1;
                e.NombreEspacio = "Polo Sur";
                e.DescripcionEspacio = "Frio";
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

                e.ObtenerEspacio();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
 