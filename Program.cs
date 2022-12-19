using System;
using System.Collections.Generic;

namespace svu
{
    class Program
    {
        static void Main(string[] args)
        {
            Product_Type pt1 = new Product_Type();
            pt1.TypeName = "type1";
            pt1.TypeId = 1;
            Product_Type pt2 = new Product_Type();
            pt2.TypeName = "type2";
            pt2.TypeId = 1;
            Product_Type pt3 = new Product_Type();
            pt3.TypeName = "type3";
            pt3.TypeId = 1;
            List<Product_Type> types = new List<Product_Type>();
            types.Add(pt1);
            types.Add(pt2);
            types.Add(pt3);
            Product p = new Product();
            p.ProductId = 1;
            p.ProductName = "p1";
            p.ProductPrice = 300;
            p.TypeId = pt1.TypeId;
            Console.WriteLine(types.Find(x => x.TypeId == p.TypeId).TypeName);
        }
    }
}
