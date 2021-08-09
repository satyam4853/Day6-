using System;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number to check whether is prime or not");
            number = int.Parse(Console.ReadLine());
            bool flag = true;
            

            for (int i = 2; i < number; i++)
            {
               
                if ( number % i == 0)
                {
                    flag = false;
                    break;
                }

                
                
            }
            if (flag)
            {
                Console.WriteLine("number is prime" + number);
            }
            else
            {
                Console.WriteLine("number is not prime" + number);
            }

        }
    }
}
