using System;
using System.Collections;

namespace tryyy
{

    internal class People : IEnumerable
    {
        private People[]? PeopleList { get; set; }
        public void SetPeopleList(People[] peopleList) { PeopleList = peopleList; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public double Sales { get; set; }

        public People this[int id]
        {
            get
            {
                if (PeopleList == null || id <= 0 || id > PeopleList.Length)
                    throw new IndexOutOfRangeException("Invalid employee ID.");
                return PeopleList[id - 1];
            }
            set
            {
                if (PeopleList == null || id <= 0 || id > PeopleList.Length)
                    throw new IndexOutOfRangeException("Invalid employee ID.");
                PeopleList[id - 1] = value;
            }
        }
        public override string ToString() => $"Id: {Id} | Name: {Name} | Gender: {Gender} | Sales: {Sales} ";

        public IEnumerator GetEnumerator()
        {
            return new PeopleEnumerator(PeopleList!);
        }
        public class PeopleEnumerator(People[] people) : IEnumerator
        {
            private People[] _people = people;
            private int _index = -1;

            public bool MoveNext()
            {
                _index++;
                return _index < _people.Length;
            }
            public void Reset()
            {
                _index = -1;
            }
            public object Current
            {
                get
                {
                    try
                    {
                        return _people[_index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
