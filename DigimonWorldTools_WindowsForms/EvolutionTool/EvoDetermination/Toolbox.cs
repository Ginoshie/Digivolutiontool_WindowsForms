using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox;
using DigimonWorldTools_WindowsForms.EvoTool;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;
using System;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvoDetermination
{
    public static class Toolbox
    {
        #region Compound methods
        public static bool IsChampionOrUltimateEvoEnabled(IEvoCriteria evoCriteria, UserDigimon userDigimon)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteria == null)
            {
                throw new ArgumentNullException(nameof(evoCriteria));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (userDigimon == null)
            {
                throw new ArgumentNullException(nameof(userDigimon));
            }
            #endregion

            int NrOfCriteriaMet = 0;

            int CriteriaMetThresholdForEvo = 3;

            int MaxBonusCriteriaMetCount = 1;

            int CriteriaMetThresholdToContinue = CriteriaMetThresholdForEvo - MaxBonusCriteriaMetCount;

            NrOfCriteriaMet = AmtMainCriteriaMet(evoCriteria.EvoCriteriaMain, userDigimon);

            // Check if enough evolution criteria have been met to enable the evolution.
            if (NrOfCriteriaMet == CriteriaMetThresholdForEvo) { return true; }

            // Check if too little criteria are met and evolution cannot be enabled even with a bonus criteria.
            if (NrOfCriteriaMet < CriteriaMetThresholdToContinue) { return false; }

            // Return the result directly as this is the check which can enable the evolution.
            return IsAnyBonusCriteriaMet(evoCriteria.EvoCriteriaBonus, userDigimon);
        }

        public static int AmtMainCriteriaMet(EvoCriteriaMain mainEvoCriteria, UserDigimon userDigimon)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (mainEvoCriteria == null)
            {
                throw new ArgumentNullException(nameof(mainEvoCriteria));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (userDigimon == null)
            {
                throw new ArgumentNullException(nameof(userDigimon));
            }
            #endregion

            int amtMainCriteriaMet = 0;

            if(IsCombatStatsCriteriaMet(mainEvoCriteria.CombatStats, userDigimon.Stats.DigimonCombatStats)) { amtMainCriteriaMet++; }

            if (IsWeightCriteriaMet(mainEvoCriteria.Weight, userDigimon.Stats.Weight)) { amtMainCriteriaMet++; }

            if (IsCareMistakeCriteriaMet(mainEvoCriteria.CareMistakes, userDigimon.Stats.CareMistakes)) { amtMainCriteriaMet++; }

            return amtMainCriteriaMet;
        }

        public static bool IsAnyBonusCriteriaMet(EvoCriteriaBonus evoCriteriaBonus, UserDigimon userDigimon)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaBonus == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaBonus));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (userDigimon == null)
            {
                throw new ArgumentNullException(nameof(userDigimon));
            }
            #endregion

            Stats userDigimonStats = userDigimon.Stats;

            return
                // Check Happiness criteria.
                IsHappinessCriteria(evoCriteriaBonus.Happiness, userDigimonStats.Happiness)
                // Check Discipline criteria.
                || IsDisciplineCriteriaMet(evoCriteriaBonus.Discipline, userDigimonStats.Discipline)
                // Check Battles criteria.
                || IsBattleCriteriaMet(evoCriteriaBonus.Battles, userDigimonStats.Battles)
                // Check Techniques criteria.
                || IsTechniqueCriteriaMet(evoCriteriaBonus.Tech, userDigimonStats.Tech)
                // Check Precursor digimontype criteria.
                || IsPrecursorCriteriaMet(evoCriteriaBonus.PrecursorDigimonType, userDigimon.DigimonType);
        }
        #endregion

        #region Elementary methods
        public static bool IsCombatStatsCriteriaMet(EvoCriteriaCombatStats evoCriteriaCombatStats, CombatStats combatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaCombatStats == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaCombatStats));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (combatStats == null)
            {
                throw new ArgumentNullException(nameof(combatStats));
            }
            #endregion

            return EvoStatsToolbox.IsCombatStatsCriteriaMet(evoCriteriaCombatStats, combatStats);
        }

        public static bool IsCareMistakeCriteriaMet(EvoCriteriaCareMistakes evoCriteriaCareMistakes, int careMistakes)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaCareMistakes == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaCareMistakes));
            }
            #endregion

            return EvoStatsToolbox.IsMinMaxCriteriaMet(evoCriteriaCareMistakes, careMistakes);
        }

        public static bool IsWeightCriteriaMet(EvoCriteriaWeight evoCriteriaWeight, int weight)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaWeight == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaWeight));
            }
            #endregion

            return EvoStatsToolbox.IsValueRangeCriteriaMet(evoCriteriaWeight, weight);
        }

        public static bool IsPrecursorCriteriaMet(DigimonType? precursorDigimon, DigimonType userDigimonDigimonType)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (precursorDigimon == null)
            {
                throw new ArgumentNullException(nameof(precursorDigimon));
            }
            #endregion

            return EvoStatsToolbox.IsPrecursorCriteriaMet(precursorDigimon, userDigimonDigimonType);
        }

        public static bool IsTechniqueCriteriaMet(EvoCriteriaTech evoCriteriaTech, int tech)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaTech == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaTech));
            }
            #endregion

            return EvoStatsToolbox.IsMinCriteriaMet(evoCriteriaTech, tech);
        }

        public static bool IsHappinessCriteria(EvoCriteriaHappiness evoCriteriaHappiness , int happiness)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaHappiness == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaHappiness));
            }
            #endregion

            return EvoStatsToolbox.IsMinCriteriaMet(evoCriteriaHappiness, happiness);
        }
        
        public static bool IsDisciplineCriteriaMet(EvoCriteriaDiscipline evoCriteriaDiscipline, int discipline)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaDiscipline == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaDiscipline));
            }
            #endregion

            return EvoStatsToolbox.IsMinCriteriaMet(evoCriteriaDiscipline, discipline);
        }

        public static bool IsBattleCriteriaMet(EvoCriteriaBattles evoCriteriaBattles, int battles)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaBattles == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaBattles));
            }
            #endregion

            return EvoStatsToolbox.IsMinMaxCriteriaMet(evoCriteriaBattles, battles);
        }
        #endregion
    }
}
