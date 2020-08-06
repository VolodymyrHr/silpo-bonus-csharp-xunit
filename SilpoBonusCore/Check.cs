using System.Collections.Generic;

namespace CheckoutService
{
    public class Check
    {
        private List<Product> products = new List<Product>();

        public int getTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in this.products){
                totalCost += product.price;
            }
            return totalCost;
        }

        internal void addProduct(Product product)
        {
            products.Add(product);
        }
    }
}