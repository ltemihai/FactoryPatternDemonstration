using FactoryPatternDemonstration.Abilities;
using FactoryPatternDemonstration.ArmyFactory;
using FactoryPatternDemonstration.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory armyFactory = new Factory();
            Class[] army = new Class[4];

            army[0] = armyFactory.createSoldier("Archmage");
            army[1] = armyFactory.createSoldier("Shaman");
            army[2] = armyFactory.createSoldier("Firemage");
            army[3] = armyFactory.createSoldier("Archmage");
            System.Console.WriteLine("The army: ");
            System.Console.WriteLine("==================");
            foreach (Class armyIncrement in army)
            {
                System.Console.WriteLine(armyIncrement.ToString());
                System.Console.WriteLine("Spells: ");
                foreach (Spell spellIncrement in armyIncrement.Spells)
                {
                    System.Console.WriteLine("       " + spellIncrement.GetType().Name);
                }
                System.Console.WriteLine();
            
            }
            System.Console.WriteLine("==================");
        }
    }
}
