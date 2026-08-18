using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppErrors
{
    internal class Class1
    {
        static void Main(string[] args)
        {


            while (true)
            {
                try
                {
                    Console.Write("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("num2 can't be zero");
                    }

                    Console.WriteLine($"Div is : {num1 / num2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Enter Only Integers");
                }
                catch (DivideByZeroException dex)
                {
                    Console.WriteLine(dex.Message);
                }
                finally
                {
                    Console.WriteLine("Thank You Try Again........");
                }
               
            }

        }
    }
}
// ClassName ref = new ClassName()
//  int   x  = 10;