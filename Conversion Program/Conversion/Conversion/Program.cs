using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceMeters = 0;
            double timeSeconds = 0;
            
            Console.Write("Distance travelled in meters: ");
            distanceMeters = double.Parse(Console.ReadLine());

            Console.Write("Hours taken: ");
            timeSeconds += int.Parse(Console.ReadLine()) * 60 * 60;

            Console.Write("Minutes taken: ");
            timeSeconds += int.Parse(Console.ReadLine()) * 60;

            Console.Write("Seconds taken: ");
            timeSeconds += int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("You travelled at {0:.##} m/s, {1} km/h and {2} miles/h", getSpeed(distanceMeters,timeSeconds), getSpeed(distanceMeters/1000,timeSeconds/60/60), getSpeed(distanceMeters/1609, timeSeconds/60/60));

            Console.ReadLine();
        }

        

        private static double getSpeed(double distance, double time)
        {
            return distance/time;
        }
    }
}
