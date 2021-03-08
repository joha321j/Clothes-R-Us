using System.Collections.Generic;
using Clothes_R_Us.Models.PriceCalculators;

namespace Clothes_R_Us.Models
{
    public abstract class Product
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        
        public abstract List<string> Categories { get;}

        protected Product(int productNumber, string name, string description, double price, List<Image> images)
        {
            ProductNumber = productNumber;
            Name = name;
            Description = description;
            Price = price;
            Images = images;
        }
    }
}