using Xunit;
using DemoEmailValidation;


namespace EmailValidation.xUnit
{
    public class UnitTest1
    {
        private readonly EmailValidator validator = new EmailValidator;
        [Fact]
        public void IsEmailValid_ShouldReturnFalseForInvalidEmail()
        {
            string input = "no-at-symbol.com";
            bool result = validator.IsEmailValid(input);
            Assert.False(result); // for wrong email
        }


        [Fact]
        public void IsEmailValid_ShouldReturnFalseForInvalidEmail()
        {
            string input = "test@example.com";
            bool result = validator.IsEmailValid(input);
            Assert.True(result); // for wrong email
        }
    }
}
