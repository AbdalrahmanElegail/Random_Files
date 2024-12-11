using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog
{

    public class Student(string _FName, string _LName, int _Age, int _Id)
    {
        public string FName { get; set; } = _FName;
        public string LName { get; set; } = _LName;
        public int Age { get; set; } = _Age;
        public int Id { get; set; } = _Id;

        public int BirthYear()
        {
            int result = 2024 - Age;
            return result;
        }

        public void greet()
        {
            Console.WriteLine("Hello student");
        }

        public override string ToString() => $"FName: {FName}    LName: {LName}   Age: {Age}   Id: {Id}";

    }


}
