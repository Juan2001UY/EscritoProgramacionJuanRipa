using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloCompra
    {
        [TestMethod]
        public void TestDarAltaCompra()
        {
            try
            {
                ModeloCompra c = new ModeloCompra();
                c.CedulaComprador = "112233";
                c.Producto = "6 Espacios";
                c.Precio = "50$";
                c.DarAltaCompra();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestDarAltaVisitanteDesdeCompra()
        {
            try
            {
                ModeloCompra c = new ModeloCompra();
                c.CedulaComprador = "669911";
                c.NombreVisitante = "Joseeeee";
                c.DarAltaVisitanteDesdeCompra();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestBuscarVisitanteParaCompra()
        {
            try
            {
                ModeloCompra c = new ModeloCompra();
                c.CedulaComprador = "1144888";
                c.BuscarVisitanteParaCompra();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}

