﻿using System.Collections.Generic;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;

internal class DictionaryFactory
{
    public static Dictionary<CombatStat, int> GetCombatStatsDict(CombatStats combatStats, bool divideByTenHPMP)
    {
        var factor = divideByTenHPMP ? 10 : 1;

        return new Dictionary<CombatStat, int>
        {
            { CombatStat.HP, combatStats.HP / factor }, { CombatStat.MP, combatStats.MP / factor },
            { CombatStat.Off, combatStats.Off }, { CombatStat.Def, combatStats.Def },
            { CombatStat.Speed, combatStats.Speed }, { CombatStat.Brains, combatStats.Brains }
        };
    }

    public static Dictionary<CombatStat, int> GetEvoCriteriaCombatStatsDict(
        EvoCriterionCombatStats evoCriteriaCombat)
    {
        return new Dictionary<CombatStat, int>
        {
            { CombatStat.HP, evoCriteriaCombat.HP }, { CombatStat.MP, evoCriteriaCombat.MP },
            { CombatStat.Off, evoCriteriaCombat.Off }, { CombatStat.Def, evoCriteriaCombat.Def },
            { CombatStat.Speed, evoCriteriaCombat.Speed }, { CombatStat.Brains, evoCriteriaCombat.Brains }
        };
    }
}