using TDDSample;

namespace TDDSampleTest
{
    public class PasswordTest
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var targetTest = new DefaultPasswordValidator();
            var password = "1234567890";
            var validationResult = targetTest.Validate(password);

            Assert.True(validationResult);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var targetTest = new DefaultPasswordValidator();
            //We can set values manually...
            //var password = "1234567";
            //... but it would be robuster if we create a method
            var password = MakeString(7);
            var validationResult = targetTest.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenNoUpperCase_ReturnsFalse()
        {
            var targetTest = new DefaultPasswordValidator();
            var password = "abc";
            var validationResult = targetTest.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenOneUpperCase_ReturnsTrue()
        {
            var targetTest = new DefaultPasswordValidator();
            var password = "aBc";
            var validationResult = targetTest.Validate(password);

            Assert.True(validationResult);
        }

        private string MakeString(int lenght)
        {
            string result = "";
            for (int i = 0; i < lenght; i++)
            {
                result += "a";
            }
            return result;
        }
    }
}