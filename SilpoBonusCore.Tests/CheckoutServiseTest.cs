using System;
using Xunit;

namespace CheckoutService.Tests
{

    public class CheckoutServiceTest{

        private Product milck_8;
        private Product bread_3;
        private CheckoutService checkoutService;

        public CheckoutServiceTest(){
            checkoutService = new CheckoutService();
            checkoutService.openCheck();
            milck_8 = new Product(8, "Milk");
            bread_3 = new Product(3, "Bread");
        }

        [Fact]
        public void CloseCheck__WithOneProduct(){
            
            checkoutService.addProduct(milck_8);
            Check check = checkoutService.closeCheck();

            Assert.Equal(8, check.getTotalCost());
        }
        [Fact]
        public void CloseCheck__WithTwoProduct(){
            checkoutService.addProduct(milck_8);
            checkoutService.addProduct(bread_3);
            Check check = checkoutService.closeCheck();

            Assert.Equal(11, check.getTotalCost());
        }

        [Fact]
        public void AddProduct__WhenCheckIsClosed__OpenNewCheck(){            
            checkoutService.addProduct(milck_8);
            Check milkCheck = checkoutService.closeCheck();
            Assert.Equal(8, milkCheck.getTotalCost());
            
            checkoutService.addProduct(bread_3);
            Check breadCheck = checkoutService.closeCheck();
            Assert.Equal(3, breadCheck.getTotalCost());
        }

        [Fact]
        public void closeCheck__calckTotalPoints(){
            checkoutService.addProduct(milck_8);
            checkoutService.addProduct(bread_3);
            Check check = checkoutService.closeCheck();

            Assert.Equal(11, check.getTotalPoints());
        }
    }
}