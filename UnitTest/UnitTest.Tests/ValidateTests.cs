using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest;
using Xunit;

namespace UnitTest.Tests
{
    public class ValidateTests
    {
        [Fact]
        public void ValidatePin_ShouldBeTrueWhenCorrect()
        {
            //Arrange
            bool expected = true;

            //Act
            bool actual = Validate.ValidatePin(1234);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
