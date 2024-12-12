using System.Collections;
using System.Diagnostics;
using System.Linq;
namespace tryyy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People men = new();
            men.SetPeopleList
            ([
                new() { Id = 1, Name = "Abdo A.", Gender = "M", Sales = 1000 },
                new() { Id = 2, Name = "Sasa B.", Gender = "M", Sales = 2000 },
                new() { Id = 3, Name = "Obad C.", Gender = "M", Sales = 3000 },
                new() { Id = 4, Name = "Ziad D.", Gender = "M", Sales = 4000 },
                new() { Id = 5, Name = "Alaa E.", Gender = "M", Sales = 5000 },
                new() { Id = 6, Name = "Omar F.", Gender = "M", Sales = 6000 },
                new() { Id = 7, Name = "4amy G.", Gender = "M", Sales = 7000 },
                new() { Id = 8, Name = "Samy H.", Gender = "M", Sales = 8000 },
                new() { Id = 9, Name = "Ramy I.", Gender = "M", Sales = 9000 }
            ]);
            Report.View(men, "-----Here are all the men in our commnity------", m => true);

            People women = new();
            women.SetPeopleList
            ([
                new() { Id = 1, Name = "Lama A.", Gender = "F", Sales = 1000 },
                new() { Id = 2, Name = "Sara B.", Gender = "F", Sales = 2000 },
                new() { Id = 3, Name = "Rana C.", Gender = "F", Sales = 3000 },
                new() { Id = 4, Name = "Hala D.", Gender = "F", Sales = 4000 },
                new() { Id = 5, Name = "Remy E.", Gender = "F", Sales = 5000 },
                new() { Id = 6, Name = "Saly F.", Gender = "F", Sales = 6000 },
                new() { Id = 7, Name = "Hana G.", Gender = "F", Sales = 7000 },
                new() { Id = 8, Name = "Alaa H.", Gender = "F", Sales = 8000 },
                new() { Id = 9, Name = "Sama I.", Gender = "F", Sales = 9000 }
            ]);
            Report.View(women, "----Here are all the women in our commnity-----",w => true);

            People employees = new();
            employees.SetPeopleList
            ([
                new() { Id = 1, Name = "Lama A.", Gender = "F", Sales = 1000 },
                new() { Id = 2, Name = "Sasa B.", Gender = "M", Sales = 2000 },
                new() { Id = 3, Name = "Obad C.", Gender = "M", Sales = 3000 },
                new() { Id = 4, Name = "Hala D.", Gender = "F", Sales = 4000 },
                new() { Id = 5, Name = "Alaa E.", Gender = "M", Sales = 5000 },
                new() { Id = 6, Name = "Omar F.", Gender = "M", Sales = 6000 },
                new() { Id = 7, Name = "Hana G.", Gender = "F", Sales = 7000 },
                new() { Id = 8, Name = "Alaa H.", Gender = "F", Sales = 8000 },
                new() { Id = 9, Name = "Ramy I.", Gender = "M", Sales = 9000 }
            ]);
            Report.View(employees, "---Here are all the employees in our commnity--", e => true);

            Console.WriteLine(men[1] + "\n" + women[1]+"\n"+ employees[1] +"\n\n");

            Report.View(employees, "-----------Employees with sales < 3000---------", e => e.Sales < 3000);
            Report.View(employees, "------Employees with 6000 >= sales >= 3000-----", e => e.Sales >= 3000 && e.Sales <= 6000);
            Report.View(employees, "-----------Employees with sales > 6000---------", e => e.Sales > 6000);

            Console.ReadKey();
        } 
    }
}
