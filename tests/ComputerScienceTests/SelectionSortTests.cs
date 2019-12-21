using Bogus;
using ComputerScience;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ComputerScienceTests
{
    [TestClass]
    public class SelectionSortTests
    {
        [DataRow(2, 2, 3, 4)]
        [DataRow(3, 2, 1)]
        [DataRow(3, 2, 4, 1, 0, 5, 5)]
        [DataRow(-4, 2, 0, 0, 1, 5, 99, 123, 4, 5)]
        [DataTestMethod]
        public void SelectionSort_DifferentInputs_ArrayIsSorted(params int[] inputArray)
        {
            var sortedByBuiltinSort = new int[inputArray.Length];
            Array.Copy(inputArray, sortedByBuiltinSort, sortedByBuiltinSort.Length);
            Array.Sort(sortedByBuiltinSort);

            var sut = new SelectionSorter();

            sut.Sort(inputArray);

            Assert.IsTrue(sortedByBuiltinSort.SequenceEqual(inputArray));
        }

        [TestMethod]
        public void SelectionSort_RandomInput_ArrayIsSorted()
        {
            var faker = new Faker();

            int[] inputArray = new int[faker.Random.Int(10, 10000)];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = faker.Random.Int();
            }

            var sortedByBuiltinSort = new int[inputArray.Length];
            Array.Copy(inputArray, sortedByBuiltinSort, sortedByBuiltinSort.Length);
            Array.Sort(sortedByBuiltinSort);

            var sut = new SelectionSorter();

            sut.Sort(inputArray);

            Assert.IsTrue(sortedByBuiltinSort.SequenceEqual(inputArray));
        }
    }
}
