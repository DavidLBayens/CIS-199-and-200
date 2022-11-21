using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_1
{
    public abstract class Parcel
    {
        // Address objects
        private Address _origin;
        private Address _destination;

        // Pre and post conditions for origin and destination addresses 
        public Parcel(Address origin, Address destination)
        {
            Origin = origin;
            Destination = destination;
        }
        // Code used to develop the origin address with pre and post conditions
        public Address Origin
        {
            get { return _origin; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Origin)}",
                        value, $"{nameof(Origin)} Must have place of origin");
                }
                else
                    _origin = value;
            }
        }
        // Code used to develop the destination address with pre and post conditions 
        public Address Destination
        {
            get { return _destination; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Destination)}",
                        value, $"{nameof(Destination)} Must have a destination");
                }
                else
                    _destination = value;
            }
        }
        // Code for returning the cost of the parcel
        public abstract decimal CalcCost();

        public override string ToString()
        {    // New line 
            string Line = Environment.NewLine;
            // return everything
            return $"Origin -{Line}{Origin}{Line}Destination -{Line}" +
                $"{Destination}{Line}Cost = {CalcCost():C}";
        }
    }
}
