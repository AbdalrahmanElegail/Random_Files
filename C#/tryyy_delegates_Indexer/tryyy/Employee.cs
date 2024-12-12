using System;

namespace tryyy
{

    internal class People
    {
        public People[]? PeopleList { get; private set; }
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
    }
}
