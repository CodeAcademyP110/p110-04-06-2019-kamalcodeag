using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Market
    {
        private static List<Product> products = new List<Product>();
        private static List<Category> categories = new List<Category>()
        {
            new Category("içki"),
            new Category("ərzaq"),
            new Category("şirniyyat"),
            new Category("meyvə"),
            new Category("geyim")
        };

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }
        public static List<Product> GetProduct()
        {
            return products;
        }
        public static void RemoveProduct(string product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].Ad == product)
                {
                    products.RemoveAt(i);
                }
            }
            return;
        }


        
        public static List<Category> GetCategory()
        {
            return categories;
        }
    }
}
