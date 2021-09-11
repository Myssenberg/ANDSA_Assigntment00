using System;
using Xunit;
using System.IO;

namespace Assignment00.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void IsLeapYear_accepts_1996_because_it_is_divisible_by_four()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(1996);
            
            //Assert
            Assert.True(result);
        }

		[Fact]
        public void IsLeapYear_doesnt_accept_1995_bc_its_not_divisible_by_four()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(1995);
            
            //Assert
            Assert.False(result);
        }

		[Fact]
        public void IsLeapYear_doesnt_accept_1900_bc_its_divisible_by_100()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(1900);
            
            //Assert
            Assert.False(result);
        }

		[Fact]
        public void IsLeapYear_accepts_2000_bc_its_divisible_by_400()
        {
            //Arrange
            Program test = new Program();

            //Act
            bool result = test.IsLeapYear(2000);
            
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Main_console_prints_yay_when_user_inputs_2000_bc_its_a_leapyear()
        {
            //Arrange
            var writer = new StringWriter();
            var reader = new StringReader("2000");
            Console.SetOut(writer);
            Console.SetIn(reader);
            
            //Act
            Program.Main(new string[0]);
            
            //Assert
            var result = writer.GetStringBuilder().ToString().Trim();
            //Could not figure out how to trim the stringbuilder to only showing the last line of the console output.
            //Therefore this is contains instead of equal
            Assert.Contains("yay", result);
        }
        
        [Fact]
        public void Main_console_prints_nay_when_user_inputs_1900_bc_its_not_a_leapyear()
        {
            //Arrange
            var writer = new StringWriter();
            var reader = new StringReader("1900");
            Console.SetOut(writer);
            Console.SetIn(reader);
            
            //Act
            Program.Main(new string[0]);
            
            //Assert
            var result = writer.GetStringBuilder().ToString().Trim();
            //Could not figure out how to trim the stringbuilder to only showing the last line of the console output.
            //Therefore this is contains instead of equal
            Assert.Contains("nay", result);
        }

        [Fact]
        public void Main_throws_FormatException_when_given_something_not_convertible_to_int()
        {
            //Arrange
            var reader = new StringReader("hej");
            Console.SetIn(reader);
            
            //Act

            //Assert
            Assert.Throws<FormatException>(() => Program.Main(new string[0]));
        }
        
        [Fact]
        public void Main_throws_ArgumentException_when_given_a_year_before_1582()
        {
            //Arrange
            var reader = new StringReader("1581");
            Console.SetIn(reader);
            
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => Program.Main(new string[0]));
        }
    }
}
