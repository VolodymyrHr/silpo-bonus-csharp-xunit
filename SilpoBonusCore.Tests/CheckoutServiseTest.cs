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

            Assert.Equal(8, check.getTotalCost());
        }
        [Fact]
        public void CloseCheck__WithTwoProduct(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openCheck();
            
            checkoutService.addProduct(new Product(8, "Milk"));
            checkoutService.addProduct(new Product(18, "Bread"));
            Check check = checkoutService.closeCheck();

            Assert.Equal(26, check.getTotalCost());
        }

    }
}