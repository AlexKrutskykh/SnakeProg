using System;
using System.Collections.Generic;

namespace SnakeProg
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Lesson> lessons = new List<Lesson>();
            Lesson1 lesson1 = new Lesson1();
            Lesson2 lesson2 = new Lesson2();
   
            lessons.Add(lesson1);
            lessons.Add(lesson2);

            
            





            MainMenu(lessons);

            

        }


        public static void MainMenu(List<Lesson> list)
        {
            int counter = 1;
            int lessonNumber;
            int taskNumber;
            bool condition = true;


            while (condition)
            {
                Console.Clear();
                Console.WriteLine($"Main menu");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{counter}.{list[i].LessonDescription}");
                    counter++;
                }

                Console.WriteLine($"Enter Lesson number");
                Int32.TryParse(Console.ReadLine().ToString(), out lessonNumber);
                //check entered num is within the range list num
                while (lessonNumber < 0 || lessonNumber > list.Count)
                {
                    Console.WriteLine($"Enter correct number for Lesson");
                    Int32.TryParse(Console.ReadLine().ToString(), out lessonNumber);
                }
                counter = 1;
                lessonNumber = lessonNumber - 1;

                for (int i = 0; i < list[lessonNumber].Tasks.Count; i++)
                {
                    Console.WriteLine($"{counter}.{list[lessonNumber].Tasks[i].TaskDescription}");
                    counter++;
                }

                Console.WriteLine($"Enter Task number");
                Int32.TryParse(Console.ReadLine().ToString(), out taskNumber);
                //check entered num is within the range list num
                while ((taskNumber < 0 ) || taskNumber > list[lessonNumber].Tasks.Count)
                {
                    Console.WriteLine($"Enter correct number for Task");
                    Int32.TryParse(Console.ReadLine().ToString(), out taskNumber);
                }
                counter = 1;
                taskNumber = taskNumber - 1;



                switch (lessonNumber, taskNumber)
                {
                    case (0, 0):

                        list[lessonNumber].TasksRun(taskNumber);
                        condition = GetContinueOrExit();
                        break;

                    case (0, 1):
                        list[lessonNumber].TasksRun(taskNumber);
                        condition = GetContinueOrExit();
                        break;
                    case (1, 0):
                        list[lessonNumber].TasksRun(taskNumber);
                        condition = GetContinueOrExit();
                        break;
                   




                    default:
                        break;

                }
            }
        }
        public static bool GetContinueOrExit()
        {
            bool condition = false;
            Console.WriteLine($"Press Enter to Continue or any other key to Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter) { condition = true; }
            else { condition = false; }
            return condition;
        }


    }
}
