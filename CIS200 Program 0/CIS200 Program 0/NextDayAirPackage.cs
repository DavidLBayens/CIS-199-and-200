using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_0
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; // express fee for next day package's

        // Precondition - variables are all greater than 0 / greater than or equal to 0.
        // Postcondition - Next day air package has intended values.

        public NextDayAirPackage(Address originAddress, Address destination, double packLength,
            double packWidth, double packHeight, double packWeight, decimal expressFee)
            : base(originAddress, destination, packLength, packWidth, packHeight, packWeight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        { // return next day air package express fee.
            get { return _expressFee; }

            // return error if under 0
            private set
            {
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(ExpressFee), value,
                        $"{nameof(ExpressFee)} Must be Greater than or equal to 0");
            }
        }

        // return next day air package cost.
        public override decimal CalcCost()
        {
            const double Dimensions = .35; // Dimension variable for equation
            const double WeightCharge = .25; // Weight variable for equation
            const double Heavy = .20; // Heavy variable for equatuon
            const double Large = .22; // Large variable for equation
            decimal Cost; // Total cost of package

            Cost = (decimal)(Dimensions * (Length + Width + Height) + WeightCharge * Weight) + ExpressFee;

            if (IsHeavy())
                Cost += (decimal)(Heavy * Weight);
            if (IsLarge())
                Cost += (decimal)(Large * (Length + Width + Height));

            return Cost;
        }

        // String with next day air packages data

        public override string ToString()
        {
            string Line = Environment.NewLine; // New Line

            return $"NextDay{base.ToString()}{Line}Express Fee: {ExpressFee:C}";
        }
    }
}
