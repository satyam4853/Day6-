using System;

namespace reversenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());
            int reverse = 0;
            int remainder;
            while(number!=0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number/10;

            }
            Console.WriteLine("reverse number is :" + reverse);

        }
    }
}
