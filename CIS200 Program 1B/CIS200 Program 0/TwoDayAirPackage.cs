using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_1
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver } // Types of delivery

        private Delivery _deliveryType; // Delivery type

        // Precondition - All Variables are greater than 0
        // Postcondition - twoday packages are created with proper values.

        public TwoDayAirPackage(Address originAddress, Address destination, double packLength,
            double packWidth, double packHeight, double packWeight, Delivery Type)
            : base(originAddress, destination, packLength, packWidth, packHeight, packWeight)
        {
            DeliveryType = Type;
        }

        public Delivery DeliveryType
        { // return twoday package delivery type
            get { return _deliveryType; }

            // value must be one of the delivery types
            // Twoday package delivery type has been assigned
            set 
            {
                if (Enum.IsDefined(typeof(Delivery), value))
                    _deliveryType = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(DeliveryType), value,
                        $"{nameof(DeliveryType)} must be {nameof(Delivery.Early)}" +
                        $"or {nameof(Delivery.Saver)}");
            }
        }

        // return twoday package cost

        public override decimal CalcCost()
        {
            const double Dimensions = .18; // Dimension variable
            const double WeightCharge = .20; // Weight Varibale 
            const decimal Discount = .15M; // Discount Variable
            decimal cost; // Total cost

            cost = (decimal)(Dimensions * (Length + Width + Height) + WeightCharge * Weight);

            if (DeliveryType == Delivery.Saver)
                cost *= (1 - Discount);

            return cost;
        }
        public override string ToString()
        {
            string Line = Environment.NewLine; // New Line

            return $"TwoDay{base.ToString()}{Line}Delivery Type: {DeliveryType}";
        }
    }
}
