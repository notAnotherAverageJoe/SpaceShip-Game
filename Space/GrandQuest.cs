using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    internal class GrandQuest
    {
        public string North { get; set; }
        public string South { get; set; }
        public string West { get; set; }
        public string East { get; set; }

        public GrandQuest(string north, string south, string west, string east)
        {
            North = north;
            South = south;
            West = west;
            East = east;
        }

        private void NortherQuest(Hero player)
        {
            Console.WriteLine("You chose to go North!");
            // Use the Hero object to access player details and handle the North quest
            Console.WriteLine($"Hero Details: Pilot - {player.Pilot}, Ship - {player.Ship.Name}");
            // Add functionality for North quest
        }

        private void SoutherQuest(Hero player)
        {
            Console.WriteLine("You chose to go South!");
            // Use the Hero object to access player details and handle the South quest
            Console.WriteLine($"Hero Details: Pilot - {player.Pilot}, Ship - {player.Ship.Name}");
            // Add functionality for South quest
        }

        private void WesternQuest(Hero player)
        {
            Console.WriteLine("You chose to go West!");
            // Use the Hero object to access player details and handle the West quest
            Console.WriteLine($"Hero Details: Pilot - {player.Pilot}, Ship - {player.Ship.Name}");
            // Add functionality for West quest
        }

        private void EasternQuest(Hero player)
        {
            Console.WriteLine("You chose to go East!");
            // Use the Hero object to access player details and handle the East quest
            Console.WriteLine($"Hero Details: Pilot - {player.Pilot}, Ship - {player.Ship.Name}");
            // Add functionality for East quest
        }

        public async Task Destiny(Hero player)
        {
            Console.WriteLine("choose your path, and fulfill your destiny ('N', 'S', 'E', 'W' ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "n":
                    NortherQuest(player);
                    break;

                case "s":
                    SoutherQuest(player);
                    break;

                case "e":
                    EasternQuest(player);
                    break;

                case "w":
                    WesternQuest(player);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 'N', 'S', 'E', or 'W'.");
                    await Destiny(player); // Re-prompt the user
                    break;



            }
        }
    }
}
