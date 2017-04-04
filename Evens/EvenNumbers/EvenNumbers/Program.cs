using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                switch (givenNumber)
                {
                    case (0):
                        Console.WriteLine("Adding the number: 0");
                        break;
                    default:
                        if (givenNumber % 2 == 0)
                        {
                            Console.WriteLine("Adding the number: {0}", givenNumber);
                            sum += givenNumber;
                        } else
                        {
                            Console.WriteLine("Not Adding the number: {0}", givenNumber);
                        }

                        break;
                }

                --givenNumber;

            } while (givenNumber >= 0);

            Console.WriteLine("The total is: {0}", sum);

            Console.ReadLine();

        }
    }
}
