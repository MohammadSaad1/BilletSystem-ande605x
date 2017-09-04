using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTest
{
    [TestClass]
    public class ØresundBilTests
    {
        [TestMethod]
        public void TestPris410Øresund()
        {
            //Arrange
            var bil = new ØresundsBil();
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(410, pris);
        }


        [TestMethod]
        public void TestKøretøjBilØresund()
        {
            //Arrange
            var bil = new ØresundsBil();
            //Act
            string køretøj = bil.KøretøjType();
            //Assert
            Assert.AreEqual("Øresund Bil", køretøj);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeOver7Øresund()
        {
            //Arrange
            var bil = new ØresundsBil("NX67218x",DateTime.Now,false);
            
        }


        [TestMethod]
        
        public void TestPrisBrobizzØresund()
        {
            //Arrange
            var bil = new ØresundsBil("NX67218", DateTime.Now, true);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(161, pris);
        }


        


    }
}
