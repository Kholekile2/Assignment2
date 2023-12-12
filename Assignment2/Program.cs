namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            //ConvertNumbersToWords converter = new ConvertNumbersToWords();

            if (number > 9999)
            {
                Console.WriteLine("Enter 4 digits or less: ");
            }
            else
            {
                string Output = ConvertNumbersToWords.NumbersToWords(number);
                Console.WriteLine($"{number} in words: {Output}");
            }
           
        }
    }
}
