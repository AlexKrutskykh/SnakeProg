using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    class Methods
    {  
        public static void GetTaskManager()
        {
            var processes = Process.GetProcesses();
            foreach (var item in processes)
            {
                Console.WriteLine($"{nameof(item.Id)}: {item.Id} , {nameof(item.ProcessName)}: {item.ProcessName} ");

            }
            Console.WriteLine($"What process you want to stop, type id num");
            var answer = Console.ReadLine();
            var proc = Process.GetProcessById(Convert.ToInt32(answer));
            proc.Kill();


        }




    }
}
