using System;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods c = new Methods();
            string[,] field = new string[10, 10];
            var gameField = Methods.CreateBattleshipField(field);
            var shipLenght = Methods.AskShipLenght();
            var statrPoint = Methods.AskShipCoordinates();
            var shipDirections = Methods.AskShipDirrections(shipLenght);

            Methods.PlaceShip(shipLenght,statrPoint,shipDirections,gameField);
            Methods.PrintCurrentField(gameField);
            
            
            
            
           /* var coordinates = Methods.parseCoordinatesAndCheck("E5");
            Methods.placeShip(1,coordinates,"R", gaemField);*/
            //Methods.printCurrentField(gameField);
           // Methods.createBattleshipField(gameField);
            //Methods.askShipDetails();
            //Methods.parseCoordinatesAndCheck("A15");


            //Methods.inputStringToIntChecker("abc");


        }
    }
}
