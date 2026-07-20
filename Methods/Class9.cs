using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class9
    {
        // AM : public static   // PM : two integer parameters    // RT : 1 integer      // MN : Power
        public static long Power(long basee, long power) // 5   3
        {
            long res = 1;
            for (int i = 1; i <= power; i++)
            {
                res = res * basee; 
            }
            return res;

        }
        static void Main(string[] args)
        {
          
            Console.WriteLine(Power(5,3));
            Console.WriteLine(Power(3,3));
            Console.WriteLine(Power(2,32));
        }
    }
}
