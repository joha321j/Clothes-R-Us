namespace Clothes_R_Us.Models.PriceCalculators
{
    public class SimplePriceCalculator: PriceCalculator
    {

        public double CalculatePrice(double basePrice)
        {
            return basePrice;
        }
    }
}