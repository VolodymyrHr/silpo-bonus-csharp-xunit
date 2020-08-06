using System;
using System.Collections.Generic;

namespace CheckoutService
{
    public class CheckoutService
    {
        private Check check;

        public void openCheck()
        {
            check = new Check();
            check.products = new List<Product>();
            check.totalCost = 0;
        }

        public void addProduct(Product product)
        {
            check.products.Add(product);
        }

        public Check closeCheck()
        {
            check = new Check();
            return check;
        }
    }
}