using ComputerScience;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ComputerScienceTests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void QuickSort()
        {
            var rnd = new Random();

            var arrayLength = rnd.Next(30, 3000);

            var testArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                testArray[i] = rnd.Next(0, 100);
            }

            var sut = new QuickSorter();

            sut.Sort(testArray);            

            for (int i = 0; i < arrayLength; i++)
            {
                var current = testArray[i];
                if (i + 1 < testArray.Length)
                {
                    Assert.IsTrue(current <= testArray[i + 1]);
                }
            }

        }
    }
}
