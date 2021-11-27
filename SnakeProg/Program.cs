using System;
using System.Configuration;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = roaming.FilePath;
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;


            if (settings.Count > 0)
            {
                Console.WriteLine($"{Properties.Resources.gretting} {settings["userName"].Value}\n" +
               $"Profession: {settings["doforLife"].Value}\n" +
               $"Age:{settings["age"].Value} ");

            }
            else { Console.WriteLine(Properties.Resources.gretting); }



            Console.WriteLine($"What is your name?");
            var userName = Console.ReadLine();
            settings.Add("userName", userName);

            Console.WriteLine($"What is your job?");
            var doforLife = Console.ReadLine();
            settings.Add("doforLife", doforLife);

            Console.WriteLine($"What is your age?");
            var age = Console.ReadLine();
            settings.Add("age", age);

            configuration.Save(ConfigurationSaveMode.Modified);

        }
    }
}

