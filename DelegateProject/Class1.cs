using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Sample<int>.Show(200);
            Sample<double>.Show(45.6);
            Sample<string>.Show("Test");
            Sample<bool>.Show(false);
            Sample<char>.Show('+');
        }
    }
}
