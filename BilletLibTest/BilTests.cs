using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTest
{
    [TestClass]
    public class BilTests
    {
        [TestMethod]
        public void TestPris240()
        {
            //Arrange
            var bil = new Bil();
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }


        [TestMethod]
        public void TestKøretøjBil()
        {
            //Arrange
            var bil = new Bil();
            //Act
            string køretøj = bil.KøretøjType();
            //Assert
            Assert.AreEqual("Bil", køretøj);
        }


    }
}
