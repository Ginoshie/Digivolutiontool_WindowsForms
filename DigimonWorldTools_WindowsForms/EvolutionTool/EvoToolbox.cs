using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox;
using DigimonWorldTools_WindowsForms.EvoTool;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public static class EvoToolbox
    {
        #region Compound methods
        public static int AmtMainCriteriaMet(IEvoCriteria evoCriteria, UserDigimon userDigimon)
        {
            int amtMainCriteriaMet = 0;

            if(EvoToolbox.IsCombatStatsCriteriaMet(evoCriteria.CombatStats, userDigimon.Stats.DigimonCombatStats)) { amtMainCriteriaMet++; }

            if (EvoToolbox.IsWeightCriteriaMet(evoCriteria.Weight, userDigimon.Stats.Weight)) { amtMainCriteriaMet++; }

            if (EvoToolbox.IsCareMistakeCriteriaMet(evoCriteria.CareMistakes, userDigimon.Stats.CareMistakes)) { amtMainCriteriaMet++; }

            return amtMainCriteriaMet;
        }

        public static bool IsAnyBonusCriteriaMet(IEvoCriteria evoCriteria, UserDigimon userDigimon)
        {
            Stats userDigimonStats = userDigimon.Stats;

            return
                // Check Precursor digimontype criteria.
                EvoToolbox.IsPrecursorCriteriaMet(evoCriteria.PrecursorDigimonType, userDigimon.DigimonType)
                // Check Techniques criteria.
                || EvoToolbox.IsTechniqueCriteriaMet(evoCriteria.Tech, userDigimonStats.Tech)
                // Check Happiness criteria.
                || EvoToolbox.IsHappinessCriteria(evoCriteria.Happiness, userDigimonStats.Happiness)
                // Check Discipline criteria.
                || EvoToolbox.IsDisciplineCriteriaMet(evoCriteria.Discipline, userDigimonStats.Discipline)
                // Check Battles criteria.
                || EvoToolbox.IsBattleCriteriaMet(evoCriteria.Battles, userDigimonStats.Battles);
        }
        #endregion

        #region Elementary methods
        public static bool IsCombatStatsCriteriaMet(EvoCriteriaCombatStats evoCriteriaCombatStats, CombatStats combatStats)
        {
            return EvoStatsToolbox.IsCombatStatsCriteriaMet(evoCriteriaCombatStats, combatStats);
        }

        public static bool IsCareMistakeCriteriaMet(EvoCriteriaCareMistakes evoCriteriaCareMistakes, int careMistakes)
        {
            return EvoStatsToolbox.IsMinMaxCriteriaMet(evoCriteriaCareMistakes, careMistakes);
        }

        public static bool IsWeightCriteriaMet(EvoCriteriaWeight evoCriteriaWeight, int weight)
        {
            return EvoStatsToolbox.IsValueRangeCriteriaMet(evoCriteriaWeight, weight);
        }

        public static bool IsPrecursorCriteriaMet(DigimonType? precursorDigimon, DigimonType userDigimonDigimonType)
        {
            return EvoStatsToolbox.IsPrecursorCriteriaMet(precursorDigimon, userDigimonDigimonType);
        }

        public static bool IsTechniqueCriteriaMet(EvoCriteriaTech evoCriteriaTech, int tech)
        {
            return EvoStatsToolbox.IsMinCriteriaMet(evoCriteriaTech, tech);
        }

        public static bool IsHappinessCriteria(EvoCriteriaHappiness evoCriteriaHappiness , int happiness)
        {
            return EvoStatsToolbox.IsMinCriteriaMet(evoCriteriaHappiness, happiness);
        }
        
        public static bool IsDisciplineCriteriaMet(EvoCriteriaDiscipline evoCriteriaDiscipline, int discipline)
        {
            return EvoStatsToolbox.IsMinCriteriaMet(evoCriteriaDiscipline, discipline);
        }

        public static bool IsBattleCriteriaMet(EvoCriteriaBattles evoCriteriaBattles, int battles)
        {
            return EvoStatsToolbox.IsMinMaxCriteriaMet(evoCriteriaBattles, battles);
        }
        #endregion
    }
}
