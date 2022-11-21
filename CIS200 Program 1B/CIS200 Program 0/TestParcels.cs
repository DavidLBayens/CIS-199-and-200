// Student ID - 5394923
// Program 1B
// CIS-200-50
// Due: 10/8/2021

// Program that displays the Shippers information as well as the recipiants information 
// for letters/ packages that have been shipped to one another.
// Also utilizes LINQ to generate reports regarding the information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CIS200_Program_1
{
    class TestParcels
    {
        static void Main(string[] args)
        {
            // Test Addresses 
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
            Address Foxtrot = new Address("Barbara Thrasher", "555 Jackson Turnpike", "Apt 3",
                "Dallas", "TX", 75039);
            Address Golf = new Address("Kyle Douglas", "1272 Iroquois Parkway",
                "Louisville", "KY", 40258);
            Address Hotel = new Address("Christine Beverly", "8302 Iron Road",
                "Las Vegas", "NV", 88905);

            // Test Letters 
            Letter Letter1 = new Letter(Delta, Bravo, 15.11M);
            Letter Letter2 = new Letter(Alpha, Hotel, 13.71M);
            Letter Letter3 = new Letter(Delta, Charlie, 17.81M);
            Letter Letter4 = new Letter(Echo, Hotel, 23.04M);

            // Test ground packages
            GroundPackage Ground1 = new GroundPackage(Foxtrot, Delta, 20, 66, 1, 14.2);
            GroundPackage Ground2 = new GroundPackage(Charlie, Hotel, 12, 83, 2, 12.8);

            // Test next day air packages
            NextDayAirPackage NextDay1 = new NextDayAirPackage(Golf, Charlie, 14, 3, 7, 89, 6.22M);
            NextDayAirPackage NextDay2 = new NextDayAirPackage(Bravo, Foxtrot, 11, 2, 9, 35, 9.88M);

            // Test two day air packages
            TwoDayAirPackage TwoDay1 = new TwoDayAirPackage(Delta, Echo, 32.9, 12.8, 23.3, 14.9, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage TwoDay2 = new TwoDayAirPackage(Hotel, Alpha, 37.2, 9.8, 11.23, 77.3, TwoDayAirPackage.Delivery.Saver);

            // List class that was requested pinning letters to a list of parcel objects
            List<Parcel> parcels = new List<Parcel> { Letter1, Letter2, Letter3, Letter4, Ground1, Ground2, NextDay1, NextDay2, TwoDay1, TwoDay2 };

            // Didsplays the test data that is provided
            WriteLine("Parcels in route");
            WriteLine(" ");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine(" ");
            }
            Pause();

            // Parcels by destination Zipcode in descending order
            var parcelsByZipcode = from p in parcels
                                   orderby p.Destination.Zipcode descending
                                   select p;

            WriteLine("Parcels by destination zipcode in descending order:");
            WriteLine(" ");

            foreach (Parcel p in parcelsByZipcode)
            {
                WriteLine(p);
                WriteLine(" ");
            }
            Pause();

            // Parcels by cost
            var parcelsByCost = from p in parcels
                                orderby p.CalcCost()
                                select p;

            WriteLine("Parcels by cost in ascending order:");
            WriteLine(" ");

            foreach (Parcel p in parcelsByCost)
            {
                WriteLine(p);
                WriteLine(" ");
            }
            Pause();

            // Parcels by type and cost in descending order
            var parcelsByTandC = from p in parcels
                                 orderby p.GetType().ToString(), p.CalcCost() descending
                                 select p;

            WriteLine("Parcels by type and cost in descending order:");
            WriteLine(" ");

            foreach (Parcel p in parcelsByTandC)
            {
                WriteLine(p);
                WriteLine(" ");
            }
            Pause();

            // Heavy air packages by weight in descending order
            var heavyAirPackage = from p in parcels
                                  where (p is AirPackage) && ((AirPackage)p).IsHeavy()
                                  orderby ((AirPackage)p).Weight descending
                                  select p;

            WriteLine("Heavy air packages by weight in descending order:");
            WriteLine(" ");

            foreach (Parcel p in heavyAirPackage)
            {
                WriteLine(p);
                WriteLine(" ");
            }
        }
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
