using Xunit;
using Models;

namespace Test
{
    public class ProductModelTest
    {
        [Fact]
        public void QuantityShouldValidData()
        {
            //arrange
            Product qty = new Product();
            int validQty = 40;

            //act
            qty.Quantity = validQty;

            // assert
            Assert.NotNull(qty.Quantity);
            Assert.Equal(validQty, qty.Quantity);

        }

        [Theory]
        [InlineData(-9)]
        [InlineData(-100)]
        [InlineData(-500)]
        public void QuantityShouldFailSetInvalidData(int p_invalidQty)
        {
            // arrange
            Product qty = new Product();

            // act & assert
            Assert.Throws<System.Exception>(
                () => qty.Quantity = p_invalidQty
            );
        }

        [Fact]
        public void PriceShouldValidData()
        {
            //arrange
            Product price = new Product();
            int validPrice = 100;

            //act
            price.Price = validPrice;

            // assert
            Assert.NotNull(price.Price);
            Assert.Equal(validPrice, price.Price);

        }

        [Theory]
        [InlineData(-9)]
        [InlineData(-100)]
        [InlineData(-500)]
        public void PriceShouldFailSetInvalidData(int p_invalidPrice)
        {
            // arrange
            Product price = new Product();

            // act & assert
            Assert.Throws<System.Exception>(
                () => price.Price = p_invalidPrice
            );
        }
    }
}
