using Calculations.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{
    public class FibonacciTest : IClassFixture<FibonacciFixture>
    {
        public readonly ITestOutputHelper _testOutputHelper;
        public readonly FibonacciFixture _fibonacciFixture;
        public FibonacciTest(ITestOutputHelper testOutputHelper, FibonacciFixture fibonacciFixture)
        {
            _testOutputHelper = testOutputHelper;
            _fibonacciFixture = fibonacciFixture;
        }

        [Fact]
        [Trait("Category", "Numbers")]
        public void Fibonacci_DoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine($"Fibonacci_DoesNotIncludeZero - {DateTime.Now}");
            Fibonacci fibonacci = _fibonacciFixture.fibonacciSingleton;
            Assert.All(fibonacci.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Numbers")]
        public void Fibonacci_Includes13()
        {
            _testOutputHelper.WriteLine($"Fibonacci_Includes13 - {DateTime.Now}");
            Fibonacci fibonacci = _fibonacciFixture.fibonacciSingleton;
            Assert.Contains(13, fibonacci.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Numbers")]
        public void Fibonacci_DoesNotIncludes4()
        {
            _testOutputHelper.WriteLine($"Fibonacci_DoesNotIncludes4 - {DateTime.Now}");
            Fibonacci fibonacci = _fibonacciFixture.fibonacciSingleton;
            Assert.DoesNotContain(4, fibonacci.FiboNumbers);
        }

        [Trait("Category", "Collections")]
        [Fact]
        public void Fibonacci_CheckCollection()
        {
            _testOutputHelper.WriteLine($"Fibonacci_CheckCollection - {DateTime.Now}");
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            Fibonacci fibonacci = _fibonacciFixture.fibonacciSingleton;
            Assert.Equal(expectedCollection, fibonacci.FiboNumbers);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var fibonacci = _fibonacciFixture.fibonacciSingleton;
            var result = fibonacci.IsOdd(1);
            Assert.Equal(true, result);
        }

        [Fact]
        public void IsOdd_GivenEvenValue_ReturnsFalse()
        {
            var fibonacci = _fibonacciFixture.fibonacciSingleton;
            var result = fibonacci.IsOdd(1);
            Assert.Equal(false, result);
        }

        //Hardcoding data
        [Theory]
        [InlineData(1, true)]
        [InlineData(200, false)]
        public void IsOdd_TestOddAndEven_HardCodingData(int value, bool expected)
        {
            var fibonacci = _fibonacciFixture.fibonacciSingleton;
            var result = fibonacci.IsOdd(value);
            Assert.Equal(expected, result);
        }

        //Providing test data in a class
        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var fibonacci = _fibonacciFixture.fibonacciSingleton;
            var result = fibonacci.IsOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [IsOddOrEvenData] //all this line goes in a class attribute
        public void IsOdd_TestOddAndEven2(int value, bool expected)
        {
            var fibonacci = _fibonacciFixture.fibonacciSingleton;
            var result = fibonacci.IsOdd(value);
            Assert.Equal(expected, result);
        }

        //Providing test data in text file
        [Theory]
        [MemberData(nameof(TestDataShare.IsEvenOrOddExternalData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEvenExternal(int value, bool expected)
        {
            var fibonacci = _fibonacciFixture.fibonacciSingleton;
            var result = fibonacci.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
