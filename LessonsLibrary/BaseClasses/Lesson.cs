using System;
using System.Collections.Generic;

namespace SnakeProg
{
    public class Lesson
    {
        public List<Task> Tasks;
        public string LessonDescription { get; set; }


        public Lesson()
        {
            Tasks = new List<Task>();

        }

        public virtual void TasksRun(int taskNumber) { }


    }
}
