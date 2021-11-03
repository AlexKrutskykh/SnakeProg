using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    class Methods
    {
         

        public static int userInputChecker ( string messageToUser, string requeredToinput)
        {
             string input;
            do
            {
                Console.WriteLine($"{messageToUser}");
                input = Console.ReadLine();
                if (!checkIfitsNumOrString(input))
                {
                    Console.WriteLine($"{requeredToinput} should be a number not a text, you entered ' {input} ', please enter Number");
                }
            } while (!checkIfitsNumOrString(input));

            return Convert.ToInt32(input);
        }

        public static bool checkIfitsNumOrString(string input)
        {
            bool result = int.TryParse(input, out int intNum);

            return result;
        }


        public static double averageNumber (int a, int b)
        {
            double result = (a + b )/2;
            return result;
        }


        public static string getMonthByNum (int numOfmonth)
        {
            string answer = "";
            switch (numOfmonth)
            {
                case 1:
                    Console.WriteLine($"Now is January");
                    answer = "January";
                    break;
                case 2:
                    Console.WriteLine($"Now is February");
                    answer = "February";
                    break;
                case 3:
                    Console.WriteLine($"Now is March");
                    answer = "March";
                    break;
                case 4:
                    Console.WriteLine($"Now is April");
                    answer = "April";
                    break;
                case 5:
                    Console.WriteLine($"Now is May");
                    answer = "May";
                    break;
                case 6:
                    Console.WriteLine($"Now is June");
                    answer = "June";
                    break;
                case 7:
                    Console.WriteLine($"Now is July");
                    answer = "July";
                    break;
                case 8:
                    Console.WriteLine($"Now is August");
                    answer = "August";
                    break;
                case 9:
                    Console.WriteLine($"Now is September");
                    answer = "September";
                    break;
                case 10:
                    Console.WriteLine($"Now is October");
                    answer = "October";
                    break;
                case 11:
                    Console.WriteLine($"Now is November");
                    answer = "November";
                    break;
                case 12:
                    Console.WriteLine($"Now is December");
                    answer = "December";
                    break;
                default:
                    Console.WriteLine("There is no such month");
                    break;
            }
            return answer;
        }


        public static void wholeNumberChecker(int input)
        {
            if (input% 2 == 0)
            {
                Console.WriteLine($"Eneterd number '{input}' is a whole number");

            } else
            {
                Console.WriteLine($"Eneterd number '{input}' is NOT a whole number");
            }

        }


    }
}
