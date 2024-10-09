using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public int Code { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public String Name { get; set; }

        public Product()
        {
            Name = "";
        }

        public Product(int code, double price, double tax, String name)
        {
            Code = code;
            Price = price;
            Tax = tax;
            Name = name;
        }
    }
}