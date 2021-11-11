using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeProg
{
    class Methods
    {
        enum seosns
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }


        public static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName}{lastName}{patronymic}");
        }


        public static void GetSumofStrinLine(string line)
        {
            string value = "";
            int counter = 0;
            List<int> sumList = new List<int>();

            for (int i = 0; i <= line.Length - 1; i++)
            {
                if (Convert.ToString(line[i]) != " ")
                {
                    value += Convert.ToString(line[i]);

                    if (i == line.Length - 1)
                    {
                        sumList.Add(Convert.ToInt32(value));
                    }

                }
                else
                {
                    sumList.Add(Convert.ToInt32(value));
                    value = "";
                }
            }
            Console.WriteLine(sumList.Sum());
        }

        public static void GetSesonTime()
        {

            var condition = true;
            int num = 0;
            while (condition)
            {
                Console.WriteLine($"Please enter number from 1-12");
                var answer = Console.ReadLine();
                var isItNum = int.TryParse(Convert.ToString(answer), out num);

                if (isItNum && num > 0 && num <= 12)
                {
                    condition = false;
                    if (num <= 2 || num == 12)
                    {
                        Console.WriteLine($"It`s {seosns.Winter} now!");
                    }
                    else if (num >= 3 && num <= 5)
                    {
                        Console.WriteLine($"It`s {seosns.Spring} now!");

                    }
                    else if (num >= 6 && num <= 8)
                    {
                        Console.WriteLine($"It`s {seosns.Summer} now!");
                    }
                    else if (num >= 9 && num <= 11)
                    {
                        Console.WriteLine($"It`s {seosns.Autumn} now!");
                    }

                }

            }


        }
        //0 1 1 2 3 5 8 13 21
        public static void FibonachiLine()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);

            Console.WriteLine(list[0]);

            for (int i = 1; i <= 30; i++)
            {

                list.Add(list[i - 1] + list[i]);
                Console.WriteLine(list[i]);
            }
        }

        // aecalexaeckrutskykhafc
        // cfaalexcfakrutskykhcea
        public static void GetBiggerLine(string sentenceOne, string sentenceTwo)
        {
            string result = "";
            List<string> list = new List<string>();

            for (int i = 0; i < sentenceOne.Length - 1; i++)
            {
                if (sentenceOne[i] == sentenceTwo[i])
                {
                    result += sentenceOne[i];

                    if (sentenceOne[i + 1] != sentenceTwo[i + 1])
                    {
                        list.Add(result);
                        result = "";
                    }
                }
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Length > list[i + 1].Length)
                {
                    result = list[i];
                }
                else
                {
                    result = list[i + 1];
                }

            }
            Console.WriteLine(result);

        }



    }
}
