using Xunit;

namespace Calculations.Test
{
    public class NameTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var name = new Name();
            var result = name.MakeFullName("Elias", "Jurado");
            Assert.Equal("Elias Jurado", result);
        }
    }
}
