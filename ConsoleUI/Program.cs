using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
        List<Person> people = ListManager.LoadSampleData();
            // Ordering
            //people = people.OrderBy(x => x.LastName).ThenByDescending(x => x.YearsExperience).ToList();

            //Filtering
            //people = people.Where(x => x.YearsExperience > 5 && x.Birthday.Month == 3).ToList();

            //foreach (var person in people)
            //{
            //  Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            //}

            // Calculations based on data

            // Summing across db
            //int yearsTotal = people.Sum(x => x.YearsExperience);
            int yearsTotal = 0;
            yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);



            Console.WriteLine($"Total experience is {yearsTotal}");

      Console.ReadLine();
    }
  }
}
