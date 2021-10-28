using System;
using System.Collections.Generic;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3,5,'$');
            p1.Draw();

            Point p2 = new Point(5,8,'%');
            p2.Draw();

            Point p3 = new Point(9, 5, '#');
            p3.Draw();

            Point p4 = new Point(6, 9, '&');
            p4.Draw();


            List<Point> pointsList = new List<Point>();
            pointsList.Add(p1);
            pointsList.Add(p2);
            pointsList.Add(p3);
            pointsList.Add(p4);

            Console.WriteLine(pointsList);

            /* var x1 = 3;
             var y1 = 4;
             var sym1 = '*';

             Draw(x1, y1, sym1);

             var x2 = 4;
             var y2 = 7;
             var sym2 = '#';


             Draw( x2, y2, sym2);*/


        }

        




    }
}
