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
            return StatsToolbox.IsCombatStatsCriteriaMet(evoCriteriaCombatStats, combatStats);
        }

        public static bool IsCareMistakeCriteriaMet(EvoCriteriaCareMistakes evoCriteriaCareMistakes, int careMistakes)
        {
            return StatsToolbox.IsMinMaxCriteriaMet(evoCriteriaCareMistakes, careMistakes);
        }

        public static bool IsWeightCriteriaMet(EvoCriteriaWeight evoCriteriaWeight, int weight)
        {
            return StatsToolbox.IsValueRangeCriteriaMet(evoCriteriaWeight, weight);
        }

        public static bool IsPrecursorCriteriaMet(DigimonType? precursorDigimon, DigimonType userDigimonDigimonType)
        {
            return StatsToolbox.IsPrecursorCriteriaMet(precursorDigimon, userDigimonDigimonType);
        }

        public static bool IsTechniqueCriteriaMet(EvoCriteriaTech evoCriteriaTech, int tech)
        {
            return StatsToolbox.IsMinCriteriaMet(evoCriteriaTech, tech);
        }

        public static bool IsHappinessCriteria(EvoCriteriaHappiness evoCriteriaHappiness , int happiness)
        {
            return StatsToolbox.IsMinCriteriaMet(evoCriteriaHappiness, happiness);
        }
        
        public static bool IsDisciplineCriteriaMet(EvoCriteriaDiscipline evoCriteriaDiscipline, int discipline)
        {
            return StatsToolbox.IsMinCriteriaMet(evoCriteriaDiscipline, discipline);
        }

        public static bool IsBattleCriteriaMet(EvoCriteriaBattles evoCriteriaBattles, int battles)
        {
            return StatsToolbox.IsMinMaxCriteriaMet(evoCriteriaBattles, battles);
        }
        #endregion
    }
}
