using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_0
{
    public abstract class Package : Parcel
    {
        // varibales including length, width, and height in inches; Also weight in pounds.
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        // Preconditions - all variables are greater than 0.
        // Postconditions - The package has specific values based on variables.
        public Package(Address originAddress, Address destination, double packLength,
            double packWidth, double packHeight, double packWeight)

            : base(originAddress, destination)

        {
            Length = packLength;
            Width = packWidth;
            Height = packHeight;
            Weight = packWeight;
        }
        public double Length
        { // return package length
            get { return _length; }
            // value is greater than 0 and package is set to value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Length), value,
                        $"{nameof(Length)} Must be larger than 0");
            }
        }
        public double Width
        { // return package width
            get { return _width; }
            // value is greater than 0 and package is set to value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Width), value,
                        $"{nameof(Width)} Must be larger than 0 ");
            } 
        }

        public double Height
        { // return package Height
            get { return _height; }
            // value is greater than 0 and package is set to value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Height), value,
                       $"{nameof(Height)} Must be larger than 0 ");
            }
        }
        public double Weight
        { // return package Weight
            get { return _weight; }
            // value is greater than 0 and package is set to value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Weight), value,
                       $"{nameof(Weight)} Must be larger than 0 ");
            }
        }
        // A string with the package's data being returned
        public override string ToString()
        {
            string Line = Environment.NewLine; // New Line 

            return $"Package{Line}{base.ToString()}{Line}Length: {Length:N1}{Line}" +
                $"Width: {Width:N1}{Line}Height: {Height:N1}{Line}Weight: {Weight:N1}"; 
        }
    }
}
