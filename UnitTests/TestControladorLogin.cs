using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class TestControladorLogin
    {
        [TestMethod]
        public void TestObtenerUsuario()
        {
            try
            {
                CapaLogica.ControladorVisitante.AltaVisitante("Juan", "1234");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
