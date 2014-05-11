using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearch.Tests
{
    [TestClass]
    public class BinarySearchSpecification
    {
        [TestMethod]
        public void Searching_an_empty_array_returns_null()
        {
            var emptyArray = new int[0];

            Assert.IsNull(ExecuteFind(emptyArray, 1));
        }

        [TestMethod]
        public void Searching_a_one_element_array_containing_the_value_returns_zero()
        {
            var array = new int[] { 1 };

            Assert.AreEqual(ExecuteFind(array, 1), 0);
        }

        [TestMethod]
        public void Searching_a_one_element_array_not_containing_the_value_returns_null()
        {
            var array = new int[] { 2 };

            Assert.IsNull(ExecuteFind(array, 1), null);
        }

        [TestMethod]
        public void Searching_a_two_element_array_containing_the_value_returns_the_index()
        {
            var array = new int[] { 1,3 };

            Assert.AreEqual(ExecuteFind(array, 3), 1);
        }

        [TestMethod]
        public void Searching_a_two_element_array_not_containing_the_value_returns_null()
        {
            var array = new int[] { 2,4 };

            Assert.IsNull(ExecuteFind(array, 3), null);
        }

        [TestMethod]
        public void Searching_a_five_element_array_not_containing_the_value_returns_null()
        {
            var array = new int[] { 1, 2, 6, 7, 9 };

            Assert.IsNull(ExecuteFind(array, 4), null);
        }

        [TestMethod]
        public void Correctly_searches_a_five_element_array()
        {
            var array = new int[] { 1, 2, 6, 7, 9 };

            Assert.AreEqual(ExecuteFind(array, 1), 0);
            Assert.AreEqual(ExecuteFind(array, 2), 1);
            Assert.AreEqual(ExecuteFind(array, 6), 2);
            Assert.AreEqual(ExecuteFind(array, 7), 3);
            Assert.AreEqual(ExecuteFind(array, 9), 4);
        }

        [TestMethod]
        public void Returns_the_lowest_index_when_array_contains_duplicates()
        {
            var array = new int[] { 1, 2, 2, 7, 9 };

            Assert.AreEqual(ExecuteFind(array, 2), 1);
        }

        private int? ExecuteFind( int[] array, int value )
        {
            var searcher = new BinarySearch();
            return searcher.Find(array, value);
        }
    }
}
