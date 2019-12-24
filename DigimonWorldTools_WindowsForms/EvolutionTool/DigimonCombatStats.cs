using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Stats;
using System.Collections.Generic;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public class DigimonCombatStats
    {
        private Dictionary<CombatStats, int> dictionary = new Dictionary<CombatStats, int>
        {
            {CombatStats.HP, 0 },
            {CombatStats.MP, 0 },
            {CombatStats.Off, 0 },
            {CombatStats.Def, 0 },
            {CombatStats.Speed, 0 },
            {CombatStats.Brains, 0 },
        };

        public int HP
        {
            get => dictionary[CombatStats.HP];
            set => dictionary[CombatStats.HP] = value;
        }

        public int MP
        {
            get => dictionary[CombatStats.MP];
            set => dictionary[CombatStats.MP] = value;
        }

        public int Off
        {
            get => dictionary[CombatStats.Off];
            set => dictionary[CombatStats.Off] = value;
        }

        public int Def
        {
            get => dictionary[CombatStats.Def];
            set => dictionary[CombatStats.Def] = value;
        }

        public int Speed
        {
            get => dictionary[CombatStats.Speed];
            set => dictionary[CombatStats.Speed] = value;
        }

        public int Brains
        {
            get => dictionary[CombatStats.Brains];
            set => dictionary[CombatStats.Brains] = value;
        }

        public int this[CombatStats combatStats]
        {
            get => dictionary[combatStats];
        }
    }
}
