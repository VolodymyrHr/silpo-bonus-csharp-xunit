namespace CheckoutService
{
    public class FactorByCategoryOffer : Offers
    {
        public Category category;
        public int factor;

        public FactorByCategoryOffer(string date, Category category, int factor) : base(date)
        {
            this.category = category;
            this.factor = factor;
        }

        public override void Apply(Check check){
            int points = check.getCostByCategry(category);
            check.addPoints(points * (factor - 1));
        }
    }


    
}