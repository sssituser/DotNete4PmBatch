using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Runtime;

namespace FileHandling
{
    internal class Class7
    {

        static void Main(string[] args)
        {

        Menu:
            Console.Write("1.Create\n2.Delete\n3.Append\n4.Read\nEnter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter File Name With Loc : ");
                    string fname = Console.ReadLine();
                    Console.WriteLine("-----------Enter Your Information---------");
                    string info = string.Empty;
                    StreamWriter sw = new StreamWriter(fname);
                    while (!string.IsNullOrEmpty(info = Console.ReadLine()))
                    {
                        sw.WriteLine(info);
                    }
                    sw.Close();
                    sw.Dispose();
                    goto Menu;
                case 2:
                    Console.Write("Enter File Name With Loc : ");
                    fname = Console.ReadLine();
                    FileInfo finfo = new FileInfo(fname);
                    if (finfo.Exists)
                    {
                        finfo.Delete();
                        Console.WriteLine("File Deleted Successfully..");
                    }
                    else
                    {
                        Console.WriteLine("File Not Found");
                    }
                    goto Menu;
                case 3:
                    Console.Write("Enter File Name : ");
                    fname = Console.ReadLine();
                    
                    finfo = new FileInfo(fname);
                    if (finfo.Exists)
                    {
                        FileStream fs = new FileStream(fname, FileMode.Append, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        Console.WriteLine("=====Enter Your Information==========");
                        while (!string.IsNullOrEmpty(info = Console.ReadLine()))
                        {
                            sw.WriteLine(info);
                        }
                        sw.Close();
                        Console.WriteLine("Infomraiton Saved....");


                    }
                    else
                    {
                        Console.WriteLine("File Not Found");
                    }


                    goto Menu;

                case 4:
                    Console.Write("Enter File Name : ");
                    fname = Console.ReadLine();
                    finfo = new FileInfo(fname);
                   
                    if (finfo.Exists)
                    {
                        StreamReader sr = new StreamReader(fname);
                        Console.WriteLine(sr.ReadToEnd());
                        sr.Close();
                        sr.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("File Not Found....");
                    }
                   
                    goto Menu;
                default:
                    Console.WriteLine("Invalid chooice.....");
                    break;
            }

        }
    }
}
