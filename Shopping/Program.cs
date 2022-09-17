using System;
using System.Collections.Generic;

namespace Shopping
{
    public class Product
    {
        public string Name;
        public decimal Price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Price}");
        }

    }

    public class Store
    {
        public List<Product> products;
        
        public Store()
        {
            products = new List<Product>()
            {
                new Product("Milch",20),
                new Product("Kaffee",30),
                new Product("Wurst",40),
                new Product("Brot",50),
                new Product("Brötchen",60),
                new Product("Eier",40)
            };
        }

        public void ShowCatalog()
        {
            foreach (Product product in products)
            {
                product.Print();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entscheiden sie welche ausgabe sie wollen!!");
            Console.WriteLine("1. Zeige Katalog Produkte?");
            Console.WriteLine("Entscheiden sie nach Nummer, welche Auswahl sie Treffen wollen!!");
            Console.WriteLine();
        }
    }
}