using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace Algorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void SuccessfulIntegerFind()
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

        [TestMethod]
        public void SuccessfulStringFind()
        {
            // Arrange
            string[] input = { "abe", "babel", "david", "frank", "zebra" };
            // Act
            int index = BinarySearch.FindIndex(input, "abe");
            int index2 = BinarySearch.FindIndex(input, "david");
            int index3 = BinarySearch.FindIndex(input, "zebra");
            int index4 = BinarySearch.FindIndex(input, "alice");
            // Assert
            Assert.IsTrue(index == 0);
            Assert.IsTrue(index2 == 2);
            Assert.IsTrue(index3 == 4);
            Assert.IsTrue(index4 == -1);

        }
    }
}
