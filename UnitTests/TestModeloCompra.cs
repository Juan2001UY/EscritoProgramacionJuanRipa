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
                c.CedulaComprador = "11111111";
                c.Producto = "10 Espacios";
                c.Precio = "100$";
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
                c.CedulaComprador = "88888888";
                c.NombreVisitante = "Marcos";
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
                c.CedulaComprador = "22222222";
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

