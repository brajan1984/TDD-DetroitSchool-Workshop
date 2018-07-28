using System;
using System.Globalization;
using System.Linq;

namespace TDDDetroitSchoolWorkshop.BussinessLayer
{
    public class BmiCalculator
    {
        public double CalculateBmiFromCsv(string row)
        {
            var splittedValues = row.Split(";").ToList();
            var heightInCm = double.Parse(splittedValues[0], CultureInfo.InvariantCulture);
            var weightInKg = double.Parse(splittedValues[1], CultureInfo.InvariantCulture);

            return Math.Round(weightInKg/Math.Pow((heightInCm/100), 2), 1);
        }
    }
}
