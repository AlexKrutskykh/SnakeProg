using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    public class Lesson1Task1 : Task
    {
        //public string Description { get; set; }

        public Lesson1Task1()
        {
           TaskDescription = "Task 1 - Check if the number is prime";
            

        }

        private bool IsPrime(int number)
        {
           
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetNumber()
        {
            Console.WriteLine("Enter the number to check if it is prime:");
            int input = Int32.Parse(Console.ReadLine());
            if (IsPrime(input) == true)
            {
                Console.WriteLine($"Number {input} is prime number\n");
            }
            else
            {
                Console.WriteLine($"Number {input} is not prime number\n");
            }
        }

        public void CheckIsPrimePositiveTest()
        {
            if (IsPrime(23) == true)
            {
                Console.WriteLine("Positive test passed\n");
            }
            else
            {
                Console.WriteLine("Positive test failed\n");
            }
        }

        public void CheckIsPrimeNegativeTest()
        {
            if (IsPrime(0) == false)
            {
                Console.WriteLine("Negative test passed\n");
            }
            else
            {
                Console.WriteLine("Negative test failed\n");
            }
        }



    }
}
