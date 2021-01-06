using System;
using System.Collections.Generic;

namespace bai12SortByName
{
    class Product{
        public string name;
        public int price;
        public int quality;
        public int categoryId;
    }

    class Program
    {
        static void sortByName(List<Product> listProduct){
            for(int i=1;i<listProduct.Count;i++){
                Product key = listProduct[i];
                int j = i-1;

                while(j>=0 && listProduct[j].name.Length<key.name.Length){
                    listProduct[j+1] = listProduct[j];
                    j--; 
                }
                listProduct[j+1] = key;
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
            sortByName(listProduct);
            foreach (Product prodItem in listProduct)
            {
                Console.WriteLine("Sorted List through product's name length: Name: " + prodItem.name +" Price: "+ prodItem.price);
            }
           
        }
    }
}
