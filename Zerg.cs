using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unosquareCSharpConcepts
{
    public class Zerg : AbstractStarcraftRace
    {
        public int NumberOfZerlings { get; set; }
        public int NumberOfHydras { get; set; }
        public int NumberOfMutalisks { get; set; }

        public int OverallDamage
        {
            get { return AttackLevel * (NumberOfZerlings * 1 + NumberOfHydras * 2 + NumberOfMutalisks * 1); }
        }
    }
    public class Zerg1 : IStarcraftRace
    {
        public int NumberOfZerlings { get; set; }
        public int NumberOfHydras { get; set; }
        public int NumberOfMutalisks { get; set; }

        public int OverallDamage
        {
            get { return (NumberOfZerlings * 1 + NumberOfHydras * 2 + NumberOfMutalisks * 1); }
        }

        public int GetTrueDamage()
        {
            return OverallDamage;
        }
    }
}
