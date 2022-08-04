using Calculations.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{
    public class CustomerTest
    {
        public readonly ITestOutputHelper _testOutputHelper;
        public readonly CustomerFixture _customerFixture;
        public CustomerTest(ITestOutputHelper testOutputHelper, CustomerFixture customerFixture)
        {
            _testOutputHelper = testOutputHelper;
            _customerFixture = customerFixture;
        }

        public void Customer_CheckNameNotEmpty()
        {
            _testOutputHelper.WriteLine($"Customer_CheckNameNotEmpty - {DateTime.Now}");
            Customer customer = _customerFixture.customerSingleton;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }
        [Fact]
        public void Customer_CheckAgeForDiscount()
        {
            _testOutputHelper.WriteLine($"Customer_CheckAgeForDiscount - {DateTime.Now}");
            Customer customer = _customerFixture.customerSingleton;
            Assert.InRange(customer.Age, 24, 40);
        }
        [Fact]
        public void Customer_GetOrdersByName_NotNull()
        {
            _testOutputHelper.WriteLine($"Customer_GetOrdersByName_NotNull - {DateTime.Now}");
            Customer customer = _customerFixture.customerSingleton;
            var exceptionDetails = Assert.Throws<ArgumentException>(() =>
            {
                customer.GetOrdersByName("");
            });
            Assert.Equal("This user does not receive any discount", exceptionDetails.Message);
        }
        [Fact]
        public void LoyalCustomer_OrderGreaterThan100()
        {
            _testOutputHelper.WriteLine($"LoyalCustomer_OrderGreaterThan100 - {DateTime.Now}");
            Customer customer = CustomerFactory.CreateCustomerInstance(102);
            // Just assert
            Assert.IsType(typeof(LoyalCustomer), customer);

            // First step
            var loyalcustomer = Assert.IsType<LoyalCustomer>(customer);
            // Second step
            Assert.Equal(10, loyalcustomer.Discount);
        }
    }
}
