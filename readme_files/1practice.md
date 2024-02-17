# practice 1
Structures and Classes [Тут](/models/Currency.cs)
## 1. Разработать единую структуру JSON-файла для хранения исходных данных

json structure:
```json
{
    "student":[
        {
            "id_stud":"int",
            "name_stud":"string",
            "sure_name":"string",
            "sure_name2":"string"
        }
    ],
   "subject":[
            {
                "id_subj":"int",
                "name_subj":"string",
                "volume_of_lectures":"int",
                "volume_of_practise":"int"
            }
        ],
        "lessons_plane":[
            {
                "id_stud":"int",
                "id_subj":"int",
                "grade":"int"
            }
        ]
}
```

---

## 2. Разработать возможность добавления новой оценки для студента

```c#
using (FileStream fs = new FileStream("struct.json", FileMode.OpenOrCreate))
        {
            New_mark a = new New_mark(1, 2, 4);
            await JsonSerializer.Serialization<New_mark>(fs, a);
            Console.WriteLine("Data has been saved to file");
        }
```

---

## 3. Создать LINQ-запрос, который будет формировать список дисциплин с оценкой для необходимого студента. При выводе также необходимо указать процент оценок «отлично», «хорошо» и «удовлетворительно» от общего количества.

```c#

```
