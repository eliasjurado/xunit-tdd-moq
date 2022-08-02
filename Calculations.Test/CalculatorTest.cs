using Xunit;

namespace Calculations.Test
{
    public class CalculatorTest
    {
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
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }
        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(0.721, 2.5);
            Assert.Equal(3.22, result, 2);
        }

    }
}
