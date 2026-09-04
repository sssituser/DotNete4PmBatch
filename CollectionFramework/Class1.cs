using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Queue<int> queue = new Queue<int>();
            int element ;
        Menu:
            Console.Write("1.Insert\n2.Delete\n3.Check \n4.Elements Count\n5.Display\n6.Top Element\nEnter Choice : ");
            int ch = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (ch)
            {
                case 1:
                    Console.Write("Enter Element : ");
                    element =int.Parse(Console.ReadLine());
                    queue.Enqueue(element);
                    Console.WriteLine($"{element} is Added to the Queue");
                    goto Menu;
                case 2:

                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No Elements Present In the Queue to Delete");
                    }
                    else
                    {

                        Console.WriteLine($"Deleted Element is : {queue.Dequeue()}");
                    }
                    goto Menu;
                case 3:
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No Elements in the Queue");
                    }
                    else
                    {
                        Console.Write("Enter Element : ");
                        element = int.Parse(Console.ReadLine());
                        if (queue.Contains(element))
                        {
                            Console.WriteLine($"Given Elment {element} Present In the Queue");
                        }
                        else
                        {
                            Console.WriteLine($"Given Element {element} is Not Present in the Queue");
                        }
                    }
                    goto Menu;
                case 4:
                    Console.WriteLine($"Elements Count In the Queue are : {queue.Count}");
                    goto Menu;
                case 5:
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No Eelments in the Queue");
                    }
                    else
                    {
                        foreach (var item in queue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                case 6:
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No Eelments in the Queue");
                    }
                    else
                    {
                        Console.WriteLine($"Top Element In the Queue : {queue.Peek()}");
                    }
                    goto Menu;

                default:
                    Console.WriteLine("Invalid Choice...");
                    goto Menu;
            }
        }
    }
}
