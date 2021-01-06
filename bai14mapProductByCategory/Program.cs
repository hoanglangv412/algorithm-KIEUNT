using System;
using System.Collections.Generic;

namespace bai14mapProductByCategory
{
    class Product{
        public string name;
        public int price;
        public int quality;
        public int categoryId;
    }

    class Category{
        public int categoryId;
        public string categoryName;
    }

    class Program
    {
        static List<Product> mapProductByCategory(List<Product> listProduct,List<Category> listCategory){
            List<Product> lstprod = new List<Product>();
            for(int i=0;i<listProduct.Count;i++){
                for(int j=0;j<listCategory.Count;j++){
                    if(listProduct[i].categoryId == listCategory[j].categoryId){
                        Product newProd = new Product();
                        newProd.name = listProduct[i].name + " - CategoryName: " + listCategory[j].categoryName;
                        newProd.price = listProduct[i].price;
                        newProd.quality = listProduct[i].quality;
                        newProd.categoryId = listProduct[i].categoryId;
                        lstprod.Add(newProd);
                    }
                }
            }
            return lstprod;
        }
        
        static void Main(string[] args)
        {
             List<Product> listProduct = new List<Product>(){
            new Product(){name="CPU",price=750,quality=10,categoryId=1},
            new Product(){name="RAM",price=50,quality=50,categoryId=2},
            new Product(){name="HDD",price=70,quality=70,categoryId=2},
            new Product(){name="MAIN",price=400,quality=400,categoryId=1},
            new Product(){name = "Keyboard", price=30, quality=8, categoryId=4},		
            new Product(){name = "Mouse", price= 25, quality= 50, categoryId= 4},		
            new Product(){name = "VGA", price= 60, quality= 35, categoryId= 3},	
            new Product(){name = "Monitor", price= 120, quality= 28, categoryId= 2},		
            new Product(){name = "Case", price= 120, quality= 28, categoryId= 5},
            };
            List<Category> listCategory = new List<Category>(){
            new Category(){categoryId=1,categoryName="Computer"},
            new Category(){categoryId=2,categoryName="Memory"},
            new Category(){categoryId=3,categoryName="Card"},
            new Category(){categoryId=4,categoryName="Accesory"}
            };
            
            foreach (Product prod in mapProductByCategory(listProduct,listCategory))
            {
                Console.WriteLine("Product name: " + prod.name + " - Categoryid: " +prod.categoryId);
            }
        }
    }
}

