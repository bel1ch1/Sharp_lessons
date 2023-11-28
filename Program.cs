using System;
using System.Security.Cryptography;
using System.Xml.Schema;



class Program
{
    static void Main(string[] args)
    {
        int K = 9;
        string[] A = {
            "ABC12A",
            "DE4FGH",
            "5678",
            "H5IJKL",
            "M5NOP",
            "Q35RST"
        };

        var seq1 = A.Select(val => String.Join("", val.Take(K).ToList())); // выбираем все элементы из строк до К
        var seq2 = A.SkipWhile(char.IsDigit); // выбираем все элементы после последней цыфры

        var result = seq1.Intersect(seq2);

        foreach(string i in result)
            Console.WriteLine(i);
    }
}
