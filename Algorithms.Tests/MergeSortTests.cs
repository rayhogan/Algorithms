using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Linq;
using System.Data;
using System;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void SuccessfulSort()
        {
            // Arrange
            List<int> originalArray = new List<int> { 45, 34, 99, 3, 102, 62, 12 };
            List<int> expectedArray = new List<int> { 3, 12, 34, 45, 62, 99, 102 };

            // Act
            List<int> sorted = MergeSort.Sort(originalArray);
            // Assert
            Assert.IsFalse(sorted.SequenceEqual(originalArray));
            Assert.IsTrue(sorted.SequenceEqual(expectedArray));

        }
    }
}
