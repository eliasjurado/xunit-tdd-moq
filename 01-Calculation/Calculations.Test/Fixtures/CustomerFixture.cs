namespace Calculations.Test.Fixtures
{
    public class CustomerFixture
    {
        public Customer customerSingleton => new Customer();
        public void Dispose()
        {
            //Clean
        }
    }
}
