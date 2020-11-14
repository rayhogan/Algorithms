using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Linq;
using System.Data;
using System;

namespace Algorithms.Tests
{
    [TestClass]
    public class GreedyChangeTests
    {
        [TestMethod]
        public void SmallestChange_Test1()
        {
            /* COIN PURSE
             * ============================
             * index[0] = number of €2
             * index[1] = number of €1
             * index[2] = number of €0.50
             * index[3] = number of €0.20
             * index[4] = number of €0.10
             * index[5] = number of €0.05
             * index[6] = number of €0.02
             * index[7] = number of €0.01
             */

            // Arrange
            Decimal amount = 5.62m;
            int[] coinPurse = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            // Act
            GreedyChange.DetermineChange(coinPurse, amount);
            // Assert

            Assert.AreEqual(2, coinPurse[0]);
            Assert.AreEqual(1, coinPurse[1]);
            Assert.AreEqual(1, coinPurse[2]);
            Assert.AreEqual(1, coinPurse[4]);
            Assert.AreEqual(1, coinPurse[6]);

            Assert.AreEqual(0, coinPurse[3]);
            Assert.AreEqual(0, coinPurse[5]);
            Assert.AreEqual(0, coinPurse[7]);

        }
        [TestMethod]
        public void SmallestChange_Test2()
        {
            /* COIN PURSE
             * ============================
             * index[0] = number of €2
             * index[1] = number of €1
             * index[2] = number of €0.50
             * index[3] = number of €0.20
             * index[4] = number of €0.10
             * index[5] = number of €0.05
             * index[6] = number of €0.02
             * index[7] = number of €0.01
             */

            // Arrange
            Decimal amount = 0.63m;
            int[] coinPurse = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            // Act
            GreedyChange.DetermineChange(coinPurse, amount);
            // Assert

            Assert.AreEqual(0, coinPurse[0]);
            Assert.AreEqual(0, coinPurse[1]);
            Assert.AreEqual(1, coinPurse[2]);
            Assert.AreEqual(0, coinPurse[3]);
            Assert.AreEqual(1, coinPurse[4]);
            Assert.AreEqual(0, coinPurse[5]);
            Assert.AreEqual(1, coinPurse[6]);
            Assert.AreEqual(1, coinPurse[7]);


        }
    }
}
