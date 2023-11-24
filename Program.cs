using System;
using System.Security.Cryptography;
using System.Xml.Schema;



class Program
{
    static void Main(string[] args)
    {
        int K = 6;
        int[] A = new int[]{1, 2, 3, 4, 5 ,6, 7, 8, 9};

        var difference = A.Take(K -1).Where(p=> p % 2 == 0);

        foreach(int i in difference)
            Console.WriteLine(i);
    }
}
