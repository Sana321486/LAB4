using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip trip = new Trip("England", 400, 70, 20);
            trip.DisplayTripDetails();
        }
    }
}
