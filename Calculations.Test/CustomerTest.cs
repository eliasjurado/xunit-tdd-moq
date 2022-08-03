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
    }
}
