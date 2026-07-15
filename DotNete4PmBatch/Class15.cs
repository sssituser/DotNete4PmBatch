using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DotNete4PmBatch
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Age : ");
            string age = Console.ReadLine();
            Console.Write("Enter Education : ");
            string edu = Console.ReadLine();   // Reading

            Console.WriteLine("=======Entered Details Are========="); // Display
            Console.WriteLine($"Name : {name}\nAge : {age}\nQualification : {edu}");




        }
    }
}
