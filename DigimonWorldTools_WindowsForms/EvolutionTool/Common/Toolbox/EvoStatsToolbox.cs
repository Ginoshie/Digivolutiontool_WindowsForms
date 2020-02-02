using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox
{
    public static class EvoStatsToolbox
    {
        #region CriteriaMethods
        private static CombatStat GetHighestCombatStatKey(CombatStats combatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (combatStats == null)
            {
                throw new ArgumentNullException(nameof(combatStats));
            }
            #endregion

            Dictionary<CombatStat, int> digimonCombatStatsDict = DictionaryFactory.GetCombatStatsDict(combatStats, true);

            return digimonCombatStatsDict.Max().Key;
        }

        public static bool IsStatPartOfCriteria(EvoCriteriaCombatStats evoCriteriaCombatStats, CombatStat combatStat)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaCombatStats == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaCombatStats));
            }
            #endregion

            Dictionary<CombatStat, int> evoCriteriaCombatStatsDict = DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

            return (evoCriteriaCombatStatsDict[combatStat] > 0);
        }
    
        public static bool IsCombatStatsCriteriaMet(EvoCriteriaCombatStats evoCriteriaCombatStats, CombatStats combatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaCombatStats == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaCombatStats));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaCombatStats == null)
            {
                throw new ArgumentNullException(nameof(combatStats));
            }
            #endregion

            Dictionary<CombatStat, int> evoCriteriaCombatStatsDict = DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

            Dictionary<CombatStat, int> digimonCombatStatsDict = DictionaryFactory.GetCombatStatsDict(combatStats, false);

            var evoCriteriaKvps = evoCriteriaCombatStatsDict.Where(statCriteria => statCriteria.Value > 0);
            
            // If all evo criteria are met return true, otherwise return false.
            return evoCriteriaKvps.All(evoCriteriaKvp => digimonCombatStatsDict[evoCriteriaKvp.Key] >= evoCriteriaKvp.Value);
        }

        public static bool IsMinMaxCriteriaMet(IMinMaxCritieria minMaxCriteria, int stat)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (minMaxCriteria == null)
            {
                throw new ArgumentNullException(nameof(minMaxCriteria));
            }
            #endregion

            return minMaxCriteria.IsMax ? (stat <= minMaxCriteria.Value) : (stat >= minMaxCriteria.Value);
        }

        public static bool IsMinCriteriaMet(IMinCriteria minCriteria, int stat)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (minCriteria == null)
            {
                throw new ArgumentNullException(nameof(minCriteria));
            }
            #endregion

            return (stat >= minCriteria.Value);
        }

        public static bool IsValueRangeCriteriaMet(IStatRangeCriteria valueRangeCriteria, int stat)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (valueRangeCriteria == null)
            {
                throw new ArgumentNullException(nameof(valueRangeCriteria));
            }
            #endregion

            int lowerBound = valueRangeCriteria.Value - valueRangeCriteria.MaxDeviationBoundsIncluded;

            int upperBound = valueRangeCriteria.Value + valueRangeCriteria.MaxDeviationBoundsIncluded;

            return (stat <= upperBound && stat >= lowerBound);
        }

        public static bool IsPrecursorCriteriaMet(DigimonType? precursorDigimonType, DigimonType userDigimonDigimonType)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (precursorDigimonType == null)
            {
                throw new ArgumentNullException(nameof(precursorDigimonType));
            }
            #endregion

            return (precursorDigimonType == null) ? false : (userDigimonDigimonType == precursorDigimonType);
        }
        #endregion

        #region calculationMethods
        public static int CalcEvoScore(EvoCriteriaCombatStats evoCriteriaCombatStats, CombatStats combatStats)
        {
            Dictionary<CombatStat, int> evoCriteriaDict = DictionaryFactory.GetEvoCriteriaCombatStatsDict(evoCriteriaCombatStats);

            Dictionary<CombatStat, int> CombatStatsDict = DictionaryFactory.GetCombatStatsDict(combatStats, true);

            var evoCriteriakvps = evoCriteriaDict.Where(evoCriteriaKvp => evoCriteriaKvp.Value > 0)
                .Select(evoCriteriaKvp => evoCriteriaKvp.Key);

            return evoCriteriakvps.Select(key => CombatStatsDict[key]).Sum();
        }
        #endregion
    }
}
