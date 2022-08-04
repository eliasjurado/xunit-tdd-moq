namespace Calculations.Test.Fixtures
{
    public class FibonacciFixture
    {
        public Fibonacci fibonacciSingleton => new Fibonacci();
        public void Dispose()
        {
            //Clean
        }
    }
}
