using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unosquareCSharpConcepts
{
    public class Terran : AbstractStarcraftRace
    {
        public int NumberOfTanks { get; set; }
        public int NumberOfMarines { get; set; }

        public int OverallDamage
        {
            get { return AttackLevel * (NumberOfTanks *10 + NumberOfMarines); }
        }
    }
    public class Terran1 : IStarcraftRace
    {
        public int NumberOfTanks { get; set; }
        public int NumberOfMarines { get; set; }

        public int OverallDamage
        {
            get { return  (NumberOfTanks * 10 + NumberOfMarines); }
        }

        public int GetTrueDamage()
        {
            return OverallDamage;
        }


    }
}
