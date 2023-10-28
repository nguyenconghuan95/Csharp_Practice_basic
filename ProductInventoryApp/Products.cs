using System;
using System.Collections.Generic;

namespace Products
{
    public class Product
    {
        //Properties
        public string name { get; set; }
        public string ID { get; private set; }
        public float price { get; set; }
        public int stock { get; set; }

        public static int productCount = 0;

        private static List<Product> ProductRecord = new List<Product>() {
            new Product("Silk", 10.2F, 100),
            new Product("Bread", 16.2F, 110)
        };

        //Constructor
        public Product(string _name, float _price, int _stock)
        {
            this.name = _name;
            this.price = _price;
            this.stock = _stock;
            this.ID = this.name[0] + productCount.ToString();
            productCount++;
        }

        public static void Rename(string _id, string newName)
        {
            bool match = false;
            foreach (Product p in ProductRecord)
            {
                if (p.ID == _id)
                {
                    Console.WriteLine($"Change the product ID={_id} name {p.name} with new name {newName}.");
                    p.name = newName;
                    p.ID = p.name[0] + p.ID.Substring(1); //Change ID corresponding to the new name
                    match = true;
                }
            }
            if (!match) Console.WriteLine($"Can't find the product with ID={_id}");
        }

        public static void AddProduct(string name, float price, int stock)
        {
            Product p = new Product(name, price, stock);
            ProductRecord.Add(p);
        }

        public static void ListAllProduct()
        {
            foreach (Product p in ProductRecord)
            {
                Console.WriteLine($"Name={p.name,-7} -- ID={p.ID} -- Stock={p.stock}");
            }
        }

        public static void Sum()
        {
            int stock = 0;
            foreach (Product p in ProductRecord)
            {
                stock += p.stock;
            }
            Console.WriteLine($"Our storage currently has {stock} products.");
        }
    }
}