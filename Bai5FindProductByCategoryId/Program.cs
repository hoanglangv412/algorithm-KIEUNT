using System;
using System.Collections.Generic;

namespace Bai5FindProductByCategoryId
{
    class Program
    {
        class Product{
            public string name;
            public int price;
            public int quality;
            public int categoryId;
        }
        static List<Product> A = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1}
        };
        static List<Product> FindProductByCategoryId(List<Product> A, int id){
            int i=0;
            List<Product> lst = new List<Product>();
            while(i<A.Count){
                if(A[i].categoryId == id){
                    Product a = new Product();
                    a.name = A[i].name;
                    a.price = A[i].price;
                    a.categoryId = A[i].categoryId;
                    a.quality = A[i].quality;
                    lst.Add(a);
                }
                i++;
            }
            return lst;
        }
        static void Main(string[] args)
        {
            int ten;
            Console.WriteLine("Nhập categoryId: ");
            ten = Int32.Parse(Console.ReadLine());
            List<Product> lst = FindProductByCategoryId(A,ten);
            if(lst.Count > 0){
                foreach (Product item in lst)
                {
                    Console.WriteLine("Name: " + item.name +" Price: "+ item.price +" quality: "+ item.categoryId +" categoryId: "+ item.quality);
                }
            }
            else if(lst.Count == 0){
                Console.WriteLine("Không tìm thấy");
            }
        }
    }
}
