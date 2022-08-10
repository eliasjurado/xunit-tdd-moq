namespace Calculations
{
    public class Customer
    {
        public string Name => "Elias";
        public int Age => 36;

        public virtual int GetOrdersByName(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("This user does not receive any discount");
            }
            return 100;
        }

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

    }
}
