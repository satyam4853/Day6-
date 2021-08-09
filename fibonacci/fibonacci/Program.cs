using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            
            int number;
            Console.WriteLine("Enter the number:");
            number = int.Parse(Console.ReadLine());
            for (int i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine("value of n3" + n3);
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
