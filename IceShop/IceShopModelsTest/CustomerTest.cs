using SufferShopModels;
using System;
using Xunit;

namespace SufferShopTest
{
    public class CustomerTest
    {
        //[Fact]// As opposed to theory




        [Theory]
        [InlineData("4807973097")]
        [InlineData("797-3097")]
        public void AddCustomerPhoneNumberShouldAddCustomerPhoneNumber(string phonenumber)
        {
            // Arrange (Arranging artifacts I might need during testing)


            Customer customer = new Customer("Sample Name", "sample@email.com", "pwd8charslong");
            customer.AddPhoneNumber(phonenumber);

            Assert.Equal(phonenumber, customer.PhoneNumber);

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddCustomerPhoneNumberShouldThrowArgumentException(string phonenumber)
        {
            throw new NotImplementedException();


            // Arrange (Arranging artifacts I might need during testing)

            /*
            CustomerSample customer = new CustomerSample();

            // Here, the act and assert are the same thing.
            Assert.Throws<ArgumentException>(() => customer.AddPhoneNumber(phonenumber));
            */

        }
    }
}
