using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    /*
     * 
     * Mapping : It is the collection of key and value pairs and they are generics.
     * In key and value pairs keys can't duplicate, but values can be duplicate.
     * It gives exception if we add duplicate keys.
     * 
     * In order work with mapping we use classes like SortedList, Dictonary, Sorted Dictonary 
     * these are also works like Collection and Generics.(Adding,removing,sorting,edit)
     * 
     */
    internal class Class4
    {
        static void Main (string[] args)
        {
            SortedList s = new SortedList();
            
            Console.WriteLine($"No of elements present in the sortedlist : {s.Count}");
           
            s.Add(1, "kiran");
            s.Add(2, "raj");
            s.Add(4, "vijay");
            s.Add(3, "purnima");
            s.Add(5, "priya");
            s.Add(6, "raj");
            Console.WriteLine($"No of elements present in the sortedlist after adding  : {s.Count}");
            Console.WriteLine("keys present in the Sorted List");
            foreach (int i in s.Keys)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Valuues present in the Sorted List");
            foreach (string v in s.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Key and Value Pairs");
            foreach(int key in s.Keys)
            {
                Console.WriteLine($"{key}====>{s[key]}");
            }
            Console.WriteLine("Displaying the Sorted List Key-Value Pairs Using Index");
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine($"{i}    {s.GetKey(i)}  {s.GetByIndex(i)}");
            }
        }
    }
}
