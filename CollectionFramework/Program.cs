using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack st = new Stack();
            string element = string.Empty;
            Menu:
            Console.Write("1.Insert\n2.Delete\n3.Check \n4.Elements Count\n5.Display\nEnter Choice : ");
            int ch = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (ch)
            {
                case 1:
                    Console.Write("Enter Element : ");
                    element = Console.ReadLine();
                    st.Push(element);
                    Console.WriteLine($"{element} is Added to the Stack");
                    goto Menu;
                case 2:
                  
                    if(st.Count== 0)
                    {
                        Console.WriteLine("No Elements Present In the Stack to Delete");
                    }
                    else
                    {
                     
                        Console.WriteLine($"Deleted Element is : {st.Pop()}");
                    }
                    goto Menu;
                case 3:
                    if (st.Count == 0)
                    {
                        Console.WriteLine("No Elements in the Stak");
                    }
                    else
                    {
                        Console.Write("Enter Element : ");
                        element = Console.ReadLine();
                        if (st.Contains(element))
                        {
                            Console.WriteLine($"Given Elment {element} Present In the Stack");
                        }
                        else
                        {
                            Console.WriteLine($"Given Element {element} is Not Present in the Stack");
                        }
                    }
                    goto Menu;
                case 4:
                    Console.WriteLine($"Elements Count In the Stack are : {st.Count}");
                    goto Menu;
                case 5:
                    if(st.Count== 0)
                    {
                        Console.WriteLine("No Eelments in the stack");
                    }
                    else
                    {
                        foreach (var item in st)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                default:
                    Console.WriteLine("Invalid Choice...");
                    goto Menu;
            }
        }
    }
}
