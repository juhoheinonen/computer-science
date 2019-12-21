using System.Collections.Generic;
using System.Linq;

namespace ComputerScience
{
    public class BinarySearcher
    {
        public TestPerson SearchById(int id, IEnumerable<TestPerson> people)
        {
            if (people == null)
            {
                return null;
            }

            people = people.OrderBy(p => p.Id);

            int middleItemIndex = people.Count() / 2;

        }
    }

    public class TestPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
