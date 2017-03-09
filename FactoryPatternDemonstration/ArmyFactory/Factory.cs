using FactoryPatternDemonstration.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemonstration.ArmyFactory
{
    class Factory
    {
        public Class createSoldier(String roleName)
        {
            if(roleName == null)
            {
                return null;
            }
            if (roleName.Equals("Archmage"))
            {
                return new ArchMage();
            }
            else if (roleName.Equals("Shaman"))
            {
                return new Shaman();
            }
            else if (roleName.Equals("Firemage"))
            {
                return new FireMage();
            }
            return null;
        }
    }
}
