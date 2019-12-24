using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public class EvolutionDeterminator
    {
        public EvolutionDeterminator(UserDigimonDataObject UserDigimonDataObject)
        {
            UserDigimon = UserDigimonDataObject;

            SetEvolutionCriteriaReadOnlyDictionary();
        }

        private UserDigimonDataObject UserDigimon { get; set; }

        private IEvolutionCriteria EvolutionCriteria { get; set; }

        private ReadOnlyDictionary<DigimonType, Func<IEvolutionCriteria>> EvolutionCriteriaReadOnlyDictionary;

        public DigimonType DetermineEvolutionResult()
        {
            switch (GetEvolutionStageUserDigimon())
            {
                case EvolutionStage.Fresh:
                    return DigimonType.Numemon;
                case EvolutionStage.InTraining:
                    return DetermineEvolutionToRookieResult();
                case EvolutionStage.Rookie:
                    return DetermineEvolutionToChampionOrUltimateResult();
                case EvolutionStage.Champion:
                    return DigimonType.Numemon;
                case EvolutionStage.Ultimate:
                    return DigimonType.Numemon;
                default:
                    return DigimonType.Unknown;
            }
        }

        private EvolutionStage GetEvolutionStageUserDigimon()
        {
            return ReadOnlyDictionaryFactory.CreateEvolutionStageReadOnlyDictionary()[UserDigimon.DigimonType];
        }

        private DigimonType DetermineEvolutionToRookieResult()
        {
            EvolutionParamsRookie evolutionParams = new EvolutionParamsRookie();

            foreach (DigimonType evolutionTarget in GetEvolutionTargetsListOfUserDigimon())
            {
                SetEvolutionCriteriaOf(evolutionTarget);

                FillEvolutionParamsEvolutionTarget(evolutionParams);

                // If the evolution is not enabled then we do not compare the evolution score against  the current highest evolution score.
                if (!IsRookieEvolutionEnabled(evolutionParams))
                {
                    // Evolution is not enabled, continue with the next evolution target.
                    continue;
                }

                UpdateEvolutionParams(evolutionParams);
            }

            return evolutionParams.HighestPrioEvolution;
        }

        private DigimonType DetermineEvolutionToChampionOrUltimateResult()
        {
            EvolutionParamsChampionAndUltimate evolutionParameters = new EvolutionParamsChampionAndUltimate();

            foreach (DigimonType evolutionTarget in GetEvolutionTargetsListOfUserDigimon())
            {
                SetEvolutionCriteriaOf(evolutionTarget);

                // If the evolution is not enabled then we do not compare the evolution score against  the current highest evolution score.
                if (!IsChampionOrUltimateEvolutionEnabled())
                {
                    // Evolution is not enabled, continue with the next evolution target.
                    continue;
                }

                UpdateEvolutionParams(evolutionParameters);
            }

            return evolutionParameters.HighestPrioEvolution;
        }

        private IList<DigimonType> GetEvolutionTargetsListOfUserDigimon()
        {
            return ReadOnlyDictionaryFactory.CreateEvolutionTargetsReadOnlyDictionary()[UserDigimon.DigimonType];
        }

        private void SetEvolutionCriteriaOf(DigimonType evolutionTarget)
        {
            EvolutionCriteria = EvolutionCriteriaReadOnlyDictionary[evolutionTarget].Invoke();
        }

        private void SetEvolutionCriteriaReadOnlyDictionary()
        {
            EvolutionCriteriaReadOnlyDictionary = ReadOnlyDictionaryFactory.CreateEvolutionCriteriaDigimonReadOnlyDictionary();
        }

        private bool IsRookieEvolutionEnabled(EvolutionParamsRookie evolutionParams)
        {
            int CriteriaMetThresholdForEvolution = 3;

            return (evolutionParams.EvolutionScore >= CriteriaMetThresholdForEvolution);
        }

        private bool IsChampionOrUltimateEvolutionEnabled()
        {
            int NrOfCriteriaMet = 0;

            int CriteriaMetThresholdForEvolution = 3;

            #region MainCriteriaCheckCalls
            if (IsStatCriteriaMet()) { NrOfCriteriaMet++; }

            if (IsCareMistakesCriteriaMet()) { NrOfCriteriaMet++; }

            if (IsWeightCriteriaMet()) { NrOfCriteriaMet++; }
            #endregion

            // Main criteria have been checked, check if enough criteria have been met already.
            if (NrOfCriteriaMet == CriteriaMetThresholdForEvolution) { return true; }

            #region BonusCriteriaCheckCalls
            if (PreCursorCriteriaMet()
                || NrOfTechniquesCriteria()
                || HappinessCriteria()
                || DisciplineCriteria()
                || BattlesFoughtCriteria()
            )
            {
                NrOfCriteriaMet++;
            }
            #endregion

            return (NrOfCriteriaMet >= CriteriaMetThresholdForEvolution);          
        }

        private void FillEvolutionParamsEvolutionTarget(EvolutionParamsRookie evolutionParams)
        {
            evolutionParams.EvolutionScore = 0;

            if (IsHighestStatAStatCriteria() && IsStatCriteriaMet()) { evolutionParams.EvolutionScore++; }

            if (IsCareMistakesCriteriaMet()) { evolutionParams.EvolutionScore++; }

            if (IsWeightCriteriaMet()) { evolutionParams.EvolutionScore++; }

            if (PreCursorCriteriaMet()) { evolutionParams.EvolutionScore++; }
        }

        private void UpdateEvolutionParams(EvolutionParamsRookie evolutionParams)
        {
            if(evolutionParams.EvolutionScore > evolutionParams.HighestEvolutionScore)
            {
                evolutionParams.HighestEvolutionScore = evolutionParams.EvolutionScore;

                evolutionParams.HighestPrioEvolution = EvolutionCriteria.DigimonType;
            }
        }

        private void UpdateEvolutionParams(EvolutionParamsChampionAndUltimate evolutionParams)
        {
            evolutionParams.AmountCriteriaStats = DetermineAmountCriteriaStats();

            evolutionParams.CriteriaStatCount = DetermineCriteriaStatCount();

            // Evolution has higher prio then stored evolution so overwrite current evolution.
            if (evolutionParams.EvolutionScore > evolutionParams.HighestEvolutionScore)
            {
                evolutionParams.HighestEvolutionScore = evolutionParams.EvolutionScore;

                evolutionParams.HighestPrioEvolution = EvolutionCriteria.DigimonType;
            }
            // Evolution has lower prio then stored evolution, store stat count and amount for next calculation.
            else
            {
                evolutionParams.CarriedOverAmountStats =  evolutionParams.EvolutionScore;

                evolutionParams.CarriedOverCriteriaStatCount = (evolutionParams.CriteriaStatCount + evolutionParams.CarriedOverCriteriaStatCount);
            }
        }

       #region MainCriteriaChecksMethods
        private bool IsStatCriteriaMet()
        {
            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvolutionCriteria.EvoCriteriaCombatStats.HP > 0 && UserDigimon.DigimonCombatStats.HP < EvolutionCriteria.EvoCriteriaCombatStats.HP)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvolutionCriteria.EvoCriteriaCombatStats.MP > 0 && UserDigimon.DigimonCombatStats.MP < EvolutionCriteria.EvoCriteriaCombatStats.MP)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Off > 0 && UserDigimon.DigimonCombatStats.Off < EvolutionCriteria.EvoCriteriaCombatStats.Off)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Def > 0 && UserDigimon.DigimonCombatStats.Def < EvolutionCriteria.EvoCriteriaCombatStats.Def)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Speed > 0 && UserDigimon.DigimonCombatStats.Speed < EvolutionCriteria.EvoCriteriaCombatStats.Speed)
            {
                return false;
            }

            // When the stat is relevant and the criteria is not met, then the statCriteria as a whole is failed.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Brains > 0 && UserDigimon.DigimonCombatStats.Brains < EvolutionCriteria.EvoCriteriaCombatStats.Brains)
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

            if (EvolutionCriteria.EvoCriteriaCombatStats.HP > 0 && UserDigimon.DigimonCombatStats.HP > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.DigimonCombatStats.HP;

                HighestStat = "HP";
            }

            if (EvolutionCriteria.EvoCriteriaCombatStats.MP > 0 && UserDigimon.DigimonCombatStats.MP > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.DigimonCombatStats.MP;

                HighestStat = "MP";
            }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Off > 0 && UserDigimon.DigimonCombatStats.Off > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.DigimonCombatStats.Off;

                HighestStat = "Off";
            }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Def > 0 && UserDigimon.DigimonCombatStats.Def > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.DigimonCombatStats.Def;

                HighestStat = "Def";
            }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Speed > 0 && UserDigimon.DigimonCombatStats.Speed > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.DigimonCombatStats.Speed;

                HighestStat = "Speed";
            }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Brains > 0 && UserDigimon.DigimonCombatStats.Brains > AmountHighestStat)
            {
                AmountHighestStat = UserDigimon.DigimonCombatStats.Brains;

                HighestStat = "Brains";
            }

            switch (HighestStat)
            {
                case "HP":
                    return (EvolutionCriteria.EvoCriteriaCombatStats.HP > 0);
                case "MP":
                    return (EvolutionCriteria.EvoCriteriaCombatStats.MP > 0);
                case "Off":
                    return (EvolutionCriteria.EvoCriteriaCombatStats.Off > 0);
                case "Def":
                    return (EvolutionCriteria.EvoCriteriaCombatStats.Def > 0);
                case "Speed":
                    return (EvolutionCriteria.EvoCriteriaCombatStats.Speed > 0);
                case "Brains":
                    return (EvolutionCriteria.EvoCriteriaCombatStats.Brains > 0);
                default:
                    return false;
            };
        }

        private bool IsCareMistakesCriteriaMet()
        {
            // Check logic is based on the criteria being a maximum or minimum.
            if (EvolutionCriteria.EvoCriteriaCareMistakes.IsCareMistakesCriteriaAMaximum)
            {
                // Caremistakes criteria is a maximum.
                return (UserDigimon.CareMistakes <= EvolutionCriteria.EvoCriteriaCareMistakes.CareMistakes);
            }
            else
            {
                // Caremiistakes criteria is a minimum.
                return (UserDigimon.CareMistakes >= EvolutionCriteria.EvoCriteriaCareMistakes.CareMistakes);
            }
        }

        private bool IsWeightCriteriaMet()
        {
            int minimumWeightCriteria = EvolutionCriteria.EvoCriteriaWeight.Weight - EvolutionCriteria.EvoCriteriaWeight.MaxDeviationFromWeightBoundsIncluded;

            int maximumWeightCriteria = EvolutionCriteria.EvoCriteriaWeight.Weight + EvolutionCriteria.EvoCriteriaWeight.MaxDeviationFromWeightBoundsIncluded;

            // Digimon weight is within minimum and maximum range, bounds included.
            if (UserDigimon.Weight >= minimumWeightCriteria && UserDigimon.Weight <= maximumWeightCriteria)
            {
                return true;
            }

            return false;
        }

        private int DetermineAmountCriteriaStats()
        {
            int AmountStats = 0;

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvolutionCriteria.EvoCriteriaCombatStats.HP > 0) { AmountStats += (UserDigimon.DigimonCombatStats.HP / 10); };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvolutionCriteria.EvoCriteriaCombatStats.MP > 0) { AmountStats += (UserDigimon.DigimonCombatStats.MP / 10); };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Off > 0) { AmountStats += UserDigimon.DigimonCombatStats.Off; };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Def > 0) { AmountStats += UserDigimon.DigimonCombatStats.Def; };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Speed > 0) { AmountStats += UserDigimon.DigimonCombatStats.Speed; };

            // Only add the userdigimons stats if the stat is part of the stat criteria.
            if (EvolutionCriteria.EvoCriteriaCombatStats.Brains > 0) { AmountStats += UserDigimon.DigimonCombatStats.Brains; };

            return AmountStats;
        }

        private int DetermineCriteriaStatCount()
        {
            int StatCount = 0;

            // If this stat is a criteria stat then up AmountCriteriaStats by 1.
            if (EvolutionCriteria.EvoCriteriaCombatStats.HP > 0) { StatCount++; }

            if (EvolutionCriteria.EvoCriteriaCombatStats.MP > 0) { StatCount++; }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Off > 0) { StatCount++; }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Def > 0) { StatCount++; }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Speed > 0) { StatCount++; }

            if (EvolutionCriteria.EvoCriteriaCombatStats.Brains > 0) { StatCount++; }

            return StatCount;
        }
        #endregion

        #region BonusCriteriaChecksMethodes
        private bool PreCursorCriteriaMet()
        {
            // Only check this bonus criteria if it is relevant.
            return (EvolutionCriteria.PrecursorDigimonType != null && UserDigimon.DigimonType.Equals(EvolutionCriteria.PrecursorDigimonType));
        }

        private bool NrOfTechniquesCriteria()
        {
            return (UserDigimon.Tech >= EvolutionCriteria.Tech);
        }

        private bool HappinessCriteria()
        {
            // Only check this bonus criteria if it is relevant.
            return (EvolutionCriteria.Happiness > 0 && UserDigimon.Happiness > EvolutionCriteria.Happiness);
        }

        private bool DisciplineCriteria()
        {
            // Only check this bonus criteria if it is relevant.
            return (EvolutionCriteria.Discipline > 0 && UserDigimon.Discipline > EvolutionCriteria.Discipline);
        }

        private bool BattlesFoughtCriteria()
        {
            // Check logic is based on the criteria being a maximum or minimum. 
            if (EvolutionCriteria.EvoCriteriaBattles.IsBattlesCriteriaAMaximum)
            {
                // Battles criteria is a maximum.
                return (UserDigimon.Battles <= EvolutionCriteria.EvoCriteriaBattles.Battles);
            }
            else
            {
                // Battles criteria is a minimum.
                return (UserDigimon.Battles >= EvolutionCriteria.EvoCriteriaBattles.Battles);
            }
        }
        #endregion
    }
}