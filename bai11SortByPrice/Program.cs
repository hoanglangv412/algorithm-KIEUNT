using System;
using System.Collections.Generic;

namespace bai11SortByPrice
{
        class Product{
            public string name;
            public int price;
            public int quality;
            public int categoryId;
        }
    class Program
    {
        static void SortByPrice(List<Product> listProduct){
            for(int i=0;i<listProduct.Count-1;i++){
                for(int j=0;j<listProduct.Count-i-1;j++){
                    if(listProduct[j].price>listProduct[j+1].price){
                        Product tempProd = listProduct[j];
                        listProduct[j] = listProduct[j+1];
                        listProduct[j+1] = tempProd;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1}
            };
            SortByPrice(listProduct);
            foreach (Product prodItem in listProduct)
            {
                Console.WriteLine("Sorted List: Name: " + prodItem.name +" Price: "+ prodItem.price);
            }
        }
    }
}
