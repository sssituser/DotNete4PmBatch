using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class Class16
    {
        public static string GetMaskMail(string email)
        {
            if (email.Contains("@gmail.com"))
            {
                int end = email.IndexOf("@");
                
                string res = "";
                for(int i = 2; i < end; i++)
                {

                    res = res + "x";
                   
                }

                return email.Substring(0, 2) + res + "@gmail.com";

            }
            else
            {
                return "Invalid Maild id";
            }



        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetMaskMail("vijay@gmail.com"));

        }
    }
}
