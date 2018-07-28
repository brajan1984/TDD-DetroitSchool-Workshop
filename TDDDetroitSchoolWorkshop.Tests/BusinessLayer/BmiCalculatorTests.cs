using System;
using FluentAssertions;
using TDDDetroitSchoolWorkshop.BussinessLayer;
using Xunit;

namespace TDDDetroitSchoolWorkshop.Tests.BusinessLayer
{
    public class BmiCalculatorTests
    {
        [Theory]
        [InlineData("175;95", 31.0)]
        [InlineData("168;44", 15.6)]
        [InlineData("198;120", 30.6)]
        public void CalculateBmiFromCsv_CorrectDataIsGiven_BmiIsCalculated(string csvRow, double expectedBmi)
        {
            //Arrange
            var calculator = new BmiCalculator();

            //Act
            var calculatedBmi = calculator.CalculateBmiFromCsv(csvRow);
            
            //Assert
            calculatedBmi.Should().Be(expectedBmi);
        }
    }
}
