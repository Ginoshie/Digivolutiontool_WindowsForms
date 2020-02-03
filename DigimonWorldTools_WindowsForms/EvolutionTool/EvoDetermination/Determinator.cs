using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox;
using DigimonWorldTools_WindowsForms.EvoTool;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;
using System;
using System.Collections.ObjectModel;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvoDetermination
{
    public class Determinator
    {
        public Determinator(UserDigimonDataObject UserDigimonDataObject)
        {
            UserDigimon = new UserDigimon()
            {
                // TODO: Create a view-viewmodel-model setup.
                DigimonType = UserDigimonDataObject.DigimonType,

                Stats = new Stats()
                {
                    CombatStats = UserDigimonDataObject.CombatStats,
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
            switch (DigimonToolbox.GetEvoStageUserDigimon(UserDigimon.DigimonType))
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

        private DigimonType DetermineEvoToRookieResult()
        {
            ParamsRookie evoParameters = new ParamsRookie();

            foreach (DigimonType evoTarget in DigimonToolbox.GetEvoTargetsListOfUserDigimon(UserDigimon.DigimonType))
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
            ParamsChampionAndUltimate evoParameters = new ParamsChampionAndUltimate();

            foreach (DigimonType evoTarget in DigimonToolbox.GetEvoTargetsListOfUserDigimon(UserDigimon.DigimonType))
            {
                SetEvolCriteriaOf(evoTarget);

                // If the evolution is not enabled then we do not compare the evolution score against  the current highest evolution score.
                if (!Toolbox.IsChampionOrUltimateEvoEnabled(EvoCriteria, UserDigimon))
                {
                    // Evolution is not enabled, continue with the next evolution target.
                    continue;
                }

                UpdateEvoParameters(evoParameters);
            }

            return evoParameters.HighestPrioEvo;
        }

        private void SetEvolCriteriaOf(DigimonType evoTarget)
        {
            EvoCriteria = EvoCriteriaReadOnlyDict[evoTarget].Invoke();
        }

        private void SetEvoCriteriaReadOnlyDict()
        {
            EvoCriteriaReadOnlyDict = ReadOnlyDictionaryFactory.CreateEvoCriteriaReadOnlyDictionary();
        }

        private bool IsRookieEvoEnabled(ParamsRookie evoParameters)
        {
            int CriteriaMetThresholdForEvo = 3;

            return (evoParameters.EvoScore >= CriteriaMetThresholdForEvo);
        }

        private void FillEvoParametersEvoTarget(ParamsRookie evoParameters)
        {
            evoParameters.EvoScore = 0;

            if (Toolbox.IsHighestCombatStatACriterion(EvoCriteria.CombatStats, UserDigimon.Stats.CombatStats)) { evoParameters.EvoScore++; }

            if (Toolbox.IsCareMistakeCriterionMet(EvoCriteria.CareMistakes, UserDigimon.Stats.CareMistakes)) { evoParameters.EvoScore++; }

            if (Toolbox.IsWeightCriterionMet(EvoCriteria.Weight, UserDigimon.Stats.Weight)) { evoParameters.EvoScore++; }

            if (Toolbox.IsAnyBonusCriterionMet(EvoCriteria.EvoCriteriaBonus, UserDigimon.BonusCritiaStats)) { evoParameters.EvoScore++; }
        }

        private void UpdateEvoParameters(ParamsRookie evoParameters)
        {
            if(evoParameters.EvoScore > evoParameters.HighestEvoScore)
            {
                evoParameters.HighestEvoScore = evoParameters.EvoScore;

                evoParameters.HighestPrioEvo = EvoCriteria.DigimonType;
            }
        }

        private void UpdateEvoParameters(ParamsChampionAndUltimate evoParameters)
        {
            evoParameters.AmountCriteriaStats = Toolbox.CalcEvoScore(EvoCriteria.CombatStats, UserDigimon.Stats.CombatStats); ;

            evoParameters.CriteriaStatCount = Toolbox.CalcCombatStatsCriterionCount(EvoCriteria.CombatStats);

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
    }
}