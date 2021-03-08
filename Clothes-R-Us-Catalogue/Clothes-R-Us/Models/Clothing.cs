using System.Collections.Generic;
using Clothes_R_Us.Models.Enums;
using Clothes_R_Us.Models.PriceCalculators;

namespace Clothes_R_Us.Models
{
    public class Clothing: Product
    {
        private readonly Sex _sex;
        private readonly Age _age;
        private readonly string _type;

        private List<Size> Sizes { get; }
        private List<Colour> Colours { get; }
        
        public Clothing(
            Sex sex, 
            Age age, 
            string type, 
            int productNumber, 
            string name, 
            string description, 
            double price, 
            List<Image> images,
            List<Size> sizes,
            List<Colour> colours) 
            : 
            base(
                productNumber,  
                name, 
                description, 
                price, 
                images)
        {
            _sex = sex;
            _age = age;
            _type = type;
            Sizes = sizes;
            Colours = colours;
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