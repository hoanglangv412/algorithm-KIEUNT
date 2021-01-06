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
        static List<Product> lstProd = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1}
        };
        static List<Product> FindProductByCategoryId(List<Product> lstProd, int categoryId){
            int i=0;
            List<Product> lstProdFound = new List<Product>();
            while(i<lstProd.Count){
                if(lstProd[i].categoryId == categoryId){
                    lstProdFound.Add(lstProd[i]);
                }
                i++; //chỗ này phải có i để thoát vòng while chứ chú
            }
            return lstProdFound;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert categoryId: ");
            int name = Int32.Parse(Console.ReadLine());
            List<Product> lst = FindProductByCategoryId(lstProd,name);
            if(lst.Count > 0){
                foreach (Product item in lst)
                {
                    Console.WriteLine("Name: " + item.name +" Price: "+ item.price +" quality: "+ item.categoryId +" categoryId: "+ item.quality);
                }
            }
            else if(lst.Count == 0){
                Console.WriteLine("not found");
            }
        }
    }
}
