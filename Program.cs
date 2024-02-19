using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Sharp_lessons.models;



class Program
{
    static void Main(string[] args)
    {

        string jsonPath = "struct.json";
        string json = File.ReadAllText(jsonPath);
        Newtonsoft.Json.Linq.JObject rss = Newtonsoft.Json.Linq.JObject.Parse(json);

        Console.WriteLine("Введите имя студента:");
        string? student_name = Console.ReadLine();
        // получаем список имен
        var name = from p in rss["student"]
                    select p["name_stud"];

        if(name.Contains(student_name)){
            var student_name_id = rss["student"].FirstOrDefault(c => c.Where(rss["name_stud"] == student_name));

        }
        else
            Console.WriteLine("Студент не найден");
            return;

        // foreach (var item in name)
        //     Console.WriteLine(item);
    }
}
