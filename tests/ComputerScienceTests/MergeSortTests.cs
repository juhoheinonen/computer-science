using Bogus;
using ComputerScience;
using ComputerScience.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ComputerScienceTests
{
    [TestClass]
    public class MergeSortTests
    {
        [DataRow(2, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 2, 4, 7, 1, 3, 2, 6)]
        [DataRow(2, 2, 3, 4)]
        [DataRow(3, 2, 4, 1, 0, 5, 5)]
        [DataRow(-4, 2, 0, 0, 1, 5, 99, 123, 4, 5)]
        [DataTestMethod]
        public void MergeSort_DifferentInputs_ArrayIsSorted(params int[] inputArray)
        {
            var sortedByBuiltinSort = new int[inputArray.Length];
            Array.Copy(inputArray, sortedByBuiltinSort, sortedByBuiltinSort.Length);
            Array.Sort(sortedByBuiltinSort);

            var sut = new MergeSorter();

            sut.Sort(inputArray);

            Assert.IsTrue(sortedByBuiltinSort.SequenceEqual(inputArray));
        }

        [TestMethod]
        public void MergeSort_RandomInput_ArrayIsSorted()
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

            var sut = new MergeSorter();

            sut.Sort(inputArray);

            Assert.IsTrue(sortedByBuiltinSort.SequenceEqual(inputArray));
        }
    }
}
