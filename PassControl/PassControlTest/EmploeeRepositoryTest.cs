using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlBussinesLayer;
using System.Collections.Generic;

namespace PassControlTest
{
    [TestClass]
    public class EmploeeRepositoryTest
    {
        EmploeeRepository VisiDarbuotojai = new EmploeeRepository();
        List<Emploee> expectedDarbuotojai = new List<Emploee>();

        public void pasiruosimas()
        {
            expectedDarbuotojai.Add(new Emploee(0, "ab", "cd", new List<int> { 1, 2 }));
            expectedDarbuotojai.Add(new Emploee(1, "ef", "gh", new List<int> { 2 }));
            expectedDarbuotojai.Add(new Emploee(2, "zz", "qfq", new List<int> { 1 }));
            expectedDarbuotojai.Add(new Emploee(3, "fqq", "aa", new List<int> { 1 }));
            expectedDarbuotojai.Add(new Emploee(4, "az", "zggd", new List<int> { 0, 1 }));
            expectedDarbuotojai.Add(new Emploee(5, "agb", "acd", new List<int> { 0, 3 }));
            expectedDarbuotojai.Add(new Emploee(6, "agdb", "aqcd", new List<int> { 0 }));
            expectedDarbuotojai.Add(new Emploee(7, "agab", "adcd", new List<int> { 0 }));
            expectedDarbuotojai.Add(new Emploee(8, "agb", "ascd", new List<int> { 1 }));
            expectedDarbuotojai.Add(new Emploee(9, "agab", "acsd", new List<int> { 0, 2 }));
            expectedDarbuotojai.Add(new Emploee(10, "Vardas", "Pavarde", new List<int> { 0, 1 }));
        }

        [TestMethod]
        public void EmploeeRepositoryRetrieveTestAtitikimas()
        {
            // Arrange
            List <Emploee> actualDarbuotojai = VisiDarbuotojai.Retrieve();
            // Act
            pasiruosimas();
            // Assert
            Assert.AreEqual(actualDarbuotojai.Count,expectedDarbuotojai.Count);
        }

        [TestMethod]
        public void EmploeeRepositoryRetrieveTestAtitikimasSuVienu()
        {
            // Arrange
            //Emploee vienasDarbutojasActual = new Emploee(10, "Vardas", "Pavarde", new List<int> { 0, 1 });
            // Act
            //emploee expectedVienasDarbuotojas = VisiDarbuotojai.Retrieve(10);
            // Assert
            //Assert.AreEqual(vienasDarbutojasActual.Name, expectedVienasDarbuotojas.Name);
        }
    }
}
