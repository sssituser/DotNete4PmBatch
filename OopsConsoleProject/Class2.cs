using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    class Sample
    {
        public int sId;
        internal string sName; // camel case naming convetion
        internal int sAge;

    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            s1.sId = 111;  // Assigning the data writing the data
            s1.sName = "kiran";
            s1.sAge = 12;

            Console.WriteLine(s1.sId); // Reading the data
            Console.WriteLine(s1.sName);
            Console.WriteLine(s1.sAge);

            Sample s2 = new Sample();
            s2.sId = 2;
            s2.sName = "Raj";
            s2.sAge = 14;
            Console.WriteLine(s2.sId);
            Console.WriteLine(s2.sName);
            Console.WriteLine(s2.sAge);
        }
    }
}
