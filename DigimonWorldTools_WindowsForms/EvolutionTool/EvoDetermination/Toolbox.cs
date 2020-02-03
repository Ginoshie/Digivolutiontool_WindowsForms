using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Stats;
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

            NrOfCriteriaMet = AmtMainCriteriaMet(evoCriteria.EvoCriteriaMain, userDigimon.MainCritiaStats);

            // Check if enough evolution criteria have been met to enable the evolution.
            if (NrOfCriteriaMet == CriteriaMetThresholdForEvo) { return true; }

            // Check if too little criteria are met and evolution cannot be enabled even with a bonus criteria.
            if (NrOfCriteriaMet < CriteriaMetThresholdToContinue) { return false; }

            // Return the result directly as this is the check which can enable the evolution.
            return IsAnyBonusCriterionMet(evoCriteria.EvoCriteriaBonus, userDigimon.BonusCritiaStats);
        }

        public static int AmtMainCriteriaMet(EvoCriteriaMain mainEvoCriteria, MainCriteriaStats mainCriteriaStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (mainEvoCriteria == null)
            {
                throw new ArgumentNullException(nameof(mainEvoCriteria));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (mainCriteriaStats == null)
            {
                throw new ArgumentNullException(nameof(mainCriteriaStats));
            }
            #endregion

            int amtMainCriteriaMet = 0;

            if (IsCombatStatsCriterionMet(mainEvoCriteria.CombatStats, mainCriteriaStats.CombatStats)) { amtMainCriteriaMet++; }

            if (IsWeightCriterionMet(mainEvoCriteria.Weight, mainCriteriaStats.Weight)) { amtMainCriteriaMet++; }

            if (IsCareMistakeCriterionMet(mainEvoCriteria.CareMistakes, mainCriteriaStats.CareMistakes)) { amtMainCriteriaMet++; }

            return amtMainCriteriaMet;
        }

        public static bool IsAnyBonusCriterionMet(EvoCriteriaBonus evoCriteriaBonus, BonusCritiaStats BonusCriteriaStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriteriaBonus == null)
            {
                throw new ArgumentNullException(nameof(evoCriteriaBonus));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (BonusCriteriaStats == null)
            {
                throw new ArgumentNullException(nameof(BonusCriteriaStats));
            }
            #endregion

            BonusCritiaStats bonusCriteriaStats = BonusCriteriaStats;

            return
                // Check Happiness criteria.
                IsHappinessCriteronMet(evoCriteriaBonus.Happiness, bonusCriteriaStats.Happiness)
                // Check Discipline criteria.
                || IsDisciplineCriterionMet(evoCriteriaBonus.Discipline, bonusCriteriaStats.Discipline)
                // Check Battles criteria.
                || IsBattleCriterionMet(evoCriteriaBonus.Battles, bonusCriteriaStats.Battles)
                // Check Techniques criteria.
                || IsTechniqueCriterionMet(evoCriteriaBonus.Tech, bonusCriteriaStats.Tech)
                // Check Precursor digimontype criteria.
                || IsPrecursorCriterionMet(evoCriteriaBonus.PrecursorDigimonType, BonusCriteriaStats.DigimonType);
        }

        public static bool IsHighestCombatStatACriterion(EvoCriterionCombatStats evoCriterionCombatStats, CombatStats userDigimonCombatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionCombatStats == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionCombatStats));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (userDigimonCombatStats == null)
            {
                throw new ArgumentNullException(nameof(userDigimonCombatStats));
            }
            #endregion

            CombatStat HighestCombatStat = EvoStatsToolbox.GetHighestCombatStatKey(userDigimonCombatStats);

            return EvoStatsToolbox.IsCombatStatPartOfCriteria(evoCriterionCombatStats, HighestCombatStat);
        }
        #endregion

        #region Elementary methods
        public static bool IsCombatStatsCriterionMet(EvoCriterionCombatStats evoCriterionCombatStats, CombatStats combatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionCombatStats == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionCombatStats));
            }

            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (combatStats == null)
            {
                throw new ArgumentNullException(nameof(combatStats));
            }
            #endregion

            return EvoStatsToolbox.IsCombatStatsCriteriaMet(evoCriterionCombatStats, combatStats);
        }

        public static bool IsCareMistakeCriterionMet(EvoCriterionCareMistakes evoCriterionCareMistakes, int careMistakes)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionCareMistakes == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionCareMistakes));
            }
            #endregion

            return EvoStatsToolbox.IsMinMaxCriteriaMet(evoCriterionCareMistakes, careMistakes);
        }

        public static bool IsWeightCriterionMet(EvoCriterionWeight evoCriterionWeight, int weight)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionWeight == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionWeight));
            }
            #endregion

            return EvoStatsToolbox.IsValueRangeCriteriaMet(evoCriterionWeight, weight);
        }

        public static bool IsPrecursorCriterionMet(DigimonType? precursorDigimonCriterion, DigimonType userDigimonDigimonType)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (precursorDigimonCriterion == null)
            {
                throw new ArgumentNullException(nameof(precursorDigimonCriterion));
            }
            #endregion

            return EvoStatsToolbox.IsPrecursorCriteriaMet(precursorDigimonCriterion, userDigimonDigimonType);
        }

        public static bool IsTechniqueCriterionMet(EvoCriterionTech evoCriterionTech, int tech)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionTech == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionTech));
            }
            #endregion

            return EvoStatsToolbox.IsMinCriteriaMet(evoCriterionTech, tech);
        }

        public static bool IsHappinessCriteronMet(EvoCriterionHappiness evoCriterionHappiness, int happiness)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionHappiness == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionHappiness));
            }
            #endregion

            return EvoStatsToolbox.IsMinCriteriaMet(evoCriterionHappiness, happiness);
        }

        public static bool IsDisciplineCriterionMet(EvoCriterionDiscipline evoCriterionDiscipline, int discipline)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionDiscipline == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionDiscipline));
            }
            #endregion

            return EvoStatsToolbox.IsMinCriteriaMet(evoCriterionDiscipline, discipline);
        }

        public static bool IsBattleCriterionMet(EvoCriterionBattles evoCriterionBattles, int battles)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionBattles == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionBattles));
            }
            #endregion

            return EvoStatsToolbox.IsMinMaxCriteriaMet(evoCriterionBattles, battles);
        }

        public static int CalcEvoScore(EvoCriterionCombatStats evoCriterionCombatStats, CombatStats combatStats)
        {
            return EvoStatsToolbox.CalcEvoScore(evoCriterionCombatStats, combatStats);
        }

        public static int CalcCombatStatsCriterionCount(EvoCriterionCombatStats evoCriterionCombatStats)
        {
            #region Error handling
            // Error handling: Throw an exception explicitly stating the parameter that is null.
            if (evoCriterionCombatStats == null)
            {
                throw new ArgumentNullException(nameof(evoCriterionCombatStats));
            }
            #endregion

            return EvoStatsToolbox.CalcCombatStatsCriteriaCount(evoCriterionCombatStats);
        }
        #endregion
    }
}
