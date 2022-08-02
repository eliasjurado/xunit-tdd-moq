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

        [Fact]
        public void MakeFullName_StartsWith()
        {
            var name = new Name();
            var result = name.MakeFullName("Elias", "Jurado");
            Assert.StartsWith("El", result);
        }

        [Fact]
        public void MakeFullName_EndsWith()
        {
            var name = new Name();
            var result = name.MakeFullName("Elias", "Jurado");
            Assert.EndsWith("urado", result);
        }

        [Fact]
        public void MakeFullName_StartsWith_and_EndsWith()
        {
            var name = new Name();
            var result = name.MakeFullName("Elias", "Jurado");
            Assert.StartsWith("El", result);
            Assert.EndsWith("urado", result);
        }

        [Fact]
        public void MakeFullName_MatchRegexPattern()
        {
            var name = new Name();
            var result = name.MakeFullName("Elias", "Jurado");
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }
    }
}
