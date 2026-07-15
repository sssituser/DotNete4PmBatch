using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNete4PmBatch
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            // Initialize the variables  and display them
            string firstName = "Kiran Kumar";
            string fatherNme = "Kirsh";
            string motherName = "Geetha";
            string gender = "Male";
            int age = 24;
            string qual = "Grduation";
            double per = 8.7;

            Console.WriteLine("----------------------------1-Style of Displaying----------------------");
            Console.WriteLine(firstName);
            Console.WriteLine(fatherNme);
            Console.WriteLine(motherName);
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(qual);
            Console.WriteLine(per);
            Console.WriteLine("----------------------------2-Style of Displaying using Positional Prameters----------------------");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",firstName,fatherNme,motherName,gender);
            Console.WriteLine("{0}\t{1} \t{2}",age,qual,per);
            Console.WriteLine("----------------------------3-Style of Displaying string Interpolution----------------------");

            Console.WriteLine($"{firstName}\t{fatherNme}\t{motherName}\t{gender}\t{age}\t{qual}\t{per}");


        }
    }
}
