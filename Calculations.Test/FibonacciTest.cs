using Xunit;

namespace Calculations.Test
{
    public class FibonacciTest
    {

        [Fact]
        [Trait("Category", "Numbers")]
        public void Fibonacci_DoesNotIncludeZero()
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.All(fibonacci.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Numbers")]
        public void Fibonacci_Includes13()
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.Contains(13, fibonacci.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Numbers")]
        public void Fibonacci_DoesNotIncludes4()
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.DoesNotContain(4, fibonacci.FiboNumbers);
        }

        [Trait("Category", "Collections")]
        [Fact]
        public void Fibonacci_CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            Fibonacci fibonacci = new Fibonacci();
            Assert.Equal(expectedCollection, fibonacci.FiboNumbers);
        }
    }
}
