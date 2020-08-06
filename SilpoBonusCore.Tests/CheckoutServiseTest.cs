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

        [Fact]
        public void AddProduct__WhenCheckIsClosed__OpenNewCheck(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openCheck();
            
            checkoutService.addProduct(new Product(7, "Milk"));
            Check milkCheck = checkoutService.closeCheck();
            Assert.Equal(7, milkCheck.getTotalCost());
            
            checkoutService.addProduct(new Product(3, "Bread"));
            Check breadCheck = checkoutService.closeCheck();
            Assert.Equal(3, breadCheck.getTotalCost());
        }
    }
}