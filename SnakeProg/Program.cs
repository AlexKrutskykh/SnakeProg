using System;
using System.Data;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Methods.GetExpression();

            var num = Methods.GetNumbers(userInput);
            var operators = Methods.GetOperators(userInput);
            Methods.Calculate(num, operators);

        }
    }
}
