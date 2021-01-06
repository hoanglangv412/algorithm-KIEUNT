using System;
using System.Collections.Generic;

namespace Bai6FindProductByPrice
{
    class Program
    {
        class Product{
            public string name;
            public int price;
            public int quality;
            public int categoryId;
        }
        static List<Product> listProduct = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1}
        };
        static List<Product> FindProductByPrice(List<Product> listProduct, int price){
            int i=0;
            List<Product> listpro = new List<Product>();
            while(i<listProduct.Count){
                if(listProduct[i].price < price){
                    listpro.Add(listProduct[i]);
                }
                i++;
            }
            return listpro;
        }
        static void Main(string[] args)
        {
            int price;
            Console.WriteLine("Nhập price: ");
            price = Int32.Parse(Console.ReadLine());
            List<Product> pro = new List<Product>();
            pro = FindProductByPrice(listProduct,price);
            if(pro.Count>0){
                foreach(Product item in pro){
                    Console.WriteLine("Name: " + item.name +" Price: "+ item.price +" quality: "+ item.categoryId +" categoryId: "+ item.quality);
                }
            }
            else
                Console.WriteLine("Không tìm thấy nè");
        }
    }
}
