using DigimonWorldTools_WindowsForms.EvolutionTool;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DigimonWorldTools_WindowsForms.EvoTool
{
    public class EvoDeterminator
    {
        public EvoDeterminator(UserDigimonDataObject UserDigimonDataObject)
        {
            UserDigimon = new UserDigimon()
            {
                // TODO: Create a view-viewmodel-model setup.
                DigimonType = UserDigimonDataObject.DigimonType,

                Stats = new Stats()
                {
                    DigimonCombatStats = UserDigimonDataObject.DigimonCombatStats,
                    CareMistakes = UserDigimonDataObject.CareMistakes,
                    Weight = UserDigimonDataObject.Weight,
                    Tech = UserDigimonDataObject.Tech,
                    Happiness = UserDigimonDataObject.Happiness,
                    Discipline = UserDigimonDataObject.Discipline,
                    Battles = UserDigimonDataObject.Battles
                }
            };
                
            SetEvoCriteriaReadOnlyDict();
        }

        private UserDigimon UserDigimon { get; set; }

        private IEvoCriteria EvoCriteria { get; set; }

        private ReadOnlyDictionary<DigimonType, Func<IEvoCriteria>> EvoCriteriaReadOnlyDict;

        public DigimonType DetermineEvoResult()
        {
            switch (GetEvoStageUserDigimon())
            {
                case EvoStage.Baby:
                    return DigimonType.Numemon;
                case EvoStage.InTraining:
                    return DetermineEvoToRookieResult();
                case EvoStage.Rookie:
                    return DetermineEvoToChampionOrUltimateResult();
                case EvoStage.Champion:
                    return DigimonType.Numemon;
                case EvoStage.Ultimate:
                    return DigimonType.Numemon;
                default:
                    return DigimonType.Unknown;
            }
        }

        private EvoStage GetEvoStageUserDigimon()
        {
            return ReadOnlyDictionaryFactory.CreateEvoStageReadOnlyDictionary()[UserDigimon.DigimonType];
        }

        private DigimonType DetermineEvoToRookieResult()
        {
            EvoParametersRookie evoParameters = new EvoParametersRookie();

            foreach (DigimonType evoTarget in GetEvoTargetsListOfUserDigimon())
            {
                SetEvolCriteriaOf(evoTarget);

                FillEvoParametersEvoTarget(evoParameters);

                // If the evolution is not enabled then we do not compare the evolution score against  the current highest evolution score.
                if (!IsRookieEvoEnabled(evoParameters))
                {
                    // Evolution is not enabled, continue with the next evolution target.
                    continue;
                }

                UpdateEvoParameters(evoParameters);
            }

            return evoParameters.HighestPrioEvo;
        }

        private DigimonType DetermineEvoToChampionOrUltimateResult()
        {
            EvoParametersChampionAndUltimate evoParameters = new EvoParametersChampionAndUltimate();

            foreach (DigimonType evoTarget in GetEvoTargetsListOfUserDigimon())
            {
                SetEvolCriteriaOf(evoTarget);

                // If the evolution is not enabled then we do not compare the evolution score against  the current highest evolution score.
                if (!IsChampionOrUltimateEvoEnabled())
                {
                    // Evolution is not enabled, continue with the next evolution target.
                    continue;
                }

                UpdateEvoParameters(evoParameters);
            }

            return evoParameters.HighestPrioEvo;
        }

        private IList<DigimonType> GetEvoTargetsListOfUserDigimon()
        {
            return ReadOnlyDictionaryFactory.CreateEvoTargetsReadOnlyDictionary()[UserDigimon.DigimonType];
        }

        private void SetEvolCriteriaOf(DigimonType evoTarget)
        {
            EvoCriteria = EvoCriteriaReadOnlyDict[evoTarget].Invoke();
        }

        private void SetEvoCriteriaReadOnlyDict()
        {
            EvoCriteriaReadOnlyDict = ReadOnlyDictionaryFactory.CreateEvoCriteriaReadOnlyDictionary();
        }

        private bool IsRookieEvoEnabled(EvoParametersRookie evoParameters)
        {
            int CriteriaMetThresholdForEvo = 3;

            return (evoParameters.EvoScore >= CriteriaMetThresholdForEvo);
        }

        private bool IsChampionOrUltimateEvoEnabled()
        {
            int NrOfCriteriaMet = 0;

            int CriteriaMetThresholdForEvo = 3;

            int MaxBonusCriteriaMetCount = 1;

            int CriteriaMetThresholdToContinue = CriteriaMetThresholdForEvo - MaxBonusCriteriaMetCount;

            NrOfCriteriaMet = EvoToolbox.AmtMainCriteriaMet(EvoCriteria, UserDigimon);

            // Check if enough evolution criteria have been met to enable the evolution.
            if (NrOfCriteriaMet == CriteriaMetThresholdForEvo) { return true; }

            // Check if too little criteria are met and evolution cannot be enabled even with a bonus criteria.
            if (NrOfCriteriaMet < CriteriaMetThresholdToContinue) { return false; }

            // Return the result directly as this is the check which can enable the evolution.
            return EvoToolbox.IsAnyBonusCriteriaMet(EvoCriteria, UserDigimon);
        }

        private void FillEvoParametersEvoTarget(EvoParametersRookie evoParameters)
        {
            evoParameters.EvoScore = 0;

            if (IsHighestStatAStatCriteria() && IsStatCriteriaMet()) { evoParameters.EvoScore++; }

            if (IsCareMistakesCriteriaMet()) { evoParameters.EvoScore++; }

            if (IsWeightCriteriaMet()) { evoParameters.EvoScore++; }

            if (PreCursorCriteriaMet()) { evoParameters.EvoScore++; }
        }

        private void UpdateEvoParameters(EvoParametersRookie evoParameters)
        {
            if(evoParameters.EvoScore > evoParameters.HighestEvoScore)
            {
                evoParameters.HighestEvoScore = evoParameters.EvoScore;

                evoParameters.HighestPrioEvo = EvoCriteria.DigimonType;
            }
        }

        private void UpdateEvoParameters(EvoParametersChampionAndUltimate evoParameters)
        {
            evoParameters.AmountCriteriaStats = DetermineAmountCriteriaStats();

            evoParameters.CriteriaStatCount = DetermineCriteriaStatCount();

            // Evolution has higher prio then stored evolution so overwrite current evolution.
            if (evoParameters.EvoScore > evoParameters.HighestEvoScore)
            {
                evoParameters.HighestEvoScore = evoParameters.EvoScore;

                evoParameters.HighestPrioEvo = EvoCriteria.DigimonType;
            }
            // Evolution has lower prio then stored evolution, store stat count and amount for next calculation.
            else
            {
                evoParameters.CarriedOverAmountStats =  evoParameters.EvoScore;

                evoParameters.CarriedOverCriteriaStatCount = (evoParameters.CriteriaStatCount + evoParameters.CarriedOverCriteriaStatCount);
            }
        }

       #region MainCriteriaChecksMethods
        private bool IsStatCriteriaMet()
        {
            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvoCriteria.CombatStats.HP > 0 && UserDigimon.Stats.DigimonCombatStats.HP < EvoCriteria.CombatStats.HP)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvoCriteria.CombatStats.MP > 0 && UserDigimon.Stats.DigimonCombatStats.MP < EvoCriteria.CombatStats.MP)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvoCriteria.CombatStats.Off > 0 && UserDigimon.Stats.DigimonCombatStats.Off < EvoCriteria.CombatStats.Off)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvoCriteria.CombatStats.Def > 0 && UserDigimon.Stats.DigimonCombatStats.Def < EvoCriteria.CombatStats.Def)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvoCriteria.CombatStats.Speed > 0 && UserDigimon.Stats.DigimonCombatStats.Speed < EvoCriteria.CombatStats.Speed)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvoCriteria.CombatStats.Brains > 0 && UserDigimon.Stats.DigimonCombatStats.Brains < EvoCriteria.CombatStats.Brains)
            {
                return false;
            }

            // All relevant stat criteria were met.
            return true;
        }

        private bool IsHighestStatAStatCriteria()
        {
            int AmountHighestStat = 0;

            string HighestStat = "";

            if (EvoCriteria.CombatStats.HP > 0 && UserDigimon.Stats.DigimonCombatStats.HP > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.Stats.DigimonCombatStats.HP;

                HighestStat = "HP";
            }

            if (EvoCriteria.CombatStats.MP > 0 && UserDigimon.Stats.DigimonCombatStats.MP > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.Stats.DigimonCombatStats.MP;

                HighestStat = "MP";
            }

            if (EvoCriteria.CombatStats.Off > 0 && UserDigimon.Stats.DigimonCombatStats.Off > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.Stats.DigimonCombatStats.Off;

                HighestStat = "Off";
            }

            if (EvoCriteria.CombatStats.Def > 0 && UserDigimon.Stats.DigimonCombatStats.Def > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.Stats.DigimonCombatStats.Def;

                HighestStat = "Def";
            }

            if (EvoCriteria.CombatStats.Speed > 0 && UserDigimon.Stats.DigimonCombatStats.Speed > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.Stats.DigimonCombatStats.Speed;

                HighestStat = "Speed";
            }

            if (EvoCriteria.CombatStats.Brains > 0 && UserDigimon.Stats.DigimonCombatStats.Brains > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.Stats.DigimonCombatStats.Brains;

                HighestStat = "Brains";
            }

            switch (HighestStat)
            {
                case "HP":
                    return (EvoCriteria.CombatStats.HP > 0);
                case "MP":
                    return (EvoCriteria.CombatStats.MP > 0);
                case "Off":
                    return (EvoCriteria.CombatStats.Off > 0);
                case "Def":
                    return (EvoCriteria.CombatStats.Def > 0);
                case "Speed":
                    return (EvoCriteria.CombatStats.Speed > 0);
                case "Brains":
                    return (EvoCriteria.CombatStats.Brains > 0);
                default:
                    return false;
            };
        }

        private bool IsCareMistakesCriteriaMet()
        {
            // Check logic is based on the criteria being a maximum or minimum.
            if (EvoCriteria.CareMistakes.IsMax)
            {
                // Caremistakes criteria is a maximum.
                return (UserDigimon.Stats.CareMistakes <= EvoCriteria.CareMistakes.Value);
            }
            else
            {
                // Caremiistakes criteria is a minimum.
                return (UserDigimon.Stats.CareMistakes >= EvoCriteria.CareMistakes.Value);
            }
        }

        private bool IsWeightCriteriaMet()
        {
            int minimumWeightCriteria = EvoCriteria.Weight.Value - EvoCriteria.Weight.MaxDeviationBoundsIncluded;

            int maximumWeightCriteria = EvoCriteria.Weight.Value + EvoCriteria.Weight.MaxDeviationBoundsIncluded;

            // Digimon weight is within minimum and maximum range, bounds included.
            if (UserDigimon.Stats.Weight >= minimumWeightCriteria && UserDigimon.Stats.Weight <= maximumWeightCriteria)
            {
                return true;
            }

            return false;
        }

        private int DetermineAmountCriteriaStats()
        {
            int AmountStats = 0;

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvoCriteria.CombatStats.HP > 0) { AmountStats += (UserDigimon.Stats.DigimonCombatStats.HP / 10); };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvoCriteria.CombatStats.MP > 0) { AmountStats += (UserDigimon.Stats.DigimonCombatStats.MP / 10); };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvoCriteria.CombatStats.Off > 0) { AmountStats += UserDigimon.Stats.DigimonCombatStats.Off; };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvoCriteria.CombatStats.Def > 0) { AmountStats += UserDigimon.Stats.DigimonCombatStats.Def; };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvoCriteria.CombatStats.Speed > 0) { AmountStats += UserDigimon.Stats.DigimonCombatStats.Speed; };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvoCriteria.CombatStats.Brains > 0) { AmountStats += UserDigimon.Stats.DigimonCombatStats.Brains; };

            return AmountStats;
        }

        private int DetermineCriteriaStatCount()
        {
            int StatCount = 0;

            // If this stat is a criteria stat then up AmountCriteriaStats by 1.
            if (EvoCriteria.CombatStats.HP > 0) { StatCount++; }

            if (EvoCriteria.CombatStats.MP > 0) { StatCount++; }

            if (EvoCriteria.CombatStats.Off > 0) { StatCount++; }

            if (EvoCriteria.CombatStats.Def > 0) { StatCount++; }

            if (EvoCriteria.CombatStats.Speed > 0) { StatCount++; }

            if (EvoCriteria.CombatStats.Brains > 0) { StatCount++; }

            return StatCount;
        }
        #endregion

       #region BonusCriteriaChecksMethodes
        private bool PreCursorCriteriaMet()
        {
            // Only check this bonus criteria if it is relevant.
            return (EvoCriteria.PrecursorDigimonType != null && UserDigimon.DigimonType.Equals(EvoCriteria.PrecursorDigimonType));
        }

        private bool NrOfTechniquesCriteria()
        {
            return (UserDigimon.Stats.Tech >= EvoCriteria.Tech.Value);
        }

        private bool HappinessCriteria()
        {
            // Only check this bonus criteria if it is relevant.
            return (EvoCriteria.Happiness.Value > 0 && UserDigimon.Stats.Happiness > EvoCriteria.Happiness.Value);
        }

        private bool DisciplineCriteria()
        {
            // Only check this bonus criteria if it is relevant.
            return (EvoCriteria.Discipline.Value > 0 && UserDigimon.Stats.Discipline > EvoCriteria.Discipline.Value);
        }

        private bool BattlesFoughtCriteria()
        {
            // Check logic is based on the criteria being a maximum or minimum. 
            if (EvoCriteria.Battles.IsMax)
            {
                // Battles criteria is a maximum.
                return (UserDigimon.Stats.Battles <= EvoCriteria.Battles.Value);
            }
            else
            {
                // Battles criteria is a minimum.
                return (UserDigimon.Stats.Battles >= EvoCriteria.Battles.Value);
            }
        }
        #endregion*/
    }
}