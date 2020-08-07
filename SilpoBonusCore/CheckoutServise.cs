using System;
using System.Collections.Generic;

namespace CheckoutService
{
    public class CheckoutService
    {
        private Check check;
        private bool checkStatus;

        public void openCheck()
        {
            checkStatus = false;
            check = new Check();
        }

        private void AvtoOpenCheck(){
            if(checkStatus){
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
            return check;
        }

        public void useOffer(AnyGoodsOffer offer)
        {
            if(offer.totalCost <= check.getTotalCost())
            check.addPoints(offer.points);
        }
    }
}