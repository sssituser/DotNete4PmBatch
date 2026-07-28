using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    class Test
    {
        public static string firstName;
        public  static string lastName;
        public static int age;
    }
    internal class Class1
    {
        static void Main(string[] args)
        {

            Test.firstName = "abc";
            Test.lastName = "def";
            Test.age = 16;
            Console.WriteLine(Test.firstName);
            Console.WriteLine(Test.lastName);
            Console.WriteLine(Test.age);
        }
    }
}
