using System;
using System.Collections.Generic;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine($"What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, how are you dude? ");*/
            task1();
        }
        static void task1() {

            var fizz = "Fizz"; //devided on 3 %
            var buzz = "Buzz"; //devided on 5 %
            var fizzAndbuzz = "Fizz + Buzz";
          

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(fizzAndbuzz);
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine(fizz);
                }
                else if  (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else {
                    Console.WriteLine(i);
                }

                
            }

        } 
            
    }
}
