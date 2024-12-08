using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    internal class Hero
    {
        public Pilot Pilot { get; set; }
        public Ship Ship { get; set; }

        public Hero(Pilot pilot, Ship ship)
        {
            Pilot = pilot;
            Ship = ship;
        }
        public void ShowStatus()
        {
            Console.WriteLine(Pilot.ToString());
            Console.WriteLine(Ship.ToString());
        }
    }
}
