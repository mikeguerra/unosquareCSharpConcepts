using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unosquareCSharpConcepts
{
    public class Protoss : AbstractStarcraftRace
    {
        public int NumberOfZealots { get; set; }
        public int NumberOfVoids { get; set; }
        public int NumberOfBatteries { get; set; }

        public int OverallDamage
        {
            get { return AttackLevel * (NumberOfZealots * 1 * NumberOfBatteries + NumberOfVoids * 2 * NumberOfBatteries); }
        }
    }

    public class Protoss1 : IStarcraftRace
    {
        public int NumberOfZealots { get; set; }
        public int NumberOfVoids { get; set; }
        public int NumberOfBatteries { get; set; }

        public int OverallDamage
        {
            get { return  (NumberOfZealots * 1 * NumberOfBatteries + NumberOfVoids * 2 * NumberOfBatteries); }
        }

       public int GetTrueDamage()
        {
           return OverallDamage;
        }
    }
}
