using System;

namespace SnakeProg
{
    class Methods
    {
        public Methods() { }

        enum charToint
        {
/*            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6,
            G = 7,
            H = 8,
            I = 9,
            J = 10*/
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I,
            J
        }

        public static string[,] CreateBattleshipField(string[,] shipField)
        {
            int counter = 0;
            Console.Write($"   A  B  C  D  E  F  G  H  I  J");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(++counter);

                for (int j = 0; j < 10; j++)
                {
                    if (counter == 10)
                    {
                        Console.Write($" {shipField[i, j]}0 ");
                    }
                    else
                    {
                        Console.Write($"  {shipField[i, j]}0");
                    }
                }

                Console.WriteLine();
            }
            return shipField;
        }

        public static void PrintCurrentField(string[,] shipField)
        {
            int counter = 0;
            Console.Write($"   A  B  C  D  E  F  G  H  I  J");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(++counter);

                for (int j = 0; j < 10; j++)
                {
                    if (shipField[i, j] != null)
                    {
                        Console.Write($"  {shipField[i, j]}");
                    }
                    else if (shipField[i, j] != null && counter == 10)
                    {
                        Console.Write($" {shipField[i, j]}");
                    }
                    else if (counter == 10)
                    {
                        Console.Write($" {shipField[i, j]}0 ");
                    }
                    else
                    {
                        Console.Write($"  {shipField[i, j]}0");
                    }
                }

                Console.WriteLine();
            }
        }



        //Ask Ship details
        public static int AskShipLenght()
        {
            Console.WriteLine($"What ship you want to place? Type number depends of deck number");
            int shipLenght = InputStringToIntChecker(Console.ReadLine(), "decks");
            return shipLenght;
        }

        public static Tuple<int, int> AskShipCoordinates()
        {
            Console.WriteLine($"Enter where you want to put startpoint of your ship? Example: A5");
            var coordinates = ParseCoordinatesAndCheck(Console.ReadLine());

            return coordinates;
        }

        public static string AskShipDirrections(int shipLenght)
        {
            string direction = "OneDeck";
            if (shipLenght != 1)
            {
                Console.WriteLine($"Which direction you want to place your ship DOWN or RIGHT (D - down or R - right)");
                direction = ShipDirection(Console.ReadLine());

            }
            return direction;
        }


        //Check for number positive + check if it`s not a string
        public static int InputStringToIntChecker(string input, string conditions)
        {
            bool conditionAnswer = true;
            int _input = 0;
            switch (conditions)
            {
                case "cell":
                    while (conditionAnswer)
                    {
                        if (int.TryParse(input, out _input))
                        {
                            if (_input >= 1 && _input <= 10)
                            {
                                conditionAnswer = false;
                            }
                            else if (_input < 0)
                            {
                                Console.WriteLine($"Please re-enter positive number from 1-10");
                                input = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"Please re-enter number from 1-10");
                                input = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Please re-enter number from 1-10");
                            input = Console.ReadLine();
                        }
                    }
                    --_input;
                    break;

                case "decks":
                    while (conditionAnswer)
                    {
                        if (int.TryParse(input, out _input))
                        {
                            if (_input > 0 && _input <= 4)
                            {
                                conditionAnswer = false;
                            }
                            else
                            {
                                Console.WriteLine($"Please re-enter positive number from 1-4");
                                input = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Please re-enter number from 1-4");
                            input = Console.ReadLine();
                        }
                    }
                    break;
            }
            return _input;
        }

        //input coordinates in str, parse to x & y TUPLE and checkes that format of coordinates is correct int
        public static Tuple<int, int> ParseCoordinatesAndCheck(string input)
        {
            int coordinateX = 0;
            int coordinateY = 0;
            bool answer = true;
            while (answer)
            {
                if (input.Length <= 2 && input.Length != 0)
                {
                    switch (input.Substring(0, 1).ToUpper())
                    {
                        case "A":
                            coordinateX = (int)charToint.A;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "B":
                            coordinateX = (int)charToint.B;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "C":
                            coordinateX = (int)charToint.C;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "D":
                            coordinateX = (int)charToint.D;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "E":
                            coordinateX = (int)charToint.E;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "F":
                            coordinateX = (int)charToint.F;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "G":
                            coordinateX = (int)charToint.G;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "H":
                            coordinateX = (int)charToint.H;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "I":
                            coordinateX = (int)charToint.I;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        case "J":
                            coordinateX = (int)charToint.J;
                            coordinateY = InputStringToIntChecker(input.Substring(1, 1), "cell");
                            answer = false;
                            break;
                        default:
                            Console.WriteLine($"Please enter coordinates start with Letter, Example: A5");
                            input = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Please input Letter and number for coordinates you want to place ship");
                    input = Console.ReadLine();
                }

            }
            return Tuple.Create(coordinateX, coordinateY);
        }

        public static string ShipDirection(string directionInput)
        {
            bool answer = true;
            while (answer)
            {
                switch (directionInput.ToUpper())
                {
                    case "R":
                        answer = false;
                        break;
                    case "D":
                        answer = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter D - down or R - right");
                        directionInput = Console.ReadLine().ToUpper();
                        break;
                }
            }
            return directionInput;
        }


        public static string[,] PlaceShip(int shipLength, Tuple<int, int> coordinates, string direction, string[,] battlefield)
        {
            switch (shipLength)
            {
                case 1:

                    break;
            }
            battlefield[coordinates.Item1, coordinates.Item2] = "X";


            return battlefield;
        }
    }


}


