using MySystem;
using System;


namespace FileHandling   // Application
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            MyConsole.MyWriteLine("=========This is Example For Library================");
            MyConsole.MyWrite("Enter an Integer : ");
            int num = MyConsole.ReadInt();
            MyConsole.MyWrite("Enter a Double Value : ");
            double dnum = MyConsole.ReadDouble();

            MyConsole.MyWriteLine($"{new MyNums().IsPalindrome(num)}");
            MyConsole.MyWriteLine($"{new MyNums().Square(num)}");
            MyConsole.MyWriteLine($"{new MyNums().Reverse(num)}");
            MyConsole.MyWriteLine($"{new MyNums().IsAdam(num)}");
        }
    }
}
