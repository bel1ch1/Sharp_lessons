using System;
using System.Security.Cryptography;
using System.Xml.Schema;



class Program
{
    static void Main(string[] args)
    {
        int D = 3;
        int K = 6;
        int[] A = new int[]{1, 2, 3, 4, 5 ,6, 7, 8, 9};
        int[] Q = A.Distinct().ToArray(); // создаем копию А без дубликатов

        var query1 = Q.TakeWhile(p=> p < D);  // берем все числа до 3 не включительно
        var query2 = Q.SkipWhile(p=> p < K);  // берем все числа больште 6 включительно

        var query3 = query1.Union(query2);  // объединяем последоватеольности 2 запросов

        foreach(int i in query3)
            Console.WriteLine(i);
    }
}
