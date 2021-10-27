using System;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = 3;
            var y1 = 4;
            var sym1 = '*';

            Drow(x1, y1, sym1);

            var x2 = 4;
            var y2 = 7;
            var sym2 = '#';


            Drow( x2, y2, sym2);


        }

        static void Drow (int x , int y , char sym )
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);

        }




    }
}
