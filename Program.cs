using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Collections.Generic;
// using System.Web.Helpers;

class Program
{

     public struct Student
        {
            public int SchoolNumber { get; set; }
            public int AdmissionYear { get; set; }
            public string LastName { get; set; }
        }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { SchoolNumber = 1, AdmissionYear = 2020, LastName = "Smith" },
            new Student { SchoolNumber = 2, AdmissionYear = 2020, LastName = "Johnson" },
            new Student { SchoolNumber = 1, AdmissionYear = 2021, LastName = "Williams" },
            new Student { SchoolNumber = 3, AdmissionYear = 2021, LastName = "Jones" },
            new Student { SchoolNumber = 1, AdmissionYear = 2021, LastName = "Shelma"}
        };

        var yearGroups = students.GroupBy(s => s.AdmissionYear)
                                 .Select(group => new
                                 {
                                     Year = group.Key,
                                     TotalStudents = group.Count()
                                 })
                                 .OrderBy(group => group.Year);

        var maxYear = yearGroups.MaxBy(group => group.TotalStudents);
        var minYear = yearGroups.MinBy(group => group.TotalStudents);

        Console.WriteLine($"MAX: {maxYear}");
        Console.WriteLine($"MIN: {minYear}");
        }
}
