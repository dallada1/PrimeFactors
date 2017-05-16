using System;
using PrimeFactors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PrimeFactorsTests
    {
        private PrimeFactor primeFactors;

        public PrimeFactorsTests()
        {
            primeFactors = new PrimeFactor();
        }

        [TestMethod]
        public void GenerateWithOneReturnsNull()
        {
            Assert.IsNull(primeFactors.Generate(1));
        }

        [TestMethod]
        public void GenerateWithTwoReturnsTwo()
        {
            CollectionAssert.AreEqual(new[] { 2 }, primeFactors.Generate(2));
        }

        [TestMethod]
        public void GenerateWithThreeReturnsThree()
        {
            CollectionAssert.AreEqual(new[] { 3 }, primeFactors.Generate(3));
        }

        [TestMethod]
        public void GenerateWithFourReturnsTwoTwo()
        {
            CollectionAssert.AreEqual(new[] { 2, 2 }, primeFactors.Generate(4));
        }

        [TestMethod]
        public void GenerateWithSixReturnsTwoAndThree()
        {
            CollectionAssert.AreEqual(new[] { 2, 3 }, primeFactors.Generate(6));
        }

        [TestMethod]
        public void GenerateWithEightReturnsTwoTwoTwo()
        {
            CollectionAssert.AreEqual(new[] { 2, 2, 2 }, primeFactors.Generate(8));
        }

        [TestMethod]
        public void GenerateWithNineReturnsThreeThreeThree()
        {
            CollectionAssert.AreEqual(new[] { 3, 3 }, primeFactors.Generate(9));
        }
    }
}
