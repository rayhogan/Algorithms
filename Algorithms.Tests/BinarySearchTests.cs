using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace Algorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void SuccessfulFind()
        {
            // Arrange
            int[] input = { 1, 3, 5, 7, 9 };
            // Act
            int index = BinarySearch.FindIndex(input, 3);
            int index2 = BinarySearch.FindIndex(input, 7);
            int index3 = BinarySearch.FindIndex(input, 1);
            int index4 = BinarySearch.FindIndex(input, 56);
            // Assert
            Assert.IsTrue(index == 1);
            Assert.IsTrue(index2 == 3);
            Assert.IsTrue(index3 == 0);
            Assert.IsTrue(index4 == -1);

        }
    }
}
