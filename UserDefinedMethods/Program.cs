using System; //lib

namespace UserDefinedMethods // application
{
    internal class Program  // class declaration
    {
        public static int AddNumbers(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int DiffNumbers(int num1, int num2) 
        {
            return num1 - num2;
        }
        public static int MulNumbers(int num1, int num2)
        {
            
            return num1 * num2;
        }
        static void Main(string[] args) // MainMethods PascalNaming Convention
        {
            int res = AddNumbers(5,2);
            Console.WriteLine(res);
            Console.WriteLine(DiffNumbers(6,5));
            Console.WriteLine(MulNumbers(6,5));
        }
    }
}
