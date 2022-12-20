using System;
using System.Collections.Generic;

namespace svu
{
    class Program
    {
        public static List<Product> Products;
        public static List<Product_Type> Types;
        public static List<Customer> Customers;
        
        public static void initProducts()
        {
            Products = new List<Product>();
            Product p1 = new Product();
            p1.ProductId = 1;
            p1.ProductName = "p1";
            p1.ProductPrice = 300;
            p1.TypeId = 2;
            Product p2 = new Product();
            p2.ProductId = 2;
            p2.ProductName = "p2";
            p2.ProductPrice = 300;
            p2.TypeId = Types[0].TypeId;
            Product p3 = new Product();
            p3.ProductId = 3;
            p3.ProductName = "p3";
            p3.ProductPrice = 300;
            p3.TypeId = Types[0].TypeId;
            Products.Add(p1);
            Products.Add(p2);
            Products.Add(p3);

        }
        public static void initProductTypes()
        {
            Types = new List<Product_Type>();
            Product_Type pt1 = new Product_Type();
            pt1.TypeName = "type1";
            pt1.TypeId = 1;
            Product_Type pt2 = new Product_Type();
            pt2.TypeName = "type2";
            pt2.TypeId = 2;
            Product_Type pt3 = new Product_Type();
            pt3.TypeName = "type3";
            pt3.TypeId = 3;
            Types.Add(pt1);
            Types.Add(pt2);
            Types.Add(pt3);

        }

        static void Main(string[] args)
        {
            initProductTypes();
            initProducts();
            Console.WriteLine(Types.Find(x=>x.TypeId== Products[0]?.TypeId).TypeName);
        }
    }
}
