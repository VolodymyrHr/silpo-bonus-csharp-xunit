namespace CheckoutService
{
    public class AnyGoodsOffer
    {
        internal int totalCost;
        internal int points;

        public AnyGoodsOffer(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }
    }
}