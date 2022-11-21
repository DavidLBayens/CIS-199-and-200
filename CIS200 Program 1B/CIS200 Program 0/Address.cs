using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_1
{
    public class Address
    {
        // const variables for the zipcode in later code.
        public const int Minimum_Zip = 10000;
        public const int Maximum_Zip = 99999;
        // private variables used in the adddress class for name, 2 possible address lines, city,
        // state, and zipcode
        private string _name;
        private string _firstAddress;
        private string _secondAddress;
        private string _city;
        private string _state;
        private int _zipcode;

        // Pre and post conditions for all of the variables
        public Address(string name, string firstAddress, string secondAddress, string city, string state, int zipcode)

        {
            Name = name;
            FirstAddress = firstAddress;
            SecondAddress = secondAddress;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        // pre and post conditions for all of the variables except for the second address line
        // being that it is optional.
        public Address(string name, string firstAddress, string city, string state, int zipcode)
            : this(name, firstAddress, string.Empty, city, state, zipcode)

        {}
        // Code used to develop the name variable including pre and post conditions.
        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(Name)}",
                        value, $"{nameof(Name)} Please input your name");
                else
                    _name = value.Trim();
            }
        }
        // Code used to develop the first address variable including pre and post conditions.
        public string FirstAddress
        {
            get { return _firstAddress; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(FirstAddress)}",
                        value, $"{nameof(FirstAddress)} Please input your address");
                else
                    _firstAddress = value.Trim();
            }
        }
        // Code used to develop the second address variable including pre and post conditions.
        public string SecondAddress
        {
            get { return _secondAddress; }

            set
            {
                if (value == null)
                    value = string.Empty;

                _secondAddress = value.Trim();
            }
        }
        // Code used to develop the city variable including pre and post conditions.
        public string City
        {
            get { return _city; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(City)}",
                        value, $"{nameof(City)} Please input yout city");
                else
                    _city = value.Trim();
            }
        }
        // Code used to develop the state variable including pre and post conditions.
        public string State
        {
            get { return _state; }

            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(State)}",
                        value, $"{nameof(State)} Please input yout state");
                else
                    _state = value.Trim();
            }
        }
        // Code used to develop the zipcode variable including pre and post conditions.
        public int Zipcode
        {
            get { return _zipcode; }

            set 
            {
                if ((value >= Minimum_Zip) && (value <= Maximum_Zip))
                    _zipcode = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Zipcode)}", value,
                        $"{nameof(Zipcode)} Please input a valid U.S. zip code");
            }
        }
        // The code used to return everything

        public override string ToString()
        {
            // code for starting a new line.
            string Line = Environment.NewLine;
            string result;

            result = $"{Name}{Line}{FirstAddress}{Line}{SecondAddress}" +
                $"{(String.IsNullOrWhiteSpace(SecondAddress) ? string.Empty : Line)}" +
                $"{City}, {State} {Zipcode:D5}";

            return result;

        }
    }
}
