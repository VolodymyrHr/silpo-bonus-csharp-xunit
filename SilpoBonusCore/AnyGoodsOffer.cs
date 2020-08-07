namespace CheckoutService
{
    public class AnyGoodsOffer : Offers
    {
        public int totalCost;
        public int points;

        public AnyGoodsOffer(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }

        public override void Apply(Check check){
            if (totalCost <= check.getTotalCost()){
                check.addPoints(points);
            }
        }
    }
}