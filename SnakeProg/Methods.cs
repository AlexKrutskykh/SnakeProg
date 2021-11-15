using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SnakeProg
{

    class Methods
    {
        public static void SaveSrtToFile()
        {
            string dataPath = @"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg\files\TestFile.txt";
            Console.WriteLine($"Enter test you want to be added to file");
            string textTofile = Console.ReadLine();

            File.WriteAllText(dataPath, textTofile);

        }

        public static void StartUpTimeToFile(string filePath)
        {
            File.AppendAllText(filePath, $"{DateTime.Now}\n");
        }

        public static void ConvertToByte()
        {
            Console.WriteLine("Enter sequence of numbers from 0 ... 255");
            var numbers = Console.ReadLine();
            byte[] bytes = new byte[numbers.Count(s => s == ' ') + 1]; //count spaces + 1 and it will be length of array
            var temp = "";
            var counter = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i].ToString() == " ")
                {
                    bytes[counter] = Convert.ToByte(temp + numbers[i]);
                    temp = "";
                    ++counter;
                }
                else
                {
                    temp += numbers[i];
                    if (i == numbers.Length - 1)
                    {
                        bytes[counter] = Convert.ToByte(temp);
                    }
                }

            }
            File.WriteAllBytes(@"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg\files\byteFile.bin", bytes);
        }


        public static void SaveDirectoriesPathToFile(string path)
        {
            var filePath = @"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg\files\dirTofilePath.txt";
            var currentPath = "";
            var arrayPath = path.Split('\\');

            foreach (var item in arrayPath)
            {
                currentPath += $"{ item}\\";
                File.AppendAllText(filePath, $"This is directory catalog from {currentPath}\n");
                File.AppendAllLines(filePath, Directory.EnumerateDirectories(currentPath));
            }

        }

        /*        public static void SaveDirectoriesPathToFileRecursive(string path)
                {
                    RecursiceMethod();

                }

                public static int RecursiceMethod(int num, Array array)
                {
                    if (num == array.Length-1)
                    {
                        return 1;
                    }
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        var currentPath = "";
                        currentPath += $"{item}\\";
                        File.AppendAllText(filePath, $"This is directory catalog from {currentPath}\n");
                        File.AppendAllLines(filePath, Directory.EnumerateDirectories(currentPath));


                    }
                    return 0;

                } */
        public class TODO
        {
            /*            private string title;
                        private bool isDone;*/
            public TODO() { }
            //public IList<IDictionary<string, bool>> data { get; set; }

            public TODO(string title, bool isdone)
            {
                this.Title = title;
                this.IsDone = isdone;
            }
            public string Title { get; set; }
            public bool IsDone { get; set; }






        }

        public static string AddTaskToDoAndSaveTofile()
        {
            var filePath = @"C:\Users\Alex\Source\Repos\SnakeProg\SnakeProg\files\jsonFile.json";
            bool condition = true;
            List<TODO> todoList = new List<TODO>();
            while (condition)
            {
                //Read if there is task in the list
                var json = File.ReadAllText(filePath);
                todoList = JsonConvert.DeserializeObject<List<TODO>>(json);

                //ask for a new task to add
                Console.WriteLine("Write task for list of TODO:");
                todoList.Add(new TODO(Console.ReadLine(), false));

                json = JsonSerializer.Serialize(todoList);
                File.WriteAllText(filePath, json);

                Console.WriteLine("Is there anything you want to add? Type Yes - to continue or No - to save list of tasks");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "no")
                {
                    condition = false;
                }

            }
            return filePath;
        }

        public static void GetListOfTodo(string jsonPath)
        {
            var json = File.ReadAllText(jsonPath);
            var todoList = JsonConvert.DeserializeObject<List<TODO>>(json);
            for (int i = 0; i <= todoList.Count - 1; i++)
            {
                if (todoList[i].IsDone == false)
                {
                    Console.WriteLine($"{i + 1} - [ ] -  {todoList[i].Title}");
                }
                else
                {
                    Console.WriteLine($"{i + 1} - [X] -  {todoList[i].Title}");
                }
            }
        }


        public static void SetTaskToDone( string jsonPath)
        {
             var condition = true;
            var num = 0;
            while (condition)
            {
                Console.WriteLine($"What task you want to mark as Done, enter number of line");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    var json = File.ReadAllText(jsonPath);
                    var todoList = JsonConvert.DeserializeObject<List<TODO>>(json);
                    todoList[num - 1].IsDone = true;

                    Console.WriteLine($"What to mark one more? type Yes or No");
                    var answer = Console.ReadLine();
                    if (answer.ToLower() == "no")
                    {
                        json = JsonSerializer.Serialize(todoList);
                        File.WriteAllText(jsonPath, json);
                        condition = false;
                    }
                    else
                    {
                        json = JsonSerializer.Serialize(todoList);
                        File.WriteAllText(jsonPath, json);
                    }
                }
            }

        }













    }
}
