using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{

    class Movie
    {//Auto Implemented Properties
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public double MovieRating { get; set; }
    }



    internal class Class7
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.MovieId = 111;
            m1.MovieName = "Chandramukhi";
            m1.MovieRating = 4.5;
            Console.WriteLine(m1.MovieId);
            Console.WriteLine(m1.MovieName);
            Console.WriteLine(m1.MovieRating);

        }
    }
}
