using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppErrors.CustomException
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Marks : ");
                    int marks = int.Parse(Console.ReadLine());
                    if (marks < 0 || marks > 100)
                    {
                        throw new InvalidMarksException("Marks Can't be lessthan 0 or Greater than 100");
                    }
                    if (marks < 35)
                    {
                        Console.WriteLine("Failed in the Exam");
                    }
                    else
                    {
                        Console.WriteLine("Passed in the Exam");
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error Occured : {ex.Message}");
                }
            }
        }
    }
}
