namespace Calculations
{
    public class Name
    {
        public string NickName { get; set; }
        public string MakeFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
