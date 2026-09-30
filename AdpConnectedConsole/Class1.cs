using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpConnectedConsole
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            BusinessLogicLayer bl = new BusinessLogicLayer();
            Menu:
            Console.Write("1.Add\n2.Delete\n3.Update\n4.GetAll\n5.Find  ::: Enter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Marks : ");
                    int marks = int.Parse(Console.ReadLine());
                    Console.WriteLine(bl.AddStudent(id, name, marks) ? "Stuent Added" : "Failed to Add Student");
                    goto Menu;
                case 2:
                    if (bl.GetStudents().Tables["Student"].Rows.Count > 0)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        if (bl.CheckStudent(id))
                        {
                            Console.WriteLine(bl.DeleteStudentById(id) ? "Student Deleted" : "Failed to Delete");
                        }
                        else
                        {
                            Console.WriteLine($"Student Does not Registered with id :{id}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Records not available");
                    }
                    goto Menu;
                case 3:

                    if (bl.GetStudents().Tables["Student"].Rows.Count > 0)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        if (bl.CheckStudent(id))
                        {
                            Console.Write("Enter Name : ");
                            name = Console.ReadLine();
                            Console.Write("Enter Marks : ");
                            marks = int.Parse(Console.ReadLine());
                            Console.WriteLine(bl.UpdateStudent(id, name, marks) ? "Record updated" : "Failed to update");
                        }
                        else
                        {
                            Console.WriteLine($"Student with the id :{id} not available");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Records not available");
                    }
                    goto Menu;
                case 4:
                    if (bl.GetStudents().Tables["student"].Rows.Count > 0)
                    {
                        Console.WriteLine("ID\tName\tMarks");
                        foreach (DataRow row in bl.GetStudents().Tables["student"].Rows)
                        {
                            Console.WriteLine($"{row["stid"]}\t{row["stname"]}\t{row["smarks"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Records not available");
                    }
                    goto Menu;

                case 5:
                    if (bl.GetStudents().Tables["student"].Rows.Count > 0)
                    {
                        Console.Write("Enter ID : ");
                        id = int.Parse(Console.ReadLine());
                        if (bl.CheckStudent(id))
                        {
                            DataRow row = bl.FindStudentById(id);
                            Console.WriteLine($"Student ID : {row["stid"]}");
                            Console.WriteLine($"Student Name : {row["stname"]}");
                            Console.WriteLine($"Student Marks : {row["smarks"]}");
                        }
                        else
                        {
                            Console.WriteLine($"Student with the id :{id} not available");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Records Not Available...");
                    }

                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice...");
                    break;

            }

        }
    }
}
