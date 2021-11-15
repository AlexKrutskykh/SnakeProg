using System;
using System.IO;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {

         /*   //1
            Methods.SaveSrtToFile();
            //2
            Methods.StartUpTimeToFile(@"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg\startup.txt");
            //3
            Methods.ConvertToByte();
            //4
            Methods.SaveDirectoriesPathToFile(@"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg");*/
            //TODO: Methods.SaveDirectoriesPathToFileRecursive(@"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg");
            //5
            var jsonFile = Methods.AddTaskToDoAndSaveTofile();
            Methods.GetListOfTodo(jsonFile);
            Methods.SetTaskToDone(jsonFile);
            Methods.GetListOfTodo(jsonFile);


        }
    }
}
