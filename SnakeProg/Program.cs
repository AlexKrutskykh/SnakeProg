using System;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 5;
            p1.sym = '$';
            p1.Drow();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 8;
            p2.sym = '%';
            p2.Drow();

           
           /* var x1 = 3;
            var y1 = 4;
            var sym1 = '*';

            Drow(x1, y1, sym1);

            var x2 = 4;
            var y2 = 7;
            var sym2 = '#';


            Drow( x2, y2, sym2);*/


        }

        




    }
}
