using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{


    //Write program to find the frequency of the characters for the given name
    // name = "aabcd"  a -2 b - 1 c - 1 d - 1
    internal class Class5
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Dictionary<char,int> frechacater = new Dictionary<char,int>();
            Console.WriteLine($"No Elements : {frechacater.Count}");
            foreach(char k in name) // name = aabc   frechacater=[a,1]
            {
                if (frechacater.ContainsKey(k))
                {
                    int val = frechacater[k];
                    frechacater.Remove(k);
                    frechacater.Add(k, val+1);
                }
                else
                {
                    frechacater.Add(k, 1);
                }
            }
            Console.WriteLine("Frequency of Character for the given name ");
            foreach (KeyValuePair<char,int> keyValuePair in frechacater)
            {
                Console.WriteLine(keyValuePair);
            }
        }
    }
}
