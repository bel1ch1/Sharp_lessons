# CopyBook №4

## 4.1

Дана целочисленная последовательность, содержащая как положительные,
так и отрицательные числа. Вывести ее первый положительный элемент и
последний отрицательный элемент

```c#
// последовательность
int[] numbers = new int[]{-1, -2, -3, 1, 2, 3};

// первый запросс
var one = from p in numbers where p > 0 select p;

// второй запросс
var two = from k in numbers where k < 0 select k;

// консольный вывод с использованием методов First и Last
Console.WriteLine(one.First());
Console.WriteLine(two.Last());
```

## 4.2

Даны цифра D (однозначное целое число) и целочисленная последовательность
A. Вывести первый положительный элемент последовательности A оканчивающийся цифрой D. Если требуемых элементов в последовательности A нет, то вывести 0

```c#
    // массив целых чисел
    int[] numbers = {11, 22, 33, 1, 2, 3};

    // задаем переменную
    int K = 3;

    // применяем запросс
    var selectionKey = numbers.FirstOrDefault(p => p % 10 == K, 0);

    // вывод запроса в консоль
    Console.WriteLine(selectionKey);
```

## 4.3

Даны целое число L (> 0) и строковая последовательность A. Вывести
последнюю строку из A, начинающуюся с цифры и имеющую длину L. Если требуемых
строк в последовательности A нет, то вывести строку «Not found»

```c#
    // массив строк
    string[] A = new string[]{"f11", "f22", "f33", "1kf", "fk2", "3kf"};

    // задаем переменную
    int L = 3;

    // применяем запросс
    var output = A.LastOrDefault(
        value => char.IsDigit(value[0]) && value.Length == L, "Not found");

    // вывод запроса в консоль
    Console.WriteLine(output);
```

## 4.4

Даны целое число D и целочисленная последовательность A. Начиная с первого
элемента A, большего D, извлечь из A все нечетные положительные числа, поменяв порядок
извлеченных чисел на обратный.

```c#
    // массив целых чисел
    int[] A = new int[]{1, 2, 3, 4, 5 ,6, 7, 8, 9};

    // Задаем переменную
    int D = 3;

    // применяем запросс
    // SkipWhile оставляет в массиве только значения проходящие проверку
    var arr = A.SkipWhile(
                value => value < D
            ).Where(
                value => value % 2 != 0
            ).Reverse();

        // вывод запроса в консоль
        foreach(var i in arr)
            Console.WriteLine(i);
```

## 4.5

Дано целое число K (> 0) и строковая последовательность A. Из элементов A,
предшествующих элементу с порядковым номером K, извлечь те строки, которые имеют
нечетную длину и начинаются с заглавной латинской буквы, изменив порядок следования
извлеченных строк на обратный.

```c#

    int K = 5;


    string[] A = {"Aaaaa","Bbbbbb", "aaaaa", "Ccccc", "Ddddd"};

        // Take k -1 возвращает срез массива
    var output = A.Take(K - 1).Where(
         value => char.IsUpper(value[0])
          && value.Length % 2 != 0
          ).Reverse();

    // вывод запроса в консоль
    foreach(var i in output)
        Console.WriteLine(i);
```

## 4.6

Даны целые числа D и K (K > 0) и целочисленная последовательность A. Найти
теоретико-множественное объединение двух фрагментов A: первый содержит все элементы
до первого элемента, большего D (не включая его), а второй – все элементы, начиная с
элемента с порядковым номером K. Полученную последовательность (не содержащую
одинаковых элементов) отсортировать по убыванию.

```c#

    int D = 3;


    int K = 6;


    int[] A = new int[]{1, 2, 3, 4, 5 ,6, 7, 8, 9};

    // создаем копию А без дубликатов
    int[] Q = A.Distinct().ToArray();

    var query1 = Q.TakeWhile(p=> p < D);  // берем все числа до 3 не включительно
    var query2 = Q.SkipWhile(p=> p < K);  // берем все числа больште 6 включительно

    var query3 = query1.Union(query2);  // объединяем последоватеольности 2 запросов

    // вывод запроса в консоль
    foreach(int i in query3)
        Console.WriteLine(i);
```

## 4.7

Даны целое число K (> 0) и целочисленная последовательность A. Найти
теоретико-множественную разность двух фрагментов A: первый содержит все четные
числа, а второй – все числа с порядковыми номерами, большими K. В полученной
последовательности (не содержащей одинаковых элементов) поменять порядок элементов
на обратный.

```c#
// необходимо вывести все четные числа до К не включая К
    int K = 6;
    int[] A = new int[]{1, 2, 3, 4, 5 ,6, 7, 8, 9};

    var difference = A.Take(K -1).Where(p=> p % 2 == 0);

    // вывод запроса в консоль
    foreach(int i in difference)
        Console.WriteLine(i);
```

## 4.8

Даны целое число K (> 0) и последовательность непустых строк A. Строки
последовательности содержат только цифры и заглавные буквы латинского алфавита.
Найти теоретико-множественное пересечение двух фрагментов A: первый содержит 3K
начальных элементов, а второй – все элементы, расположенные после последнего элемента,
оканчивающегося цифрой. Полученную последовательность (не содержащую одинаковых
элементов) отсортировать по возрастанию длин строк, а строки одинаковой длины – в
лексикографическом порядке по возрастанию.

```c#
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
```

## 4.9

Исходная последовательность содержит сведения об абитуриентах. Каждый
элемент последовательности включает следующие поля:
<Номер школы> <Год поступления> <Фамилия>
Для каждого года, присутствующего в исходных данных, вывести число различных школ,
которые окончили абитуриенты, поступившие в этом году (вначале указывать число школ,
затем год). Сведения о каждом годе выводить на новой строке и упорядочивать по
возрастанию числа школ, а для совпадающих чисел — по возрастанию номера года.

```c#
    public struct Student
        {
            public int SchoolNumber { get; set; }
            public int AdmissionYear { get; set; }
            public string LastName { get; set; }
        }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { SchoolNumber = 1, AdmissionYear = 2020, LastName = "Smith" },
            new Student { SchoolNumber = 2, AdmissionYear = 2020, LastName = "Johnson" },
            new Student { SchoolNumber = 1, AdmissionYear = 2021, LastName = "Williams" },
            new Student { SchoolNumber = 3, AdmissionYear = 2021, LastName = "Jones" },
        };


        var result = from student in students
                     group student.SchoolNumber by student.AdmissionYear into grouped
                     orderby grouped.Count(), grouped.Key
                     select new { Year = grouped.Key, SchoolCount = grouped.Distinct().Count() };

        // вывод запроса в консоль
        foreach(var i in result)
            Console.WriteLine(i);
    }
```

## 4.10

Из последовательности (см. п.9) определить, в какие годы общее число
абитуриентов для всех школ было наибольшим и наименьшим, и вывести это число, а также
годы, в которые оно было достигнуто (годы упорядочивать по возрастанию, каждое число
выводить на новой строке).

```c#
class Program
{

     public struct Student
        {
            public int SchoolNumber { get; set; }
            public int AdmissionYear { get; set; }
            public string LastName { get; set; }
        }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { SchoolNumber = 1, AdmissionYear = 2020, LastName = "Smith" },
            new Student { SchoolNumber = 2, AdmissionYear = 2020, LastName = "Johnson" },
            new Student { SchoolNumber = 1, AdmissionYear = 2021, LastName = "Williams" },
            new Student { SchoolNumber = 3, AdmissionYear = 2021, LastName = "Jones" },
            new Student { SchoolNumber = 1, AdmissionYear = 2021, LastName = "Shelma"}
        };

        var yearGroups = students.GroupBy(s => s.AdmissionYear)
                                 .Select(group => new
                                 {
                                     Year = group.Key,
                                     TotalStudents = group.Count()
                                 })
                                 .OrderBy(group => group.Year);

        var maxYear = yearGroups.MaxBy(group => group.TotalStudents);
        var minYear = yearGroups.MinBy(group => group.TotalStudents);

        // вывод запроса в консоль
        Console.WriteLine($"MAX: {maxYear}");
        Console.WriteLine($"MIN: {minYear}");
        }
}
```

## 4.11

Исходная последовательность содержит сведения о клиентах этого фитнес-центра. Каждый элемент
последовательности включает следующие целочисленные поля:

<Код клиента> <Год> <Номер месяца>
<Продолжительность занятий (в часах)>

Для каждого года, в котором клиент с кодом K посещал центр, определить месяц, в
котором продолжительность занятий данного клиента была наименьшей для данного года
(если таких месяцев несколько, то выбирать первый из этих месяцев в исходном наборе;
месяцы с нулевой продолжительностью занятий не учитывать). Сведения о каждом годе
выводить на новой строке в следующем порядке: наименьшая продолжительность занятий,
год, номер месяца. Упорядочивать сведения по возрастанию продолжительности занятий, а
при равной продолжительности – по возрастанию номера года. Если данные о клиенте с
кодом K отсутствуют, то записать в результирующий файл строку «Нет данных».

```c#
// структура храненния данных для списка
public struct User
        {
            public int ID { get; set; }
            public int Year { get; set; }
            public int Month_Number { get; set; }
            public int Duration_of_Classes_h { get; set; }
        }

    static void Main(string[] args)
    {
        // делаем список поссещений
         List<User> students = new List<User>
        {
            new User { ID = 1, Year = 2020, Month_Number = 1, Duration_of_Classes_h = 14 },
            new User { ID = 1, Year = 2020, Month_Number = 2, Duration_of_Classes_h = 7 },
            new User { ID = 1, Year = 2020, Month_Number = 3, Duration_of_Classes_h = 10 },

            new User { ID = 1, Year = 2021, Month_Number = 1, Duration_of_Classes_h = 13 },
            new User { ID = 1, Year = 2021, Month_Number = 2, Duration_of_Classes_h = 0 },
            new User { ID = 1, Year = 2021, Month_Number = 3, Duration_of_Classes_h = 10 }
        };
        // запрос сортирует клиента по годам и выбирает год с наихудшей поссещаемостью
        var min_Months = students.GroupBy(s => s.Year)
                        .Select(g => new
                        {
                          Year = g.Key,
                          Min_Months = g.OrderBy(p => p.Duration_of_Classes_h).First().Month_Number
                        })
                        .OrderBy(gr => gr.Year);
        // вывод запроса в консоль
        foreach(var i in min_Months)
            Console.WriteLine($"Год: {i.Year}, Месяц с худшей поссещаемтостью: {i.Min_Months}");

    }
```
