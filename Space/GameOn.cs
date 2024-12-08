using System;
using System.Threading.Tasks;

namespace Space
{
    internal class GameOn
    {
        // Method to start the game
        public async Task Start()
        {
            Console.WriteLine("\t\tFresh Meat for the grinder...\n\n");

            // Create the first ship
            Ship playerShip = Ship.CreateShip();
            Console.WriteLine($"{playerShip.Name}, eh..not a name I would" +
                $" have chosen but it suits you... ");
            Console.WriteLine("On the topic of silly names.. what was yours again?");
            Pilot playerPilot = Pilot.CreatePilot();
            Console.WriteLine($"OH! of course how could I forget your name {playerPilot}," +
                $" the mighty captain of the {playerShip}..");
            Hero TheHero = new Hero(playerPilot, playerShip);
            Console.WriteLine("Now that we finally got you fully registered the fun can begin.");
            // Create an instance of GrandQuest and call Destiny
            GrandQuest quest = new GrandQuest("NorthQuest", "SouthQuest", "WestQuest", "EastQuest");
            await quest.Destiny(TheHero);

            Console.WriteLine("END FOR Now");
           




            // Add more game logic as needed
            // You can add a game loop here or more actions
        }
    }
}


// Display ship stats
//Console.WriteLine(playerShip.ToString());


// Perform game actions
// await playerShip.Recharge();
//playerShip.Refuel();
//await playerShip.Boosters();

//await playerShip.Boosters();
//await playerShip.ReArm();


