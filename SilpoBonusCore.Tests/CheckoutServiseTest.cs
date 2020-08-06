using System;
using Xunit;

namespace CheckoutService.Tests
{

    public class CheckoutServiceTest{

        [Fact]
        public void CloseCheck__WithOneProduct(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openCheck();
            
            checkoutService.addProduct(new Product(8, "Milk"));
            Check check = checkoutService.closeCheck();

            Assert.Equal(7, check.getTotalCost());
        }

    }
}