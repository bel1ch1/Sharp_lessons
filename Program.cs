using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Web.Helpers;

class Program
{
    static void Main (string[] args){
        int K = 2;
        List<string> A = new List<string> { "ABC123", "DEF456", "GHI789", "JKL10", "MNO11", "PQR12" };

        List<string> seq1 = A.Take(3 * K).ToList();

        // Находим второй фрагмент (элементы после последнего элемента, оканчивающегося цифрой)
        List<string> seq2 = A.SkipWhile(s => !char.IsDigit(s.Last())).Skip(1).ToList();

        // Получаем пересечение двух фрагментов
        IEnumerable<string> intersection = seq1.Intersect(seq2).Distinct();

        // Сортируем пересечение по длине строк, затем по возрастанию
        List<string> sort = intersection.OrderBy(s => s.Length).ThenBy(s => s).ToList();

        // Выводим результат
        foreach (string str in sort)
            Console.WriteLine(str);
        }
}
