using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRPG
{ //you can not just add Wizard here coz not every human is palidin right? :v
    internal class HumanWarrior
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public int Faith { get; set; }

        public HumanWarrior(string name, int hp=10, int strength=10, int inteligence=10, int faith=10)
        {
            Name = name;
            Hp = hp;
            Strength = strength;
            Inteligence = inteligence;
            Faith = faith;
        }

        public void HitBySword()
        {
            Console.WriteLine("You hit by sword");
        }
        public void Block()
        {
            Console.WriteLine("You block next dmg");
        }

    }
}
