using System.Collections.Generic;
using System.Linq;

namespace ComputerScience
{
    public class BinarySearcher
    {
        public TestPerson SearchById(int id, IList<TestPerson> people)
        {
            if (people == null)
            {
                return null;
            }

            people = people.OrderBy(p => p.Id).ToList();

            int middleItemIndex = people.Count() / 2;

            var foundPerson = people[middleItemIndex];

            if (foundPerson.Id == id)
            {
                return foundPerson;
            }

            if (middleItemIndex == 0)
            {
                return null;
            }

            if (foundPerson.Id < id)
            {
                return SearchById(id, people.Skip(middleItemIndex).ToList());
            }
            else
            {
                return SearchById(id, people.Take(middleItemIndex).ToList());
            }
        }
    }

    public class TestPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
