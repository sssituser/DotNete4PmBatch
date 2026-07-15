using System;
namespace Loops
{
    internal class Class15
    {

        static void Main(string[] args)
        {
            Console.Write("Enter numbere : ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int copy = num;
            int sum = 0;
            count = (num + "").Length;
            while (num > 0) 
            {
                int digit = num % 10;
                int start = 1, res = 1;
                while (start <= count)
                {
                    res = res * digit; 
                    start++; 
                }
                sum = sum + res; 
                num /= 10;

            }
            if (copy == sum)
            {
                Console.WriteLine($"{copy} is An Armstrong number ");
            }
            else
            {
                Console.WriteLine($"{copy} is not An Armstrong number");
            }
        }
    }
}
