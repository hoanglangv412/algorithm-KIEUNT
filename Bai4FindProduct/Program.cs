using System;
using System.Collections.Generic;

namespace Bai4FindProduct
{
    class Product{
        public string name;
        public int price;
        public int quality;
        public int categoryId;
    }
    class Program
    {
        static List<Product> lstProd = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1}
        };
        static Product findProduct(List<Product> lstProd,String prodName){
            for (int i=0;i<lstProd.Count;i++)
            {
                if(lstProd[i].name == prodName){
                    return lstProd[i];
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert name of the product : ");
            String name = Console.ReadLine();
            Product pr = findProduct(lstProd,name);
            if(pr == null){
                Console.WriteLine("cant find product ");
            }
            else
                Console.WriteLine("Name: " + pr.name +" Price: "+ pr.price +" quality: "+ pr.categoryId +" categoryId: "+ pr.quality);
        }
    }
}
