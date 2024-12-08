using System;
using System.Threading.Tasks;

namespace Space
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Create an instance of the GameOn class
            GameOn game = new GameOn();

            // Start the game
            await game.Start();

            Console.ReadKey();
        }
    }
}
