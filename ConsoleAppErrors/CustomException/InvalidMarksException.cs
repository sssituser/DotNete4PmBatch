using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppErrors.CustomException
{
    internal class InvalidMarksException:Exception
    {
        public InvalidMarksException()
        {
            Console.WriteLine($"{base.GetType()}");
        }
        public InvalidMarksException(string message) : base(message)
        {
        }
    }
}
