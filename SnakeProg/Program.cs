using System;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {

            var maxTemp = Methods.userInputChecker("What Max temperature of Today?", "Temperature");
            var minTemp = Methods.userInputChecker("What Min temperature of Today?", "Temperature");
            Console.WriteLine(Methods.averageNumber(maxTemp, minTemp));
            var monthNum = Methods.userInputChecker("What Number of Month Today?", "Month");
            Methods.getMonthByNum(monthNum);
            int numInput = Methods.userInputChecker("Please Enter Number", "Number");
            Methods.wholeNumberChecker(numInput);



        }




    }
}
