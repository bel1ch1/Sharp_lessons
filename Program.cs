using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Collections.Generic;
// using System.Web.Helpers;

class Program
{

     public struct User
        {
            public int ID { get; set; }
            public int Year { get; set; }
            public int Month_Number { get; set; }
            public int Duration_of_Classes_h { get; set; }
        }

    static void Main(string[] args)
    {
         List<User> students = new List<User>
        {
            new User { ID = 1, Year = 2020, Month_Number = 1, Duration_of_Classes_h = 14 },
            new User { ID = 1, Year = 2020, Month_Number = 2, Duration_of_Classes_h = 7 },
            new User { ID = 1, Year = 2020, Month_Number = 3, Duration_of_Classes_h = 10 },

            new User { ID = 1, Year = 2021, Month_Number = 1, Duration_of_Classes_h = 13 },
            new User { ID = 1, Year = 2021, Month_Number = 2, Duration_of_Classes_h = 0 },
            new User { ID = 1, Year = 2021, Month_Number = 3, Duration_of_Classes_h = 10 }
        };

        var min_Months = students.GroupBy(s => s.Year)
                        .Select(g => new
                        {
                          Year = g.Key,
                          Min_Months = g.OrderBy(p => p.Duration_of_Classes_h).First().Month_Number
                        })
                        .OrderBy(gr => gr.Year);

        foreach(var i in min_Months)
            Console.WriteLine($"Год: {i.Year}, Месяц с минимальным количеством часов: {i.Min_Months}");

    }
}
