using System;

namespace StoneScissorsPaper
{
    internal class Program
    {
        static string[] str = { "S", "Sci", "P" };
        static string randomValue = str[new Random().Next(0, str.Length)];
        static string playerValue;

        static void Main()
        {
            Game();
        }

        static void Game()
        {            
            Console.WriteLine("Hello!" +
                "\nLet's play a game. " +
                "\nWhat do you want to choose: Stone(S), Scissors(Sci) or Paper(P)?");
            playerValue = Console.ReadLine();
            
            CheckValue(playerValue);
            Logic(playerValue);
        }
        static void CheckValue(string text)
        {
            while (text != str[0] && text != str[1] && text != str[2])
            {
                Console.WriteLine("Unknown command! \nTry again!");
                text = Console.ReadLine();
            }
        }
        static void Logic(string text)
        {
            if (text == "S")
            {
                if (randomValue == "Sci") Console.WriteLine("You win!");
                else if (randomValue == "P") Console.WriteLine("You lost!");
                else Console.WriteLine("Drawn game!");
            }
            if (text == "Sci")
            {
                if (randomValue == "S") Console.WriteLine("You lost");
                else if (randomValue == "P") Console.WriteLine("You win!");
                else Console.WriteLine("Drawn game!");
            }
            if (text == "P")
            {
                if (randomValue == "S") Console.WriteLine("You win!");
                else if (randomValue == "Sci") Console.WriteLine("You lost!");
                else Console.WriteLine("Drawn game!");
            }
        }
    }
}
