// Student ID - 5394923
// Program 1A
// CIS-200-50
// Due: 9/27/2021

// Program that displays the Shippers information as well as the recipiants information 
// for letters that have been mailed to one another.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Program_0
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            // Test Addresses A-D
            Address Alpha = new Address("Daniel Collins", "1234 Virgina Avenue",
                "Fort Lauderdale", "FL", 33302);
            Address Bravo = new Address("Jeffery Fillmore", "3845 7th Street", "Apt 13",
                "Des Moines", "IA", 50303);
            Address Charlie = new Address("Shelby Miller", "6948 Grand blvd",
                "Little Rock", "AR", 72201);
            Address Delta = new Address("Giles Mason", "756 West Sycamore Street", "PO box 412",
                "Albany", "NY", 12202);
            Address Echo = new Address("Gerry Baxter", "9234 Brandy Street",
                "Honolulu", "HI", 96795);

            // Test Letters 1-3
            Letter Letter1 = new Letter(Delta, Bravo, 15.11M);
            Letter Letter2 = new Letter(Alpha, Bravo, 13.71M);
            Letter Letter3 = new Letter(Delta, Charlie, 17.81M);

            GroundPackage Ground1 = new GroundPackage(Alpha, Delta, 20, 66, 1, 14.2);

            NextDayAirPackage Nextday1 = new NextDayAirPackage(Bravo, Charlie, 14, 3, 7, 67, 6.22M);

            TwoDayAirPackage TwoDay1 = new TwoDayAirPackage(Delta, Echo, 32.9, 12.8, 23.3, 14.9, TwoDayAirPackage.Delivery.Early);

            // List class that was requested pinning letters to a list of parcel objects
            List<Parcel> parcels = new List<Parcel> { Letter1, Letter2, Letter3, Ground1, Nextday1, TwoDay1 };

            // Didsplays the test data that is provided
            WriteLine("Parcels in route");
            WriteLine(" ");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine(" ");
            }
        }
    }
}
