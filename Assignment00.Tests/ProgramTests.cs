using System;
using Xunit;

namespace Assignment00.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void IsLeapYear_accepts_divisible_by_four()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(1996);
            
            //Assert
            Assert.True(result);
        }

		[Fact]
        public void IsLeapYear_doesnt_accept_not_divisible_by_four()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(1995);
            
            //Assert
            Assert.False(result);
        }

		[Fact]
        public void IsLeapYear_doesnt_accept_divisible_by_100()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(1900);
            
            //Assert
            Assert.False(result);
        }

		[Fact]
        public void IsLeapYear_accepts_divisible_by_400()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(2000);
            
            //Assert
            Assert.True(result);
        }
    }
}
