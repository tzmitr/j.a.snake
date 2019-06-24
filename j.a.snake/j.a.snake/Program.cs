using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j.a.snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.Draw(1, 2, '*');
            p2.Draw(5, 7, '$');

            Console.ReadLine();
        }



    }
}
