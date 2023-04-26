// See https://aka.ms/new-console-template for more information
using AdapterRPG;

Console.WriteLine("Hello, World!");

HumanWarrior Roger = new HumanWarrior("Roger");

HumanWarrior Banit = new HumanWarrior("Smuggler");

Roger.HitBySword();

Banit.Block();

// Roger is welcom in Order of the Rose and becomes a paladin

Wizard SirRoger = new Adapter(Roger);

SirRoger.MagicAttack();

Console.WriteLine("My name is {0}", SirRoger.Name);


Console.ReadKey();



