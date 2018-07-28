using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TDDDetroitSchoolWorkshop.BussinessLayer
{
    public class BmiCalculator
    {
        public double CalculateBmiFromCsv(string row)
        {
            var splittedValues = SplitValues(row);
            var numbers = ParseNumbers(splittedValues);
            var heightInCm = numbers[0];
            var weightInKg = numbers[1];

            return Math.Round(weightInKg/Math.Pow((heightInCm/100), 2), 1);
        }

        private List<string> SplitValues(string row)
        {
            return row.Split(";").ToList();
        }

        private List<double> ParseNumbers(List<string> numbersToParse)
        {
            return new List<double> {
                double.Parse(numbersToParse[0], CultureInfo.InvariantCulture),
                double.Parse(numbersToParse[1], CultureInfo.InvariantCulture)
            };
        }
    }
}
