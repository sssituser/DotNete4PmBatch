using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Temparture : ");
            int temp = int.Parse(Console.ReadLine());
            if (temp >= 20)
            {
                if (temp < 26)
                {
                    Console.WriteLine("Room Temprature is Normal");
                }
                else
                {
                    Console.WriteLine("Room Temprature is Hot ");
                }
            }
            else
            {
                Console.WriteLine("Room Temprature is Cold ");
            }
        }
    }
}
