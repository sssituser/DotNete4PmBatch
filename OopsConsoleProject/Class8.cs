using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    class Area
    {
        private int length;

        private int breadh;

        private int side;
        private double radius;

    

        public int AreaOfRectangle
        {
            get { return length*breadh; }
            
        }
        public int AreaOfSquare
        {
            get
            {
                return side * side;
            }
            
         }

        public double AreaOfCirle
        {
            get
            {
                return 3.14 * radius * radius;
            }
        }
        public double Radius
        {
           
            set { radius = value; }
        }

        public int Side
        {
           
            set { side = value; }
        }

        public int Breadh
        {
           
            set { breadh = value; }
        }

        public int Length
        {
            
            set { length = value; }
        }

    }
    internal class Class8
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            a.Length = 5;
            a.Breadh = 4;
            a.Side = 6;
            a.Radius = 5.6;


            Console.WriteLine(a.AreaOfRectangle);
            Console.WriteLine(a.AreaOfSquare);
            Console.WriteLine(a.AreaOfCirle);
        }
    }
}
