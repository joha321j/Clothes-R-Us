using System.Collections.Generic;
using Clothes_R_Us.Models.Enums;
using Clothes_R_Us.Models.PriceCalculators;

namespace Clothes_R_Us.Models
{
    public class Clothing: Product
    {
        private Sex _sex;
        private Age _age;
        private string _type;

        public List<Size> Sizes { get; set; }
        public List<Colour> Colours { get; set; }
        
        public Clothing(
            PriceCalculator priceCalculator, 
            Sex sex, 
            Age age, 
            string type, 
            int productNumber, 
            string name, 
            string description, 
            double price, 
            List<Image> images) 
            : 
            base(
                priceCalculator, 
                productNumber,  
                name, 
                description, 
                price, 
                images)
        {
            _sex = sex;
            _age = age;
            _type = type;
        }

        public override List<string> Categories
        {
            get
            {
                List<string> categories = new List<string> {
                    _sex.ToString(),
                    _age.ToString(),
                    _type
                };
                return categories;
            }
        }
    }
}