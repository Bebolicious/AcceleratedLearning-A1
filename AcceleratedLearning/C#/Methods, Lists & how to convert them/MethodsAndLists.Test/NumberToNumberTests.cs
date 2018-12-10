using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class NumberToNumberTests
    {
        [TestMethod]
        public void SumNumbersTo()
        {
            var x = new NumberToNumber();
            Assert.AreEqual(1, x.SumNumbersTo(1));
            Assert.AreEqual(1 + 2, x.SumNumbersTo(2));
            Assert.AreEqual(1 + 2 + 3, x.SumNumbersTo(3));
            Assert.AreEqual(1 + 2 + 3 + 4, x.SumNumbersTo(4));

            Assert.ThrowsException<ArgumentException>(() => x.SumNumbersTo(0));
            Assert.ThrowsException<ArgumentException>(() => x.SumNumbersTo(-1));
        }

        [TestMethod]
        public void SumNumbers()
        {
            var x = new NumberToNumber();
            Assert.AreEqual(5, x.SumNumbers(5, 5));
            Assert.AreEqual(5 + 6, x.SumNumbers(5, 6));
            Assert.AreEqual(3 + 4 + 5 + 6 + 7, x.SumNumbers(3, 7));
            Assert.AreEqual(-3 + -2 + -1 + 0 + 1 + 2, x.SumNumbers(-3, 2));

            Assert.ThrowsException<ArgumentException>(() => x.SumNumbers(5, 4));
            Assert.ThrowsException<ArgumentException>(() => x.SumNumbers(-3, -4));
        }

        [TestMethod]
        public void SumNumbersDividedByThreeOrFive()
        {
            var x = new NumberToNumber();
            Assert.AreEqual(3, x.SumNumbersDividedByThreeOrFive(3));
            Assert.AreEqual(3, x.SumNumbersDividedByThreeOrFive(4));
            Assert.AreEqual(3 + 5, x.SumNumbersDividedByThreeOrFive(5));
            Assert.AreEqual(3 + 5 + 6, x.SumNumbersDividedByThreeOrFive(6));
            Assert.AreEqual(3 + 5 + 6, x.SumNumbersDividedByThreeOrFive(7));
            Assert.AreEqual(3 + 5 + 6, x.SumNumbersDividedByThreeOrFive(8));
            Assert.AreEqual(3 + 5 + 6 + 9, x.SumNumbersDividedByThreeOrFive(9));
            Assert.AreEqual(3 + 5 + 6 + 9 + 10, x.SumNumbersDividedByThreeOrFive(10));

            Assert.ThrowsException<ArgumentException>(() => x.SumNumbersTo(0));
            Assert.ThrowsException<ArgumentException>(() => x.SumNumbersTo(-1));
        }
    }
}
