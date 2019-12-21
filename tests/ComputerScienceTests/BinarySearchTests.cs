using ComputerScience;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ComputerScienceTests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void Search_FindsItem()
        {
            var people = new List<TestPerson>();

            people.Add(new TestPerson()
            {
                Id = 5,
                Name = "Tester 0"
            });

            people.Add(new TestPerson()
            {
                Id = 3,
                Name = "Tester 1"
            });

            people.Add(new TestPerson()
            {
                Id = 2,
                Name = "Tester 2"
            });

            var sut = new BinarySearcher();

            var result = sut.SearchById(3, people);

            Assert.IsNotNull(result);
            Assert.AreEqual("Tester 1", result.Name);

            result = sut.SearchById(5, people);

            Assert.IsNotNull(result);
            Assert.AreEqual("Tester 0", result.Name);

            result = sut.SearchById(2, people);

            Assert.IsNotNull(result);
            Assert.AreEqual("Tester 2", result.Name);


            result = sut.SearchById(999, people);

            Assert.IsNull(result);            
        }
    }
}
