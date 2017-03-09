using FactoryPatternDemonstration.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemonstration.Role
{
    class FireMage : Class
    {
        public override void AddSpellsToClass()
        {
            Spells.Add(new Fireball());
        }
    }
}
