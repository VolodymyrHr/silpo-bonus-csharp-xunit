using System;
using Xunit;

namespace CheckoutService.Tests
{

    public class CheckoutServiceTest{

        private Product milck_7;
        private Product bread_3;
        private CheckoutService checkoutService;

        public CheckoutServiceTest(){
            checkoutService = new CheckoutService();
            checkoutService.openCheck();
            milck_7 = new Product(7, "Milk");
            bread_3 = new Product(3, "Bread");
        }

        [Fact]
        public void CloseCheck__WithOneProduct(){
            
            checkoutService.addProduct(milck_7);
            Check check = checkoutService.closeCheck();

            Assert.Equal(7, check.getTotalCost());
        }
        [Fact]
        public void CloseCheck__WithTwoProduct(){
            checkoutService.addProduct(milck_7);
            checkoutService.addProduct(bread_3);
            Check check = checkoutService.closeCheck();

            Assert.Equal(10, check.getTotalCost());
        }

        [Fact]
        public void AddProduct__WhenCheckIsClosed__OpenNewCheck(){            
            checkoutService.addProduct(milck_7);
            Check milkCheck = checkoutService.closeCheck();
            Assert.Equal(7, milkCheck.getTotalCost());
            
            checkoutService.addProduct(bread_3);
            Check breadCheck = checkoutService.closeCheck();
            Assert.Equal(3, breadCheck.getTotalCost());
        }

        [Fact]
        public void closeCheck__calckTotalPoints(){
            checkoutService.addProduct(milck_7);
            checkoutService.addProduct(bread_3);
            Check check = checkoutService.closeCheck();

            Assert.Equal(10, check.getTotalPoints());
        }

        [Fact]
        public void UseOffer__AddOfferPoints(){
            checkoutService.addProduct(milck_7);
            checkoutService.addProduct(bread_3);

            checkoutService.useOffer(new AnyGoodsOffer(6, 2));

            Check check = checkoutService.closeCheck();

            Assert.Equal(12, check.getTotalPoints());
        }

        [Fact]
        public void UseOffer__WhenCostLessThenRequired__DoNothing(){
            checkoutService.addProduct(bread_3);

            checkoutService.useOffer(new AnyGoodsOffer(6, 2));

            Check check = checkoutService.closeCheck();

            Assert.Equal(3, check.getTotalPoints());
        }
    }
}