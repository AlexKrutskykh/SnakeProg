using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    public class Lesson1Task2 : Task
    {
        //public string Description { get; set; }
        public Lesson1Task2()
        {
            TaskDescription = "Task 2 - Find Fibonacci number";
         
        }

        public int GetFibonacciRec(int number)
        {
            if (number == 0 || number == 1) { return number; }
            return GetFibonacciRec(number - 1) + GetFibonacciRec(number - 2);
        }

        public int GetFibonacci(int number)
        {
            
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }

        public int GetNumber()
        {
            Console.WriteLine("Enter the number to find Fibonacci number:");
            int number = Int32.Parse(Console.ReadLine());
            return number;
        }
    }



}
