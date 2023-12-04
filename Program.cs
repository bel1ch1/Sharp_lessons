﻿using System;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int K = 2;
        List<string> A = new List<string>()
 {
     "ABC123",
     "DEF456",
     "XYZ12",
     "LMN34",
     "PQR5",
     "STU",
     "VW6"
 };

    var seq1 = A.Take(K * 3); // выбираем все элементы из строк до К * 3

    var seq2 = A.Select(p => p).Where(char.IsDigit())

    var result = seq1.Intersect(seq2);    // Пересечение двух последовательностей

    foreach(string i in result)
        Console.WriteLine(i);

    }
}
