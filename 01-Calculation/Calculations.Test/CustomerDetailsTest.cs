using Calculations.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{
    [Collection("Customer")]
    public class CustomerDetailsTest : IClassFixture<CustomerFixture>
    {
        public readonly ITestOutputHelper _testOutputHelper;
        public readonly CustomerFixture _customerFixture;
        public CustomerDetailsTest(ITestOutputHelper testOutputHelper, CustomerFixture customerFixture)
        {
            _testOutputHelper = testOutputHelper;
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetFullName_GivenFirstAndLastName()
        {
            _testOutputHelper.WriteLine($"GetFullName_GivenFirstAndLastName - {DateTime.Now}");
            Customer customer = _customerFixture.customerSingleton;
            Assert.Equal("Elias Jurado", customer.GetFullName("Elias", "Jurado"));
        }
    }
}
