using FactoryPatternDemonstration.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemonstration.Role
{
    abstract class Class
    {
        private List<Spell> spells = new List<Spell>();

        public abstract void AddSpellsToClass();

        public Class()
        {
            this.AddSpellsToClass();
        }

        public List<Spell> Spells
        {
            get { return spells; }
        }

        public override string ToString()
        {
            return GetType().Name;
        }
        
    }

}
