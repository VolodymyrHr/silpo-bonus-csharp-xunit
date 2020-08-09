using System;
using System.Collections.Generic;

namespace CheckoutService
{
    public class CheckoutService
    {
        private Check check;
        private bool checkStatus;
        private Offers offers = null;

        public void openCheck()
        {
            checkStatus = false;
            check = new Check();
        }

        private void AvtoOpenCheck()
        {
            if (checkStatus)
            {
                openCheck();
            }
        }
        public void addProduct(Product product)
        {
            AvtoOpenCheck();
            check.addProduct(product);
        }

        public Check closeCheck()
        {
            checkStatus = true;
            if (offers != null){
                offers.Apply(check);
            }
            return check;
        }

        public void useOffer(Offers offer)
        {
            offers = offer;
        }
    }
}