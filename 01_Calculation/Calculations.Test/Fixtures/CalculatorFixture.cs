namespace Calculations.Test.Fixtures
{
    public class CalculatorFixture : IDisposable
    {
        public MemoryStream memoryStream => new MemoryStream();
        public Calculator calculatorSingleton => new Calculator();
        public void Dispose()
        {
            memoryStream.Close();
        }
    }
}
