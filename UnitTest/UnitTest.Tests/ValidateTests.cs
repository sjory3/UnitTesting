using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest;
using Xunit;
using System.IO;

namespace UnitTest.Tests
{
    public class ValidateTests
    {
        [Fact]
        public void ValidatePin_ValidPinShouldWork()
        {
            //Arrange
            bool expected = true;

            //Act
            bool actual = Validate.ValidatePin(1234);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidatePin_InvalidPinShouldFail()
        {
            //Arrange
            bool expected = false;

            //Act
            bool actual = Validate.ValidatePin(2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
