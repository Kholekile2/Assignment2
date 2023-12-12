using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2
{
    internal class ConvertNumbersToWords
    {
        public static string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", };
        public static string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public static string[] tens = { "", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", };


        public static string ConvertNumbers(int inputNumber) =>
            inputNumber == 0 ? " " :
            inputNumber < 10 ? units[inputNumber] :
            inputNumber < 20 ? teens[inputNumber - 11] :
            inputNumber < 100 ? $"{tens[inputNumber / 10]} {units[inputNumber % 10]}" :
            inputNumber <= 9999 ? $"{units[inputNumber / 1000]} Thousand {units[inputNumber / 100 % 10]} hundred and {tens[inputNumber /10 % 10]} {units[inputNumber % 10]}" :
            $"{units[inputNumber / 1000]} hundres {ConvertNumbers(inputNumber % 1000)}";

        public static string NumbersToWords(int numbers)
        {
            if (numbers == 0)
            {
                return "zero";
            }
            return ConvertNumbers(numbers).Trim();
        }
    }
}
