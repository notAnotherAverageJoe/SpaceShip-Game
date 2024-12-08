using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    internal class Pilot
    {
        //properties
        public string Name { get; set; }
        public int PilotLevel { get; set; } = 1;
        public double Wallet { get; set; } = 250;

        public Pilot(string name, int pilotlevel = 1, double wallet = 250)
        {
            this.Name = name;
            this.PilotLevel = pilotlevel;
            this.Wallet = wallet;
        }
        public void GetBalance()
        {
            Console.WriteLine($"Current Balance: {Wallet}");

        }
        public static Pilot CreatePilot()
        {
            Console.WriteLine("What should we call you? ");
            string PilotName = Console.ReadLine();
            Pilot newPilot = new Pilot(PilotName);

            return newPilot; //Returning the newly made pilot
        }

        public override string ToString()
        {
            return $"Name: {Name} Pilot's Level: {PilotLevel} Money: {Wallet}.";
        }


    }
}
