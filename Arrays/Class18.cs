using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // PREDEINFED NAMESPACES OR .DLL FILE PUBLIC ASSEMBLIES

namespace Arrays   // APPLICATION (USERDEFINED NAMESPACE)
{
    internal class Class18  // CLASS DECLARATION
    {
        static void Main(string[] args)
        {
            int[] a = {33,45,77,89,99 };
             a.Where(x=>x%2==0).ToList().ForEach(x=>Console.WriteLine(x));
        }
    }
}
