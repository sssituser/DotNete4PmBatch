using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Brother1===================");
            Home br1 = new Home();
            br1.ShowBalance();
            br1.Spent();
            br1.ShowBalance();
            Console.WriteLine("================Brother2===================");
           
            Home br2 = new Home();

            br2.ShowBalance();//8000
            br2.Spent();
            br2.ShowBalance();
        }
    }
}
