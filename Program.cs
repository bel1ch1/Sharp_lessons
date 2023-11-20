using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Sharp_lessons.models;

class Sequences
{
    public string[,] A = new string [3,3]
        {
            {"1", "2", "3"},
            {"1999", "2000", "2004"},
            {"Pervaya_ST", "VtorayaST", "Tretay_ST"}
        };
    public string[,] B = new string [3,3]
        {
            {"AXW-77", "BPX-97", "RGX-88"},
            {"Table", "Chair", "Bed"},
            {"RUS", "GER", "TUR"}
        };
    public string[,] C = new string [3,3]
        {
            {"1", "2", "3"},
            {"Shop1", "Shop2", "Shop3"},
            {"10", "5", "0"}
        };
    public string[,] D = new string [3,3]
        {
            {"AXW-77", "BPX-97", "RGX-88"},
            {"Shop1", "Shop2", "Shop3"},
            {"7000", "4000", "10000"}
        };
    public string[,] E = new string [3,3]
        {
            {"1", "2", "3"},
            {"AXW-77", "BPX-97", "RGX-88"},
            {"Shop1", "Shop2", "Shop3"}
        };
    };

class Program
{
    static void Main(string[] args)
    {
    string[] numbers = new string[]{"11", "22", "33", "1", "2", "3"};
    int K = 3;
var result = numbers.LastOrDefault(p => p.Length == K && Char.IsDigit(p.FirstOrDefault()));

    }
}
