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

## 5.2

Даны последовательности A и C. Для каждого магазина и каждой улицы определить количество
потребителей, живущих на этой улице и имеющих скидку в этом магазине (вначале выводится название
магазина, затем название улицы, затем количество потребителей со скидкой). Если для некоторой пары
«магазин–улица» потребители со скидкой не найдены, то данные об этой паре не выводятся. Сведения о
каждой паре «магазин–улица» выводить на новой строке и упорядочивать по названиям магазинов в
алфавитном порядке, а для одинаковых названий магазинов — по названиям улиц (также в алфавитном
порядке)

```c#

```

## 5.3

Даны последовательности B и D. Для каждой категории товаров определить количество магазинов,
предлагающих товары данной категории, а также количество стран, в которых произведены товары данной
категории, представленные в магазинах (вначале выводится количество магазинов, затем название категории,
затем количество стран). Если для некоторой категории не найдено ни одного товара, представленного в
каком-либо магазине, то информация о данной категории не выводится. Сведения о каждой категории выводить на новой строке и упорядочивать по убыванию количества магазинов, а в случае одинакового количества — по названиям категорий в алфавитном порядке

```c#
static void Main(string[] args)
    {
        List<B> products_info = new List<B>{
            new B { Vendor_Code = 1, Category = "a", Country = "A" },
            new B { Vendor_Code = 2, Category = "b", Country = "B"},
            new B { Vendor_Code = 3, Category = "c", Country = "C" }
         };

        List<D> prices = new List<D>{
            new D { Vendor_Code = 1, Shop_ID = 1, price = 100 },
            new D { Vendor_Code = 2, Shop_ID = 2, price = 1321 },
            new D { Vendor_Code = 3, Shop_ID = 3, price = 1000 }
        };

        var _output =
                    products_info.GroupBy(
                        itemB => itemB.Category
                    ).Select(
                        groupB_by_Category => new {

                            shop_amount=prices.GroupBy(
                                    itemD => itemD.Shop_ID
                                ).Count(
                                    groupD_by_Shop_Id => groupD_by_Shop_Id.Count(
                                        itemD => products_info.Any(
                                            itemB => itemB.Vendor_Code == itemD.Vendor_Code
                                        )
                                    ) != 0
                                ),

                            Category=(groupB_by_Category.FirstOrDefault(new B())).Category,

                            country_amount=groupB_by_Category.Count()
                        }

                    ).OrderBy(
                        _item => _item.shop_amount
                    ).ThenBy(
                        _item => _item.Category
                    ).ThenBy(
                        _item => _item.country_amount

                    ).Select(
                        _item => $"{_item.shop_amount
                                }\t{_item.Category
                                }\t{_item.country_amount
                                }"
                    );
        foreach(var _value in _output)
            Console.WriteLine(_value);
    }
```
