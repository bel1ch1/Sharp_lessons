# 4NB

## Используемые модули

```c#
using System;
using System.Collections.Generic;
using System.Linq;
 ```

## 4.1

Дана целочисленная последовательность, содержащая как положительные,
так и отрицательные числа. Вывести ее первый положительный элемент и
последний отрицательный элемент

```c#
int[] numbers = new int[]{-1, -2, -3, 1, 2, 3}; // последовательность
var one = from p in numbers where p > 0 select p; // первый запросс
var two = from k in numbers where k < 0 select k; // второй запросс
    // консольный вывод с использованием методов First и Last
Console.WriteLine(one.First());
Console.WriteLine(two.Last());
```

## 4.2

Даны цифра D (однозначное целое число) и целочисленная последовательность
A. Вывести первый положительный элемент последовательности A оканчивающийся цифрой D. Если требуемых элементов в последовательности A нет, то вывести 0

```c#
int[] numbers = new int[]{11, 22, 33, 1, 2, 3};
int K = 3; // задаем переменную
    // применяем запросс
var selectionKey = numbers.FirstOrDefault(p => p % 10 == K, 0);
    Console.WriteLine(selectionKey);
```

## 4.3

Даны целое число L (> 0) и строковая последовательность A. Вывести
последнюю строку из A, начинающуюся с цифры и имеющую длину L. Если требуемых
строк в последовательности A нет, то вывести строку «Not found»

```c#
    string[] A = new string[]{"f11", "f22", "f33", "1kf", "fk2", "3kf"};
    int k = 3;

        var output = A.LastOrDefault(
            value => char.IsDigit(value[0]) && value.Length == L, "Not found");

        Console.WriteLine(output);
```

## 4.4

Даны целое число D и целочисленная последовательность A. Начиная с первого
элемента A, большего D, извлечь из A все нечетные положительные числа, поменяв порядок
извлеченных чисел на обратный.

```c#
    int[] A = new int[]{1, 2, 3, 4, 5 ,6, 7, 8, 9};
    int D = 3;

    // SkipWhile оставляет в массиве только значения проходящие проверку
    var arr = A.SkipWhile(
                value => value < D
            ).Where(
                value => value % 2 != 0
            ).Reverse();

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
    var output = A.Take(K - 1).Where( value => char.IsUpper(value[0]) && value.Length % 2 != 0).Reverse();

    foreach(var i in output)
        Console.WriteLine(i);
```
