using System;

namespace CheckoutService
{
    public abstract class Offers
    {
        DateTime expirationDate;

        public Offers(string date)
        {
            this.expirationDate = DateTime.Parse(date);
        }
        public bool ChecExpirationDate()
        {
            DateTime thisDay = DateTime.Today;
            return thisDay <= expirationDate;
        }

        internal void GetOffer(Check check)
        {
            if (ChecExpirationDate())
            {
                Apply(check);
            }
        }

        public abstract void Apply(Check check);
    }
}