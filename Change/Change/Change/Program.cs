using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Price: ");
            var price = int.Parse(Console.ReadLine());

            Console.Write("Paid: ");
            var paid = int.Parse(Console.ReadLine());

            int totalChange = 0;
            int remainingDiff = paid - price;

            do
            {
                if (remainingDiff >= 100)
                {
                    update(ref totalChange, ref remainingDiff, 100);
                } else if (remainingDiff >= 50) 
                {
                    update(ref totalChange, ref remainingDiff, 50);
                }
                else if (remainingDiff >= 20)
                {
                    update(ref totalChange, ref remainingDiff, 20);
                }
                else if (remainingDiff >= 10) {
                    update(ref totalChange, ref remainingDiff, 10);
                }
                else if (remainingDiff >= 5)
                {
                    update(ref totalChange, ref remainingDiff, 5);
                }
                else if (remainingDiff >= 2)
                {
                    update(ref totalChange, ref remainingDiff, 2);
                }
                else if (remainingDiff >= 1)
                {
                    update(ref totalChange, ref remainingDiff, 1);
                }
                else
                {
                    Console.WriteLine();
                }

            } while (price != paid - totalChange);

            Console.ReadLine();

        }

        private static void update(ref int change, ref int remainingDiff, int bill)
        {
            change += bill;
            remainingDiff -= bill;
            Console.Write(bill + " ");            
        }
    }
}
