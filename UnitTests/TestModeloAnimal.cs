using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestModeloAnimal
    {
        [TestMethod]
        public void TestAltaAnimal()
        {
            try
            {
                ModeloAnimal a = new ModeloAnimal();
                a.NombreAnimal = "Perro";
                a.DescripcionAnimal = "rope";
                a.IdJ = 3;
                a.DarAltaAnimal();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestBajaAnimal()
        {
            try
            {
                ModeloAnimal a = new ModeloAnimal();
                a.IdAnimal = 4;
                a.DarBajaAnimal();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestModificarAnimal()
        {
            try
            {
                ModeloAnimal a = new ModeloAnimal();
                a.IdAnimal = 1;
                a.NombreAnimal = "Pinguino";
                a.DescripcionAnimal = "Ave que no vuela";
                a.IdJ = 2;
                a.ModificarAnimal();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListaraAnimal()
        {
            try
            {
                ModeloAnimal a = new ModeloAnimal();

                a.ObtenerAnimal();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
