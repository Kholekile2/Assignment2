using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class NumberToWords
    {
        public static string[] units = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",};
        public static string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        public static string[] tens = {"", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety",};


        //public static string[] hundreds = {"", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
        //public static string[] thousand = { "", "one thousand", "two thousand", "three thousand", "four thousand", "five thousand", "six thousand", "seven thousand", "eight thousand", "nine thousand"};

        public static string ConvertNumbersToWords(int numbers)
        {
            if (numbers == 0)
            {
                return " ";
            }
            else if (numbers < 10)
            {
                return units[numbers];
            }
            else if(numbers < 20)
            {
               return teens[numbers - 10];
            }
            else if (numbers < 100)
            {
                return tens[numbers / 10] + " " + ConvertNumbersToWords(numbers %10);
            }
            else
            {
                return units[numbers / 100] + " hundred " + ConvertNumbersToWords(numbers % 100);
            }



            return ConvertNumbersToWords(numbers);
        }
    }
}
