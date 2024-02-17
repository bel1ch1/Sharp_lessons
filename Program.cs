using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (FileStream fs = new FileStream("struct.json", FileMode.OpenOrCreate))
        {
            New_mark a = new New_mark(1, 2, 4);
            await JsonSerializer.Serialization<New_mark>(fs, a);
            Console.WriteLine("Data has been saved to file");
        }

    }


}
