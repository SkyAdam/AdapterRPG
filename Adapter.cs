using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRPG
{
    internal class Adapter : Wizard
    {
        
        private readonly HumanWarrior _human;

        public string Name { get => "Sir " + this._human.Name;  }
        public int Hp { get => this._human.Hp; }
        public int Inteligence { get => this._human.Inteligence;  }
        public int Faith { get => this._human.Faith;  }
        public int Mana { get => this._human.Strength; }

        public Adapter(HumanWarrior human)
        {
            this._human = human;
            this._human.Faith += 10;
        }
        public void MagickAttack()
        {
            Console.WriteLine("You hit by fire sword");
        }
    }
}
