namespace Calculations
{
    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
            {
                return new Customer();
            }
            return new LoyalCustomer();
        }
    }
}
