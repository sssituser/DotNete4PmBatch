using System;
using ClassLibrary;

namespace FileHandling
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            PuriSystem.ShowLine("Enter an Integer : ");
            int num = PuriSystem.NextInt();
            PuriSystem.ShowLine("Enter a Double Value : ");
            double dnum = PuriSystem.NextDouble();

            PuriSystem.ShowLine($"Entered Values are  num = {num} Dnum = {dnum}");
        }
    }
}
