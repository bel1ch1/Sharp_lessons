
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Xml.Schema;

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
public class A
    {
    public int[] ID = new[] {1, 2, 3};
    public int[]  Year_Of_Birth = new[] {1999, 2000, 2004};
    public string[] Street = new [] {"Pervaya_ST", "VtorayaST", "Tretay_ST"};
    };
public class B {
    public string[] Article = new[] {"AXW-77", "BPX-97", "RGX-88"};
    public string[] Category = new[] {"Table", "Chair", "Bed"};
    public string[] Country = new[] {"RUS", "GER", "TUR"};
};
public class C {
    public int[] ID = new[] {1, 2, 3};
    public string[] Shop = new[] {"Shop1", "Shop2", "Shop3"};
    public int[] Discount = new[] {10, 5, 0};
};
public class D {
    public string[] Article = new[] {"AXW-77", "BPX-97", "RGX-88"};
    public string[] Shop = new[] {"Shop1", "Shop2", "Shop3"};
    public int[] Price = new[] {7000, 4000, 10000};
};
public class E{
    public int[] ID = new[] {1, 2, 3};
    public string[] Article = new[] {"AXW-77", "BPX-97", "RGX-88"};
    public string[] Shop = new[] {"Shop1", "Shop2", "Shop3"};
};


class Program
{
    static void Main(string[] args)
    {


    }
}
