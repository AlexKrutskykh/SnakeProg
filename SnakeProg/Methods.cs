using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    class Methods
    {
        public static void Config()
        {
            var roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = roaming.FilePath;
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
            configuration.Save(ConfigurationSaveMode.Modified);

            if (roaming.HasFile.Equals(false))
            {
                

            }

            
            
            
           
            
        }


        public static string EnterCommand()
        {
            Console.WriteLine($"Enter command:");
            return Console.ReadLine();
        }


        public static string GetCommand(string input)
        {
            string result = "";

            var command  = input.Split(" ").ToList();
            if (command.First() == "ls" && command.Count == 1)
            {
               Console.Write( Directory.GetDirectoryRoot(@"C:\"));

            }      


            return result;
        }











    }
}
