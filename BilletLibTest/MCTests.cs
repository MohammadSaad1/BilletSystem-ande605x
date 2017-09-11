using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTest
{
    [TestClass]
    public class MCTests
    {

        //Flot kode Anders det synes jeg 
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
            string køretøj = mc.KøretøjType();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }

    }
}
