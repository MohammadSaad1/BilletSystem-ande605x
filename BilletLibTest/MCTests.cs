using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTest
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void TestPris120()
        {
            //Arrange
            var mc = new MC();
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(120, pris);
        }


        [TestMethod]
        public void TestKøretøjMC()
        {
            //Arrange
            var mc = new MC();
            //Act
            string køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }

    }
}
