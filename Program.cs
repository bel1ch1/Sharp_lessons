using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Collections.Generic;
using Sharp_lessons.models;
using System.Net.Security;
// using System.Web.Helpers;

class Program
{


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
}
