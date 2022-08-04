namespace Calculations.Test.Fixtures
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator calculatorSingleton => new Calculator();
        public void Dispose()
        {
            //Clean
        }
    }
}
