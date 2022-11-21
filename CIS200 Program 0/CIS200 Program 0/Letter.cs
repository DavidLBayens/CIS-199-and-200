using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_0
{// Referencing the inheritance to the parcel class
    public class Letter : Parcel
    { // Fixed rate of sending a letter
        private decimal _fixedcost; 
        // Pre and post conditions for the cost
        public Letter(Address origin, Address destination, decimal cost)
            : base(origin, destination)
        {
            FixedCost = cost;
        }
        // Code for the fixed cost with pre and post conditions
        private decimal FixedCost 
        {
            get { return _fixedcost; }

            set
            {
                if (value >= 0)
                    _fixedcost = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(FixedCost)}", value,
                        $"{nameof(FixedCost)} 0 is the lowest possible cost");
            }
        }
        // Return the letter cost
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        public override string ToString()
        {
            // New line
            string Line = Environment.NewLine;
            // Return everything
            return $"Letter{Line}{base.ToString()}";
        }
    }
}
