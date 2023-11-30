using System;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Collections.Generic;


class Program
{
    public struct Applicant{
        public int schoolId;
        public int admissionYear;
        public string lastName;
    }
    static void Main(string[] args)
    {
        int K = 3;
        List<string> A = new List<string> {
            "A1BC123",
            "DE5FGH",
            "5678",
            "HIJKL",
            "MNOP9",
            "QR4STU"
        };

    var seq1 = A.Select(val => String.Join("", val.Take(K).ToArray())); // выбираем все элементы из строк до К

    for (int i = 0; i < A.Count; i++)
        A[i] = new string(A[i].Reverse().ToArray()); // Переворачиваем все строки из списка

    var seq2 = A.TakeWhile(p => !p.Any(char.IsDigit));  // выбираем элементы из строки до первой цифры

    var result = seq1.Intersect(seq2);    // Пересечение двух последовательностей

    foreach(string i in result)
        Console.WriteLine();


    }
}
