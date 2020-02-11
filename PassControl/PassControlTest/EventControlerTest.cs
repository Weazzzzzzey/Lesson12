using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlBussinesLayer;
using System.Collections.Generic;
namespace PassControlTest
{
    [TestClass]
    public class EventControlerTest
    {
        private EmploeeRepository visiDarbuotojai;
        private EventController dc;
        
        [TestInitialize]
        public void TestInitialize()
        {
        visiDarbuotojai = new EmploeeRepository();
        dc = new EventController(visiDarbuotojai);
            dc.TryPass(0, 1);
            dc.TryPass(2, 2);
            dc.TryPass(4, 2);
            dc.TryPass(1, 3);
            dc.TryPass(10, 4);
            dc.TryPass(0,1);
        }


        [TestMethod]
        public void PirmasSaraseTuriButTrue()
        {
            // Arrange
            List<Event> ivykditiE = dc.Retrieve();
            bool actual = ivykditiE[0].Pass;
            // Act
            bool result = true;
            // Assert
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void SarasoSkaiciusVienodas()
        {
            // Arrange
            List<Event> ivykditiE = dc.Retrieve();
            int actual = ivykditiE.Count;
            // Act
            int result = 5;
            // Assert
            Assert.AreEqual(actual, result);
        }

    }
}
