using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFExmple
{
    internal class Program
    {
        static void Main (string[] args)
        {
            faculty fac = new faculty();
            BusinessLogic bl = new BusinessLogic();
            Menu:
            Console.Write("1.Add\n2.Delete\n3.Update\n4.Find\n5.Find All\nEnter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Faculty Id  : ");
                    fac.fid = int.Parse (Console.ReadLine());
                    Console.Write("Enter Facult Name : ");
                    fac.fname = Console.ReadLine();
                    Console.Write("Enter Faculty Salary : ");
                    fac.fsal = int.Parse (Console.ReadLine());
                    if (bl.RegisterFculty(fac))
                    {
                        Console.WriteLine("Faculty Added..");
                    }
                    else
                    {
                        Console.WriteLine("Failed to Add Faculty..");
                    }
                    goto Menu;
                case 2:
                    if (bl.GetAllFaculty().Count > 0)
                    {
                        Console.Write("Enter Faculty Id  : ");
                        fac.fid = int.Parse(Console.ReadLine());
                        if (bl.CheckFaulty(fac))
                        {
                            if (bl.DeleteFaculty(fac))
                            {
                                Console.WriteLine("Faculty Deleted");
                            }
                            else
                            {
                                Console.WriteLine("Failed To Delete");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found With The Given ID");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found");
                    }
                    goto Menu;
                case 3:
                    if (bl.GetAllFaculty().Count > 0)
                    {
                        Console.Write("Enter Faculty Id  : ");
                        fac.fid = int.Parse(Console.ReadLine());
                        if (bl.CheckFaulty(fac))
                        {
                            Console.Write("Enter Facult Name : ");
                            fac.fname = Console.ReadLine();
                            Console.Write("Enter Faculty Salary : ");
                            fac.fsal = int.Parse(Console.ReadLine());
                            if (bl.UpdateFaculty(fac))
                            {
                                Console.WriteLine("Faculty Updated Successfullly");
                            }
                            else
                            {
                                Console.WriteLine("Failed To Update the Faculty");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Record Found With The Given ID");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found");
                    }

                        goto Menu;
                case 4:
                    if (bl.GetAllFaculty().Count > 0)
                    {
                        Console.Write("Enter Faculty Id  : ");
                        fac.fid = int.Parse(Console.ReadLine());
                        if (bl.CheckFaulty(fac))
                        {
                            fac = bl.GetFacultyById(fac);
                            Console.WriteLine(fac);
                        }
                        else
                        {
                            Console.WriteLine("Faculty not Avaiable with the Given Id");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Avaialbe");
                    }
                    goto Menu;
                case 5:
                    if (bl.GetAllFaculty().Count > 0)
                    {
                        foreach(faculty fa in bl.GetAllFaculty())
                        {
                            Console.WriteLine(fa);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Records Not Found");
                    }
                    goto Menu;
                default:
                    goto Menu;


            }
        }
                   
    }
}
