using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    class Methods
    {

        public static string GetExpression()
        {
            string result;
            Console.WriteLine($"Please enter your expression to calculate");
            result = Console.ReadLine();
            return result;
        }

       public static List<int> GetNumbers( string input)
        {
            var nums = input.Split('/', '+', '-', '*', ' ', '\t');

            return nums.Select(Int32.Parse).ToList(); ;
        }



        public static List<string> GetOperators(string input)
        {
           
            List<string> operators = new List<string>();

            foreach (var item in input)
            {
                if (item == '+' || item == '-' || item == '*' || item == '/')
                {
                    operators.Add(item.ToString());
                }
            }
            return operators;

        }


        public static void Calculate(List<int> numbers, List<string> operators)
        {
            var tempResultMulti = 0;
            var tempResultDevider = 0;
            var multiplierPosition = operators.IndexOf("*");
            var deviderPosition = operators.IndexOf("/");

            if (operators.Contains("*"))
            {
                tempResultMulti = numbers[multiplierPosition] * numbers[multiplierPosition + 1];

                
                if (operators.Contains("/") && (multiplierPosition - deviderPosition == 1 || multiplierPosition - deviderPosition == -1))
                {
                    if (multiplierPosition < deviderPosition)
                    {
                        tempResultMulti = tempResultMulti / numbers[deviderPosition + 1];
               
                    }
                    else if (multiplierPosition > deviderPosition)
                    {
                        tempResultMulti = numbers[deviderPosition] / tempResultMulti;
                  
                    }
                }

            }







        }






        public static void CalculateOld(List<int> num, List<string> operators)
        {
            double tempResultMulti = 0;
            double tempResultDevide = 0;
            double tempResultPlusMinus = 0;
            var multiplierPosition = operators.IndexOf("*");
            var deviderPosition = operators.IndexOf("/");
            var plus = operators.IndexOf("+");
            var minus = operators.IndexOf("-");

            if (operators.Contains("*"))
            {
                tempResultMulti = num[multiplierPosition] * num[multiplierPosition + 1];
                if (operators.Contains("+"))
                {
                    tempResultPlusMinus = tempResultMulti + num[plus];

                    if (operators.Contains("-"))
                    {
                        tempResultPlusMinus = tempResultPlusMinus - num[minus];
                    }
                    
                }
            }
            if (operators.Contains("/") && !operators.Contains("*"))
            {
                tempResultMulti = num[deviderPosition] / num[deviderPosition + 1];
            }
            if (operators.Contains("/") && (multiplierPosition - deviderPosition == 1))
            {
                tempResultMulti = num[deviderPosition] / tempResultMulti;
            }
            if (operators.Contains("/") && (multiplierPosition - deviderPosition == -1))
            {
                tempResultMulti = tempResultMulti / num[deviderPosition + 1];
            }
            if (operators.Contains("/") && (multiplierPosition - deviderPosition > 1 || multiplierPosition - deviderPosition < -1))
            {
                tempResultDevide = num[deviderPosition] / num[deviderPosition + 1];
            }
            if (operators.Contains("+") || operators.Contains("-") && !(operators.Contains("*") || operators.Contains("/")))
            {
                if (operators.Contains("+") && operators.Contains("-"))
                {
                    tempResultPlusMinus = num[plus] + num[plus + 1] - num[minus];
                }
                else if (operators.Contains("+"))
                {
                    tempResultPlusMinus = num[plus] + num[plus + 1];
                }
                else if (operators.Contains("-"))
                {
                    tempResultPlusMinus = num[minus] - num[minus + 1];
                }
            }











        }




    }
}
