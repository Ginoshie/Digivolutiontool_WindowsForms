using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Stats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public static class EvoToolbox
    {
        /*public static bool IsHighestStatPartOfCriteria(EvoCriteriaCombatStats evoCriteriaCombatStats, CombatStats combatStats)
        {
            
        }
    
        public static CombatStats GetHighest(DigimonCombatStats digimonCombatStats, IEnumerable<CombatStats> relevantStats)
        {
           return relevantStats.Select(s=> digimonCombatStats[s])
        }*/

        public static CombatStats DetermineHighestCombatStat(DigimonCombatStats digimonCombatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (digimonCombatStats == null)
            {
                throw new ArgumentNullException(nameof(digimonCombatStats));
            }
            #endregion

            var listCombatStats = new Tuple<CombatStats, double>[]
            {
                new Tuple<CombatStats, double>(CombatStats.HP, (digimonCombatStats.HP / 10))
                , new Tuple<CombatStats, double>(CombatStats.MP, (digimonCombatStats.MP / 10))
                , new Tuple<CombatStats, double>(CombatStats.Off, digimonCombatStats.Off)
                , new Tuple<CombatStats, double>(CombatStats.Speed, digimonCombatStats.Speed)
                , new Tuple<CombatStats, double>(CombatStats.Def, digimonCombatStats.Def)
                , new Tuple<CombatStats, double>(CombatStats.Brains, digimonCombatStats.Brains)
            };

            // Return the combat stat with the highest value.
            return listCombatStats.Aggregate((highestStat, currentStat) => currentStat.Item2 > highestStat.Item2 ? currentStat : highestStat).Item1;
        }

        public static bool IsCombatStatCriteriaMet(EvoCriteriaCombatStats evoCriteriaCombatStats, DigimonCombatStats digimonCombatStats)
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
                throw new ArgumentNullException(nameof(digimonCombatStats));
            }
            #endregion

            #region
            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (evoCriteriaCombatStats.HP > 0 && digimonCombatStats.HP < evoCriteriaCombatStats.HP)
            {
                // A stat criteria is failed
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCrsiteria as a whole is failed.
            if (evoCriteriaCombatStats.MP > 0 && digimonCombatStats.MP < evoCriteriaCombatStats.MP)
            {
                // A stat criteria is failed
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (evoCriteriaCombatStats.Off > 0 && digimonCombatStats.Off < evoCriteriaCombatStats.Off)
            {
                // A stat criteria is failed
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (evoCriteriaCombatStats.Def > 0 && digimonCombatStats.Def < evoCriteriaCombatStats.Def)
            {
                // A stat criteria is failed
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (evoCriteriaCombatStats.Speed > 0 && digimonCombatStats.Speed < evoCriteriaCombatStats.Speed)
            {
                // A stat criteria is failed
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (evoCriteriaCombatStats.Brains > 0 && digimonCombatStats.Brains < evoCriteriaCombatStats.Brains)
            {
                // A stat criteria is failed
                return false;
            }
            #endregion

            // All stat criteria were met.
            return true;
        }
    }
}
