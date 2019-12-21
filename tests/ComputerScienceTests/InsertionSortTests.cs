using ComputerScience;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerScienceTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [DataRow(3, 2, 1)]
        [DataRow(3, 2, 4, 1, 0, 5, 5)]
        [DataRow(-4, 2, 0, 0, 1, 5, 99, 123, 4, 5)]
        [DataTestMethod]
        public void InsertionSort_DifferentInputs_ArrayIsSorted(params int[] inputArray)
        {
            var sortedByBuiltinSort = new int[inputArray.Length];                        
            Array.Copy(inputArray, sortedByBuiltinSort, sortedByBuiltinSort.Length);
            Array.Sort(sortedByBuiltinSort);

            var sut = new InsertionSorter();

            sut.Sort(inputArray);

            Assert.IsTrue(sortedByBuiltinSort.SequenceEqual(inputArray));

        }
    }
}
