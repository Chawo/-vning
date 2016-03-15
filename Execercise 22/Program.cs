using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_22
{
    

    class Program
    {

        struct Coordinate
        {
            public int X;
            public int Y;
        }


        static void Main(string[] args)
        {
            Coordinate c = new Coordinate();
            c.X = 5;
            c.Y = 5;

            Coordinate cc = new Coordinate();
            cc.X = 20;
            cc.Y = 20;

            Console.WriteLine($"c.X = {c.X}, c.Y = {c.Y}");
            Console.WriteLine($"cc.X = {cc.X}, cc.Y = {cc.Y}");

            //Console.WriteLine(c.X + " " + c.Y);
            //Console.WriteLine(cc.X + " "+ cc.Y);
        }


    }
}
