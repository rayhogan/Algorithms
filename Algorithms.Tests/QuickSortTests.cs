using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Linq;
using System.Data;
using System;

namespace Algorithms.Tests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void SuccessfulSort()
        {
            // Arrange
            int[] originalArray = new int[] { 45, 34, 99, 3, 102, 62, 12 };
            int[] expectedArray = new int[] { 3, 12, 34, 45, 62, 99, 102 };
            int[] copiedArray = new int[originalArray.Length];
            originalArray.CopyTo(copiedArray, 0);
            // Act
            QuickSort.Sort(copiedArray, 0, copiedArray.Length-1);
            // Assert
            Assert.IsFalse(originalArray.SequenceEqual(copiedArray));
            Assert.IsTrue(expectedArray.SequenceEqual(copiedArray));

        }
    }
}
