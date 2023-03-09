using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Attack
    {
        public string AttackName { get; init; }
        public int MinDMG { get; init; }
        public int MaxDMG { get; init; }
        public Attack(string attackName, int minDMG, int maxDMG)
        {
            AttackName = attackName;
            MinDMG = minDMG;
            MaxDMG = maxDMG;
        }
    }
}
