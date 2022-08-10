using Calculations.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        public readonly ITestOutputHelper _testOutputHelper;
        public readonly CalculatorFixture _calculationsFixture;

        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculationsFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculationsFixture = calculationsFixture;
        }
        [Fact]
        public void TestFoo()
        {
            _testOutputHelper.WriteLine($"TestFoo - {DateTime.Now}");
            Assert.True(true);
        }
        [Fact]
        public void TestAdd()
        {
            _testOutputHelper.WriteLine($"TestAdd - {DateTime.Now}");
            Assert.Equal(1, 1);
        }
        [Fact]
        [Trait("Category", "Numbers")]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            _testOutputHelper.WriteLine($"Add_GivenTwoIntValues_ReturnsInt - {DateTime.Now}");
            var calc = _calculationsFixture.calculatorSingleton;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }
        [Fact]
        [Trait("Category", "Numbers")]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            _testOutputHelper.WriteLine($"AddDouble_GivenTwoDoubleValues_ReturnsDouble - {DateTime.Now}");
            var calc = _calculationsFixture.calculatorSingleton;
            var result = calc.AddDouble(0.721, 2.5);
            Assert.Equal(3.22, result, 2);
        }

    }
}
