using System;



namespace SnakeProg
{
    public class Lesson1 : Lesson
    {
        protected Lesson1Task1 task1 = new Lesson1Task1();
        protected Lesson1Task2 task2 = new Lesson1Task2();

        public Lesson1()
        {
            LessonDescription = "Lesson1 - Prime number and Fibonacci";
            Tasks.Add(task1);
            Tasks.Add(task2);


        }


        public override void TasksRun(int taskNumber)
        {
            switch (taskNumber)
            {
                case 0:
                    task1.GetNumber();
                    task1.CheckIsPrimePositiveTest();
                    task1.CheckIsPrimeNegativeTest();
                    break;
                case 1:
                    var input = task2.GetNumber();
                    Console.WriteLine($"Fibo number is:{task2.GetFibonacci(input)}");
                    Console.WriteLine($"Fibo Recursion method, number is:{task2.GetFibonacciRec(input)}");
                    break;

                default:
                    break;
            }



        }





    }
}
