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
}
