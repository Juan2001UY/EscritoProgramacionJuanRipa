using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestControladorAnimal
    {
        [TestMethod]
        public void TestAltaAnimal()
        {
            try
            {
                CapaLogica.ControladorAnimal.AltaAnimal("Vibora", "Larga", 2);

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
                CapaLogica.ControladorAnimal.BajaAnimal(5);
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
                CapaLogica.ControladorAnimal.ModificarAnimal(3, "Pez", "Muchos colores", 3);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void TestListararAnimal()
        {
            try
            {
                Assert.IsNotNull(CapaLogica.ControladorAnimal.ListarTodoAnimal());
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
