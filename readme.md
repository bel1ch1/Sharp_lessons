## 1

Даны последовательности A и C. Для каждого магазина определить потребителей, имеющих
максимальную скидку в этом магазине (вначале выводится название магазина, затем код потребителя, его год рождения и значение максимальной скидки). Если для некоторого магазина имеется несколько потребителей с максимальной скидкой, то вывести данные о потребителе с минимальным кодом. Сведения о каждом магазине выводить на новой строке и упорядочивать по названиям магазинов в алфавитном порядке.

```c#
   string[,,] A = new string [,,] // Последовательность А
        {
            {"1", "2", "3"},
            {"1999", "2000", "2004"},
            {"Pervaya_ST", "VtorayaST", "Tretay_ST"}
        };
 ```