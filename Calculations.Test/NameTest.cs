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

        [Fact]
        public void MakeFullName_IgnoreCase()
        {
            var name = new Name();
            var result = name.MakeFullName("elias", "jurado");
            Assert.Equal("Elias Jurado", result, ignoreCase: true);
        }

        [Fact]
        public void MakeFullName_IgnoreCase_StringComparison()
        {
            var name = new Name();
            var result = name.MakeFullName("Elias", "Jurado");
            Assert.Contains("elias", result, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
