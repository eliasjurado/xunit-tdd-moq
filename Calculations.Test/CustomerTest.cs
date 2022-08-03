using Xunit;

namespace Calculations.Test
{
    public class CustomerTest
    {
        [Fact]
        public void Customer_CheckNameNotEmpty()
        {
            Customer customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }
        [Fact]
        public void Customer_CheckAgeForDiscount()
        {
            Customer customer = new Customer();
            Assert.InRange(customer.Age, 24, 40);
        }
        [Fact]
        public void Customer_GetOrdersByName_NotNull()
        {
            Customer customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() =>
            {
                customer.GetOrdersByName("");
            });
            Assert.Equal("", exceptionDetails.Message);
        }
    }
}
