using System;
using System.Threading.Tasks;

namespace Space
{
    internal class Ship
    {
        // Properties
        public string Name { get; set; }
        public double Speed { get; set; } = 100;
        public double Fuel { get; set; } = 100;
        public double Shields { get; set; } = 100;
        public double Missiles { get; set; } = 2;

        // Constructor
        public Ship(
            string name,
            double speed = 100,
            double fuel = 100,
            double shields = 100, 
            double missiles = 2)
        {
            this.Name = name;       
            this.Speed = speed;
            this.Fuel = fuel;
            this.Shields = shields;
            this.Missiles = missiles;
        }

        public void Refuel()
        {
            Console.WriteLine($"\nCurrent fuel is {Fuel} Zuggles\n");
            Fuel += 25;
            Console.WriteLine($"\nNew fuel level is {Fuel} Zuggles\n");

        }

        // Asynchronous method to recharge shields
        public async Task Recharge()
        {
            Console.WriteLine($"Current shield strength: {Shields}");
            Console.WriteLine("Recharging....please be patient...");

            // Pause execution for 3 seconds (3000 milliseconds)
            await Task.Delay(3000);

            // Simulate recharging process
            Shields += 25;
            Console.WriteLine($"Recharging complete\nNew shield strength: {Shields}");
        }

        public async Task ReArm()
        {
            Console.WriteLine($"Current Missile Count: {Missiles}");
            Console.WriteLine("We will get you armed up...just give us a moment");
            await Task.Delay(2000);
            Console.WriteLine("...sorry just another moment, all the real techs are on lunch" +
                " the new guy is decent enough..but a little slow..");
            await Task.Delay(2000);

            Missiles += 2;
            Console.WriteLine($"All done. Missile Count: {Missiles}");


        }

        public async Task Boosters()
        {
            Console.WriteLine($"Current speed is {Speed} mph");
            Console.WriteLine("Would you like to use your booster?\n Remember you will go faster.." +
                " but at a cost it will burn more fuel to do it!");
            Console.WriteLine("yes/no");
            string useBoost = Console.ReadLine();
            if (useBoost.ToLower() == "yes")
            {
                Console.WriteLine("Activating Boosters...");
                Speed += 50;
                Console.WriteLine($"Current speed {Speed}");
                Fuel -= 50;
                // Pause execution for 3 seconds (3000 milliseconds)
                await Task.Delay(3000);
                Speed -= 50;
                Console.WriteLine($"Boosters disengaged...\nCurrent Speed {Speed}\n" +
                    $"Current Fuel level: {Fuel}");
            }

        }
        public static Ship CreateShip()
        {
            Console.WriteLine("Welcome Pilot");
            Console.WriteLine("What will you name your ship?");
            string shipName = Console.ReadLine();
            Ship newShip = new Ship(shipName);

            Console.WriteLine($"Your ship, {newShip.Name}, has been created with the following stats:");
            Console.WriteLine(newShip.ToString());
            return newShip; // Return the newly created ship
        }
        public override string ToString()
        {
            return $"\tShip Name: {Name}\n\tSpeed: {Speed} mph\n\tFuel: {Fuel} Zuggles\n\tShields: {Shields}% \n\tMissiles: {Missiles}";
        }


    }
}
