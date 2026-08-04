using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    public class Home
    {
       static int TotalAmount = 10000;

        public void ShowBalance()
        {
            Console.WriteLine($"Balance : {TotalAmount}");
        }
        public void Spent()
        {
            Console.Write("Enter Amount To Spent : ");
            int spent = int.Parse(Console.ReadLine());
            TotalAmount -= spent;
        }
    }
}
