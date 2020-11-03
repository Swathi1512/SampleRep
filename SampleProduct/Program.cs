using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleProduct
{
    class Product : IComparable<Product>
    {
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public int CompareTo(Product prod)
        {
            if(this.Price == prod.Price)
            {
                return this.ProductName.CompareTo(prod.ProductName);
            }
            else if(this.Price < prod.Price)
            {
                return this.Price.CompareTo(prod.Price);
            }
            else if(this.Price > prod.Price)
            {
                return this.Price.CompareTo(prod.Price);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{this.ProductId} {this.ProductName} {this.Price} {this.Rating}";
        }
    }
    class Program 
    {
        

        
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product() { ProductId = 101, ProductName = "Colgate", Price = 230, Rating = 4 });
            list.Add(new Product() { ProductId = 104, ProductName = "Close up", Price = 530, Rating = 4 });
            list.Add(new Product() { ProductId = 103, ProductName = "Pepsodent", Price = 200, Rating = 4 });
            list.Add(new Product() { ProductId = 105, ProductName = "Sensodyne", Price = 230, Rating = 5 });
            list.Sort();
            foreach(Product pr in list)
            {
                Console.WriteLine(pr);
            }
            Console.ReadLine();
        }
    }
}
