using System;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var maxTemp = Methods.userInputChecker("What Max temperature of Today?", "Temperature");
            var minTemp = Methods.userInputChecker("What Min temperature of Today?", "Temperature");
            var averageTemp = Methods.averageNumber(maxTemp, minTemp);
            Console.WriteLine(averageTemp);
            //2
            var monthNum = Methods.userInputChecker("What Number of Month Today?", "Month");
            Methods.getMonthByNum(monthNum);
            //3
            int numInput = Methods.userInputChecker("Please Enter Number", "Number");
            Methods.wholeNumberChecker(numInput);
            //4
            Checkbase check1 = new Checkbase();
            check1.getCheckDetailsAndPrint();
            //5
            Methods.tempChecker(monthNum, averageTemp);
            //6
            Methods.RimToArabik("XLIV");




        }




    }
}
