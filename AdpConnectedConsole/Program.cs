using System;
using System.Data;

namespace AdpConnectedConsole
{
    internal class Program
    {
      
        static void Main (string[] args)
        {
            int id, sal;
            string name;
            Menu:
            Console.Write("1.Add\n2.Delete\n3.Update\n4.ShowAll\n5.Exit\nEnter Your choice : ");
            int choice =int.Parse(Console.ReadLine());
            BusinessAccessLayer bl = new BusinessAccessLayer();
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter ID : ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter Sal : ");
                    sal = int.Parse(Console.ReadLine());
                    if (bl.RegisterEmployee(id, name, sal))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Record Added...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Failed to add...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    goto Menu;
                case 2:
                    if (bl.GetEmployees().Rows.Count > 0)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        if (bl.DeleteEmployeeById(id))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Employee deleted");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Employees Present");
                    }
                    goto Menu;
                case 3:
                    if (bl.GetEmployees().Rows.Count > 0)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name : ");
                        name = Console.ReadLine();
                        Console.Write("Enter Sal : ");
                        sal = int.Parse(Console.ReadLine());
                        if (bl.EditEmployee(id, name, sal))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Record Updated...");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Failed to Update...");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("No Employees...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    goto Menu;
                case 4:
                    
                    DataTable dt = bl.GetEmployees();
                   
                    if (dt.Rows.Count > 0)
                    {
                        Console.WriteLine($"EmployeeId\tEmployeeName\tEmployeeSalary");
                        foreach(DataRow row in dt.Rows)
                        {
                            Console.WriteLine($"{row[0]}\t\t{row[1]}\t\t{row[2]}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("No Employees...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    goto Menu;
                case 5:
                    Console.WriteLine("Press any to key to Exit...");
                    break;
                default:
                    Console.WriteLine("Invalid choice...");
                    goto Menu;
            }
        }
    }
}
