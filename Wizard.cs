using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRPG
{
    internal interface Wizard
    {
        public string Name { get; }
        public int Hp { get; }
        public int Inteligence { get; }
        public int Faith { get;  }
        public int Mana { get;  }
        public void MagicAttack()
        {
            Console.WriteLine("You cast fireball");
        }
    }
}
