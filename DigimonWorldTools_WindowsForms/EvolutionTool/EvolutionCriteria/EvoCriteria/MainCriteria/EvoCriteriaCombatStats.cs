using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria
{
    public class EvoCriteriaCombatStats
    {
        public EvoCriteriaCombatStats(
            int hp, 
            int mp, 
            int off, 
            int def, 
            int speed, 
            int brains
        )
        {
            HP = hp;
            MP = mp;
            Off = off;
            Def = def;
            Speed = speed;
            Brains = brains;
        }

        public readonly int HP;

        public readonly int MP;

        public readonly int Off;

        public readonly int Def;

        public readonly int Speed;

        public readonly int Brains;
    }
}
