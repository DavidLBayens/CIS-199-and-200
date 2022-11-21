using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_1
{
    public abstract class AirPackage : Package
    {
        public const double Heavy = 75; // minimum for heavy packages
        public const double Large = 100; // minimum for large packages

        // PreCondition - All variables are greater than 0.
        // PostCondition - Air package is created with specific values.

        public AirPackage(Address originAddress, Address destination, double packLength,
            double packWidth, double packHeight, double packWeight)
            : base(originAddress, destination, packLength, packWidth, packHeight, packWeight)
        { 
            // Work done in base class
        }
        // return true or false for air package based on weight
        public bool IsHeavy()

        { return (Weight >= Heavy); }

        // return true or false based on package size

        public bool IsLarge()

        { return ((Length + Width + Height) >= Large); }

        // string returning air package data
        public override string ToString()
        {
            string Line = Environment.NewLine; // New Line

            return $"AirPackage{base.ToString()}{Line}Is it Heavy: {IsHeavy()}Is it Large: {IsLarge()}";
        }
    }
}
