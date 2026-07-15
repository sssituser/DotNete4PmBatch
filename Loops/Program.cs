using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1, end = 10;
            while(start<= end)
            {
                Console.WriteLine($"{start} . WELCOME TO SSSIT");
                start++;
            }
        }
    }
}
