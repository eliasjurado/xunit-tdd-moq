using Xunit;

namespace Calculations.Test.Fixtures
{
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
    {
    }
}
