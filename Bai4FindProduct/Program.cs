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
        static List<Product> lst = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1}
        };
        static Product findProduct(List<Product> A,String nameProduct){
            for (int i=0;i<A.Count;i++)
            {
                if(A[i].name == nameProduct){
                    Product a = new Product();
                    a.name = A[i].name;
                    a.price = A[i].price;
                    a.categoryId = A[i].categoryId;
                    a.quality = A[i].quality;
                    return a;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            string ten;
            Console.WriteLine("Nhập tên: ");
            ten = Console.ReadLine();
            Product pr = findProduct(lst,ten);
            if(pr == null){
                Console.WriteLine("cant find");
            }
            else
                Console.WriteLine("Name: " + pr.name +" Price: "+ pr.price +" quality: "+ pr.categoryId +" categoryId: "+ pr.quality);
        }
    }
}
