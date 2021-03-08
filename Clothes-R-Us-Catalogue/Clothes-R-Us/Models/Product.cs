using System.Collections.Generic;
using Clothes_R_Us.Models.PriceCalculators;

namespace Clothes_R_Us.Models
{
    public abstract class Product
    {
        private PriceCalculator _calculator;
        
        public int ProductNumber { get; }
        public string Name { get; }
        public string Description { get; }
        public double Price { get; }
        public List<Image> Images { get; }
        
        public abstract List<string> Categories { get;}

        protected Product(PriceCalculator priceCalculator, int productNumber, string name, string description, double price, List<Image> images)
        {
            _calculator = priceCalculator;
            ProductNumber = productNumber;
            Name = name;
            Description = description;
            Price = price;
            Images = images;
        }
    }
}