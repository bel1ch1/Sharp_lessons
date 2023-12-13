# CopyBook №5

## struct of sequences

```c#
public struct A
        {
            public int ID { get; set; }
            public int Year_Of_Birth { get; set; }
            public string Street { get; set; }
        }

public struct B
        {
            public int Vendor_Code { get; set; }
            public string Category { get; set; }
            public string Country { get; set; }
        }

public struct C
        {
            public int ID{ get; set; }
            public int Shop_ID { get; set; }
            public int discount { get; set; }
        }

public struct D
        {
            public int Vendor_Code{ get; set; }
            public int Shop_ID{ get; set; }
            public int price { get; set; }
        }

public struct E
        {
            public int ID{ get; set; }
            public int Vendor_Code { get; set;}
            public int Shop_ID { get; set; }
        }
```

## 5.1

Даны последовательности A и C. Для каждого магазина определить потребителей, имеющих
максимальную скидку в этом магазине (вначале выводится название магазина, затем код потребителя, его год
рождения и значение максимальной скидки). Если для некоторого магазина имеется несколько потребителей
с максимальной скидкой, то вывести данные о потребителе с минимальным кодом. Сведения о каждом
магазине выводить на новой строке и упорядочивать по названиям магазинов в алфавитном порядке.

```c#
static void Main(string[] args)
    {
        List<A> users = new List<A>{
            new A { ID = 1, Year_Of_Birth = 2000, Street = "a" },
            new A { ID = 2, Year_Of_Birth = 2001, Street = "b" },
            new A { ID = 3, Year_Of_Birth = 2002, Street = "c" }
         };

        List<C> discounts = new List<C>{
            new C { ID = 1, Shop_ID = 1, discount = 10},
            new C { ID = 2, Shop_ID = 1, discount = 5},
            new C { ID = 3, Shop_ID = 1, discount = 2}
        };

        var result = discounts.GroupBy(
                        itemC => itemC.Shop_ID
                    ).Select(
                        groupC_by_shop_ID => groupC_by_shop_ID.MaxBy(
                            itemC => Tuple.Create(itemC.discount, itemC.ID)
                    )
                    ).OrderBy(itemC => itemC.Shop_ID).
                    Select(
                        itemC => $"{ itemC.Shop_ID
                                 }\t{ itemC.ID
                                 }\t{ users.FirstOrDefault(
                                        itemA => itemA.ID == itemC.ID
                                    , new A()).Year_Of_Birth
                                 }\t{ itemC.discount}"
                    );

                    foreach(var value in result)
                        Console.WriteLine(value);

    }
```
