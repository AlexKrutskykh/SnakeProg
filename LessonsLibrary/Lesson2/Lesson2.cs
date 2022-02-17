
using System;

namespace SnakeProg
{
    public class Lesson2 : Lesson
    {
        protected Lesson2Task1 task1 = new Lesson2Task1();
        Random random = new Random();
      

        public Lesson2()
        {
            LessonDescription = "Lesson2 - Node";
            Tasks.Add(task1);
            
        }

        public override void TasksRun(int taskNumber)
        {

            
            switch (taskNumber)
            {
                case 0:
                    task1.AddNode(random.Next(0,10));
                    task1.PrintLinkedList();
                    task1.AddNode(random.Next(0, 10));
                    task1.PrintLinkedList();
                    task1.AddNodeAfter(task1.head, 77);
                    task1.PrintLinkedList();
                    Console.WriteLine($"Total elements in the list is:{task1.GetCount()}" );  
                    task1.RemoveNode(3);
                    task1.PrintLinkedList();
                    break;

                default:
                    break;
            }
        }










    }
}
