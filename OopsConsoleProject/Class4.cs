using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.StudentId = 111;
            s1.StudentName = "Test";
            s1.Marks = 450;

            Console.WriteLine($"Student ID      :{s1.StudentId}");
            Console.WriteLine($"Student Name    :{s1.StudentName}");
            Console.WriteLine($"Student Marks   :{s1.Marks}");
            Console.WriteLine($"College Name    :{Student.CollegeName}");
            Console.WriteLine($"College Address :{Student.Address}");
            
            
        }
    }
}
