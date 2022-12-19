using System;
using System.Linq;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox;

public static class EvoStatsToolbox
{
    #region CriteriaMethods

    public static CombatStat GetHighestCombatStatKey(CombatStats combatStats)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (combatStats == null) throw new ArgumentNullException(nameof(combatStats));

        #endregion

        var digimonCombatStatsDict =
            DictionaryFactory.GetCombatStatsDict(combatStats, true);

        var highestCombatStat = digimonCombatStatsDict.Values.Max();

        return digimonCombatStatsDict.First(combatStatsKvp => combatStatsKvp.Value == highestCombatStat).Key;
    }

    public static bool IsCombatStatPartOfCriteria(EvoCriterionCombatStats evoCriteriaCombatStats,
        CombatStat combatStat)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (evoCriteriaCombatStats == null) throw new ArgumentNullException(nameof(evoCriteriaCombatStats));

        #endregion

        var evoCriteriaCombatStatsDict =
            DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

        return evoCriteriaCombatStatsDict[combatStat] > 0;
    }

    public static bool IsCombatStatsCriteriaMet(EvoCriterionCombatStats evoCriteriaCombatStats,
        CombatStats combatStats)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (evoCriteriaCombatStats == null) throw new ArgumentNullException(nameof(evoCriteriaCombatStats));

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (evoCriteriaCombatStats == null) throw new ArgumentNullException(nameof(combatStats));

        #endregion

        var evoCriteriaCombatStatsDict =
            DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

        var digimonCombatStatsDict =
            DictionaryFactory.GetCombatStatsDict(combatStats, false);

        var evoCriteriaKvps = evoCriteriaCombatStatsDict.Where(statCriteria => statCriteria.Value > 0);

        // If all evo criteria are met return true, otherwise return false.
        return evoCriteriaKvps.All(evoCriteriaKvp =>
            digimonCombatStatsDict[evoCriteriaKvp.Key] >= evoCriteriaKvp.Value);
    }

    public static bool IsMinMaxCriteriaMet(IMinMaxCritieria minMaxCriteria, int stat)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (minMaxCriteria == null) throw new ArgumentNullException(nameof(minMaxCriteria));

        #endregion

        return minMaxCriteria.IsMax ? stat <= minMaxCriteria.Value : stat >= minMaxCriteria.Value;
    }

    public static bool IsMinCriteriaMet(IMinCriteria minCriteria, int stat)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (minCriteria == null) throw new ArgumentNullException(nameof(minCriteria));

        #endregion

        return stat >= minCriteria.Value;
    }

    public static bool IsValueRangeCriteriaMet(IStatRangeCriteria valueRangeCriteria, int stat)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (valueRangeCriteria == null) throw new ArgumentNullException(nameof(valueRangeCriteria));

        #endregion

        var lowerBound = valueRangeCriteria.Value - valueRangeCriteria.MaxDeviationBoundsIncluded;

        var upperBound = valueRangeCriteria.Value + valueRangeCriteria.MaxDeviationBoundsIncluded;

        return stat <= upperBound && stat >= lowerBound;
    }

    public static bool IsPrecursorCriteriaMet(DigimonType? precursorDigimonType, DigimonType userDigimonDigimonType)
    {
        return userDigimonDigimonType == precursorDigimonType;
    }

    #endregion

    #region calculationMethods

    public static int CalcEvoScore(EvoCriterionCombatStats evoCriteriaCombatStats, CombatStats combatStats)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (evoCriteriaCombatStats == null) throw new ArgumentNullException(nameof(evoCriteriaCombatStats));

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (combatStats == null) throw new ArgumentNullException(nameof(combatStats));

        #endregion

        var evoCriteriaCombatStatsDict =
            DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

        var combatStatsDict = DictionaryFactory.GetCombatStatsDict(combatStats, true);

        var evoCriteriaKvps = evoCriteriaCombatStatsDict.Where(evoCriteriaKvp => evoCriteriaKvp.Value > 0)
            .Select(evoCriteriaKvp => evoCriteriaKvp.Key);

        return evoCriteriaKvps.Select(key => combatStatsDict[key]).Sum();
    }

    public static int CalcCombatStatsCriteriaCount(EvoCriterionCombatStats evoCriteriaCombatStats)
    {
        #region Error handling

        // Error handling: Throw an exception explicitly stating the parameter that is null.
        if (evoCriteriaCombatStats == null) throw new ArgumentNullException(nameof(evoCriteriaCombatStats));

        #endregion

        var evoCriteriaCombatStatsDict =
            DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

        return evoCriteriaCombatStatsDict.Count(evoCriteriaCombatStatKvp => evoCriteriaCombatStatKvp.Value > 0);
    }

    #endregion
}