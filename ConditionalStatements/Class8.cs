using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class8
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter User Name : ");
            string uname = Console.ReadLine();
            Console.Write("Enter Password : ");
            string pwd = Console.ReadLine();
           
            if(uname =="admin" && pwd == "1234")
            {
                Console.WriteLine("Welcome Admin");
            }
            else
            {
                Console.WriteLine("Invalid Credential");
            }

        }
    }
}
