using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Digimon.Champion;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Digimon.Rookie;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common
{
    public static class ReadOnlyDictionaryFactory
    {
        public static ReadOnlyDictionary<DigimonType, IList<DigimonType>> CreateEvoTargetsReadOnlyDictionary()
        {
            var EvolutionTargetsDictionary = new Dictionary<DigimonType, IList<DigimonType>>()
                {
                    { DigimonType.Koromon, EvolutionTargetsListFactory.KoromonEvolutions }
                    , { DigimonType.Agumon, EvolutionTargetsListFactory.AgumonEvolutions }
                    , { DigimonType.Birdramon, new List<DigimonType> (){} }
                    , { DigimonType.Greymon, new List<DigimonType> (){} }
                    , { DigimonType.Palmon, new List<DigimonType> (){} }
                };

            return new ReadOnlyDictionary<DigimonType, IList<DigimonType>>(EvolutionTargetsDictionary);
        }

        public static ReadOnlyDictionary<DigimonType, EvolutionStage> CreateEvoStageReadOnlyDictionary()
        {
            var EvolutionStageDictionary = new Dictionary<DigimonType, EvolutionStage>()
            {
                {DigimonType.Koromon, EvolutionStage.InTraining }
                , {DigimonType.Agumon, EvolutionStage.Rookie }
            };

            return new ReadOnlyDictionary<DigimonType, EvolutionStage>(EvolutionStageDictionary);
        }

        public static ReadOnlyDictionary<DigimonType, Func<IEvolutionCriteria>> CreateEvoCriteriaReadOnlyDictionary()
        {
            var EvolutionCriteriaDigimonDictionary = new Dictionary<DigimonType, Func<IEvolutionCriteria>>()
            {
                { DigimonType.Gabumon, () => { return new EvolutionCriteriaGabumon(); } }
                , { DigimonType.Agumon, () => { return new EvolutionCriteriaAgumon(); } }
                , { DigimonType.Greymon, () => { return new EvolutionCriteriaGreymon(); } }
                , { DigimonType.Birdramon, () => { return new EvolutionCriteriaBirdramon(); } }
                , { DigimonType.Centarumon, () => { return new EvolutionCriteriaCentarumon(); } }
                , { DigimonType.Tyrannomon, () => { return new EvolutionCriteriaTyrannomon(); } }
                , { DigimonType.Monochromon, () => { return new EvolutionCriteriaMonochromon(); } }
            };

            return new ReadOnlyDictionary<DigimonType, Func<IEvolutionCriteria>>(EvolutionCriteriaDigimonDictionary);
        }            
    }
}
