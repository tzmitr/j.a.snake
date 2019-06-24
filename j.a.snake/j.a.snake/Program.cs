﻿using System;
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

            Draw(1, 2, '*');
            Draw(5, 7, '*');

            Console.ReadLine();
        }

        static void Draw(int x , int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }

    }
}
