using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{
    public class CalculatorTest : IClassFixture<CalculationsFixture>
    {
        public readonly ITestOutputHelper _testOutputHelper;
        public readonly CalculationsFixture _calculationsFixture;
        public readonly MemoryStream memoryStream;
        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculationsFixture calculationsFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculationsFixture = calculationsFixture;

            memoryStream = new MemoryStream();
        }
        [Fact]
        public void TestFoo()
        {
            Assert.True(true);
        }
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(1, 1);
        }
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = _calculationsFixture.calculatorSingleton;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }
        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = _calculationsFixture.calculatorSingleton;
            var result = calc.AddDouble(0.721, 2.5);
            Assert.Equal(3.22, result, 2);
        }

    }
}
