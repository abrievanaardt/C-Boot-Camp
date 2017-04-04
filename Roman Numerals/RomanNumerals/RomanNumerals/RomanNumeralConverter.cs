using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{


    public class RomanNumeralConverter
    {
        public static readonly Dictionary<char, long> numeralMap = new Dictionary<char, long>()
        {
            {'M', 1000},
            {'D', 500 },
            {'C', 100 },
            {'L', 50 },
            {'X', 10 },
            {'V', 5 },
            {'I', 1 }
        };

        public static long Convert(String roman)
        {
            if (roman.Length == 1)
            return numeralMap[roman[0]];

            char prevChar = roman[roman.Length - 1];
            long finalVal = numeralMap[prevChar];

            for (int i = roman.Length - 2; i >= 0; i--)
            {
                char currentChar = roman[i];

                if (numeralMap[currentChar] >= numeralMap[prevChar])
                    finalVal += numeralMap[currentChar];
                else
                    finalVal -= numeralMap[currentChar];

                prevChar = currentChar;
            }

            return finalVal;

        }

    }
}



