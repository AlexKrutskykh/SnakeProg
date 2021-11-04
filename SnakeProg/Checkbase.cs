using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProg
{
    class Checkbase
    {
        string nameOfrestorante;
        List<string> listOfdishPrice = new List<string>();
        string dateTime = DateTime.Now.ToString();
        double price;
        double tax = 7.89;
        double tips15 = 15;
        double tips20 = 20;
        double tips25 = 25;

        bool answer = false;
        string input;

        public Checkbase() { }   
        
        public void getCheckDetailsAndPrint ()
        {         
            Console.WriteLine("What name of Retorunts you was today?");
            nameOfrestorante = Console.ReadLine();
            while(answer == false)
            {
                Console.WriteLine("What name of the dish/drink you ordered?");
                listOfdishPrice.Add(Console.ReadLine());
                Console.WriteLine("What the price for dish/drink was?");
                listOfdishPrice.Add(Console.ReadLine());
                Console.WriteLine("Is there any other dish/drink you ordered? Type 'Yes' - to continue enter OR 'No' - to next step");
                input = Console.ReadLine();

                while (input.ToLower() != "yes" && input.ToLower() != "no")
                {
                    Console.WriteLine("Please type 'Yes' or 'No' didn`t understand your answer");
                    input = Console.ReadLine();
                    input.ToLower();
                }

                if (input.ToLower() == "yes")
                {
                    answer = false;
                }else
                {
                    answer = true;
                } 
            }

            printCheck(nameOfrestorante, dateTime,listOfdishPrice );
        }


        public void printCheck( string nameRest, string dateNow, List<string> dishes )
        {
            List<double> dishPrice = new List<double>();
            Console.WriteLine($"Restorante nema: {nameRest}");
            Console.WriteLine($"Check dateis: {dateNow}");
            Console.WriteLine($"Item____Price");
            for (int i = 0; i <= dishes.Count()-1; i++)
            {
                Console.WriteLine($"{dishes[i]} - {dishes[++i]}$");
                dishPrice.Add(Convert.ToDouble(dishes[i]));               
            }

            double totalCheck = dishPrice.Sum();
            double taxValue = Math.Round(totalCheck * tax / 100 , 2);
            tips15 = Math.Round(totalCheck * tips15 / 100, 2);
            tips20 = Math.Round(totalCheck * tips20 / 100, 2);
            tips25 = Math.Round(totalCheck * tips25 / 100 , 2);

            Console.WriteLine($"Total is: {totalCheck}$");
            Console.WriteLine($"Tax is {tax}%: {taxValue}$");
            Console.WriteLine($"Total with Tax is: {totalCheck + taxValue}$");
            Console.WriteLine($"Recomemnded Tips 15%: {tips15}$");
            Console.WriteLine($"Recomemnded Tips 20%: {tips20}$");
            Console.WriteLine($"Recomemnded Tips 25%: {tips25}$");


        }



      





    }
}
