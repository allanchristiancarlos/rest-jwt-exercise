using System;
using RestJwt.Api.Controllers;
using Xunit;

namespace RestJwt.Api.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void test_should_be_equal_to_1()
        {
            AccountsController controller = new AccountsController();

            Assert.Equal(1, controller.GetOne());
        }
    }
}
