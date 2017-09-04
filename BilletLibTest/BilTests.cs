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



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeOver7()
        {
            //Arrange
            var bil = new Bil("NX67218x",DateTime.Now,false);
            
        }


        [TestMethod]
        
        public void TestPrisBrobizz()
        {
            //Arrange
            var bil = new Bil("NX67218", DateTime.Now, true);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(228, pris);
        }



        [TestMethod]

        public void TestPrisWeekendMedBrobizz()
        {
            //Arrange
            var bil = new Bil("NX67218", new DateTime(2017,9,3), true);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(182, pris);
        }


        [TestMethod]

        public void TestPrisWeekendUdenBrobizz()
        {
            //Arrange
            var bil = new Bil("NX67218", new DateTime(2017, 9, 3), false);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(192, pris);
        }


    }
}
