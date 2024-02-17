using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
    path_to_json = "./struct.json" // Путь до json файла

    new_mark a = new new_mark("Algebra", 5);
    a.add_mark_2_json();

    }

}

class new_mark
{
    public string subject { get; set; }
    public int mark { get; set; }
    public new_mark(string subject, int mark)
    {
        this.mark = mark;
        this.subject = subject;
    }
    public string add_mark_2_json(int mark, string subject, new_mark a)
    {
        string json = JsonSerializer.Serialize(a.subject, a.mark);
        return json;
    }
}
