using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest;
using Xunit;

namespace UnitTest.Tests
{
    public class WithdrawTests
    {
        [Theory]
        [InlineData(5000, 5000)]
        [InlineData(-5, 10000)]
        [InlineData(10000, 0)]
        public void Withdraw_ShouldWithdrawIfAmoountUnderBalance(double ammount, double expected)
        {
            //Arrange

            //Act
            double actual = Withdraw.WithdrawMoney(ammount);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
