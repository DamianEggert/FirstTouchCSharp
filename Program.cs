using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "developer";
            string guess = "";
            int chanceCount = 0;
            int chanceLimit = 5;
            bool outOfChance = false;

            do
            {
                if(chanceCount < chanceLimit)
                {
                    Console.Write("Enter guess word: ");
                    guess = Console.ReadLine();
                    chanceCount++;
                } else
                {
                    outOfChance = true;
                }
            } while (guess != secretWord && !outOfChance);

            if (!outOfChance)
            {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadLine();
        }
    }
}
