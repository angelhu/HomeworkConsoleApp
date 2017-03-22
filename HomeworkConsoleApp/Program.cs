using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World";
            int year = 1492;
            bool dogAtHome = true;
            DateTime date = DateTime.Now;
            double money = 5.45;
            char x = 'X';

            Console.WriteLine(helloWorld);
            Console.WriteLine("Columbus Sailed the world in " + year + ".");
            Console.WriteLine("I spent $" + money + " on a cheeseburger.");
            Console.WriteLine("It is " + dogAtHome + " that I have a dog at home.");
            Console.WriteLine("Today is " + date.ToString("MM/dd/yyyy") + ".");
            Console.WriteLine(x + " marks the spot");


            /* Ask the User for number a random number.
               Save that number to a int
               Use the int.TryParse() Method to parse out the number
               If the user didnt input a number, repeat step 1 - 4 until they put in a number */
            bool stopRunning = true;

            while (stopRunning) { 
            {
                Console.Write("Please enter a random number: ");
                string randomNumber = Console.ReadLine();
                int randomNumberEntered = 0;


                if (int.TryParse(randomNumber, out randomNumberEntered))
                {
                    Console.WriteLine($"You just entered {randomNumberEntered}!");
                    stopRunning = false;
                }
                else
                {
                    Console.WriteLine("Uh oh, that's not a valid number.");
                }
            }
        }

        }
    }
}
