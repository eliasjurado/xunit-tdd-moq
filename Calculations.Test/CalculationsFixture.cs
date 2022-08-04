namespace Calculations.Test
{
    public class CalculationsFixture : IDisposable
    {
        public Calculator calculatorSingleton => new Calculator();

        public void Dispose()
        {
            //Clean
        }
    }
}
