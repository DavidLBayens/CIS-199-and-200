using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_0
{
    public class GroundPackage : Package
    {
        // Precondition - all variables are greater than 0
        // Postcondition - The ground package is acredited with the proper values for each variable

        public GroundPackage(Address originAddress, Address destination, double packLength,
            double packWidth, double packHeight, double packWeight)
            : base(originAddress, destination, packLength, packWidth, packHeight, packWeight)
        {
            // work in base class
        }

        public int ZoneDistance
        { // return package's zone distance.
            get 

            {
                const int FirstDigit = 10000; // used in calculation to help division
                int distance; // calculation

                distance = Math.Abs((Origin.Zipcode / FirstDigit) - (Destination.Zipcode / FirstDigit));
                    return distance;
            }
        }
        // return ground package's cost
        public override decimal CalcCost()
        {
            const double Dimensions = .15; // dimension variable to help with multiplication.
            const double WeightDimensions = .07; // weight variable to help with multiplication.

            return (decimal)(Dimensions * (Length + Width + Height) + WeightDimensions * (ZoneDistance + 1) * Weight);
        }
        // return string with ground package data.
        public override string ToString()
        {
            string Line = Environment.NewLine; // New Line

            return $"Ground{base.ToString()}{Line}Zone Distance: {ZoneDistance}";
        }
    }
}
