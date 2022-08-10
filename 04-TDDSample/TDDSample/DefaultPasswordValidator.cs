namespace TDDSample
{
    public class DefaultPasswordValidator : IPasswordValidator
    {
        public bool Validate(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(x => char.IsUpper(x)))
            {
                return false;
            }
            return true;
        }
    }
}
