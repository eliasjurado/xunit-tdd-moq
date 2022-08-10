namespace Calculations.Test.Fixtures
{
    public class LoyalCustomerFixture
    {
        public LoyalCustomer loyalCustomerSingleton => new LoyalCustomer();
        public void Dispose()
        {
            //Clean
        }
    }
}
