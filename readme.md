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
    var selectionKey = numbers.Where(p => p % 10 == K);
    // выводим в консоль
    foreach (var item in selectionKey)
        Console.WriteLine(item);
```
