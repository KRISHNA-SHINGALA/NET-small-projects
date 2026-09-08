using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class product
    {
        public string Name { get; set; }
        private int productId;
        public string Category { get; set; }
        private double Price;

        public void setPrice(double Price)
        {
            this.Price = Price;
        }
        public double getPrice()
        {
            return this.Price;
        }

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ProductId : " + ProductId);
            Console.WriteLine("Category : " + Category);
            Console.WriteLine("Price : " + Price);
        }
    }

    class product_class_object
    {
        public static void Main(string[] args)
        {
            product p1 = new product();

            p1.Name = "Laptop";
            p1.ProductId = 3;
            p1.Category = "Electronics";
            p1.setPrice(50000);

            p1.Display();
            Console.WriteLine();

            product p2 = new product();

            p2.Name = "Rice";
            p2.ProductId = 8;
            p2.Category = "Grocery";
            p2.setPrice(2000);

            p2.Display();
        }
    }
}
