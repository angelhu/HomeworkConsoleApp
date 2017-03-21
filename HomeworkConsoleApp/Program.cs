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
            DateTime date = DateTime.Today;
            double money = 5.45;
            char x = 'X';

            Console.WriteLine(helloWorld);
            Console.WriteLine("Columbus Sailed the world in " + year + ".");
            Console.WriteLine("I spent $" + money + " on a cheeseburger.");
            Console.WriteLine("It is " + dogAtHome + " that I have a dog at home.");
            Console.WriteLine("Today is " + date.ToString("MM/dd/yyyy") + ".");
            Console.WriteLine(x + " marks the spot");

        }
    }
}
