using System;

namespace SnakeProg
{
    class Methods
    {

        public static int[,] print2dArray(int lenghArrayX, int lenghArrayY)
        {
            Random rnd = new Random();
            int[,] array2d = new int[lenghArrayX, lenghArrayY];
            for (int i = 0; i < lenghArrayX; i++)
            {
                for (int j = 0; j < lenghArrayY; j++)
                {
                    if (i == j)
                    {
                        array2d[i, j] = rnd.Next(0, 100);
                        Console.SetCursorPosition(i, j);
                        Console.Write($"{array2d[i, j]} ");

                    }
                    else
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("*");
                    }

                }
            }
            return array2d;
        }



        public static void createPhoneBook(int numberOfContacts, int howManyLineData)
        {
            string[,] array2d = new string[numberOfContacts, howManyLineData];

            for (int i = 0; i < numberOfContacts; i++)
            {
                for (int j = 0; j < howManyLineData; j++)
                {
                    Console.WriteLine($"Add Contact name");
                    var contact = Console.ReadLine();
                    array2d[i, j] = contact;

                    Console.WriteLine($"Add Phone number of your contact");
                    var number = Console.ReadLine();
                    array2d[i, ++j] = number;
                }
            }
            Console.WriteLine($"Your phone book is:");
            for (int i = 0; i < numberOfContacts; i++)
            {
                for (int j = 0; j < howManyLineData; j++)
                {

                    Console.Write($"{array2d[i, j]} ");
                }
                Console.WriteLine();



            }
        }
        public static void revertString(string inputString)
        {
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }

        }

    



    }
}
