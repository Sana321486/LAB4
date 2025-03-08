using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Question_1
{
    internal class Trip
    {
        public string destination;
        public double distancetravelled;
        public double totalcostofGasoline;
        public double numofGallonsconsumed;
        public Trip(string destination, double distancetravelled, double totalcostofGasoline, double numofGallonsconsumed)
        {
            this.destination = destination;
            this.distancetravelled = distancetravelled;
            this.totalcostofGasoline = totalcostofGasoline;
            this.numofGallonsconsumed = numofGallonsconsumed;
        }
        public double milespergallon()
        {
           return distancetravelled / numofGallonsconsumed;
        }
        public double costpermile()
        {
            return totalcostofGasoline / distancetravelled;
        }
        public void DisplayTripDetails()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("\tTrip details are as follow:");
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Distance Travelled: {distancetravelled}");
            Console.WriteLine($"Total Cost of Gasoline: {totalcostofGasoline}");
            Console.WriteLine($"Number of Gallons Consumed: {numofGallonsconsumed}");
            Console.WriteLine($"Miles Per Gallon: {milespergallon()}");
            Console.WriteLine($"Cost Per Mile: {costpermile()}");
        }
    }
   
}
