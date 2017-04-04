using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            Console.Write("Enter 5 numbers separated by a space: ");

            int i = 0;
            foreach(String s in Console.ReadLine().Split(' '))
            {
                numbers[i] = double.Parse(s);
                ++i;
            }

            Console.WriteLine("The numbers in reverse are: ");

            for(int j = 4; j >= 0; --j)
            {
                Console.WriteLine(numbers[j]);
            }

            Console.ReadLine();
        }
    }
}
