using System;

namespace CheckoutService
{
    public class AnyGoodsOffer : Offers
    {
        public int totalCost;
        public int points;

        DateTime date;
        public AnyGoodsOffer(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }
        public AnyGoodsOffer(int totalCost, int points, string date)
        {
            this.date = DateTime.Parse(date);
        }


        public override void Apply(Check check)
        {
            if (totalCost <= check.getTotalCost())
            {
                check.addPoints(points);
            }
        }
    }
}