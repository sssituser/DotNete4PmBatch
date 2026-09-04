using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            List<int> numsList = new List<int>();
            int value;
        Menu:
            Console.Write("1.Add\n2.Delete\n3.Find\n4.FindAll\n5.Sort\n6.Clear AllEnter Your choice ...:");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter a Value : ");
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{value} is added to the List");
                    numsList.Add(value);
                    goto Menu;
                case 2:
                    if (numsList.Count == 0)
                    {
                        Console.WriteLine("No Elements Present In The List");
                    }
                    else
                    {
                        Console.Write("Enter a Value To Delete: ");
                        value = int.Parse(Console.ReadLine());
                        if (numsList.Remove(value))
                        {
                            Console.WriteLine($"{value} deleted from List");
                        }
                        else
                        {
                            Console.WriteLine($"{value} Not Present In the List");
                        }
                        
                    }  
                  goto Menu;
                case 3:
                    if (numsList.Count == 0)
                    {
                        Console.WriteLine("No Elements In The List");
                    }
                    else
                    {
                        Console.Write("Enter a Value : ");
                        value = int.Parse(Console.ReadLine());
                        if (numsList.Contains(value))
                        {
                            Console.WriteLine($"{value} Present in the list");
                        }
                        else
                        {
                            Console.WriteLine($"{value} Not In the list");
                        }
                    }
                    goto Menu;
                case 4:
                    
                    if (numsList.Count == 0)
                    {
                        Console.WriteLine($"Elements not Present in the list :{numsList.Count}");
                    }
                    else
                    {
                        foreach (var item in numsList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                case 5:
                    if (numsList.Count == 0)
                    {
                        Console.WriteLine($"Elements not Present in the list");
                    }
                    else
                    {
                        numsList.Sort();
                        foreach (var item in numsList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                case 6:
                    if (numsList.Count == 0)
                    {
                        Console.WriteLine("No Elements in the List");
                    }
                    else
                    {
                        numsList.Clear();
                        Console.WriteLine("All the elements deleted successfully..");
                    }
                    goto Menu;
                default:
                    Console.WriteLine("Invalid Choce");
                    goto Menu;
            }
        }
    }
}
