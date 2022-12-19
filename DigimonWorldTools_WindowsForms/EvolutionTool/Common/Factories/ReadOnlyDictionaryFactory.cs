using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion;
using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Rookie;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories
{
    public static class ReadOnlyDictionaryFactory
    {
        public static ReadOnlyDictionary<DigimonType, IList<DigimonType>> CreateEvoTargetsReadOnlyDictionary()
        {
            var EvoTargetsDict = new Dictionary<DigimonType, IList<DigimonType>>()
            {
                { DigimonType.Koromon, EvoTargetsListFactory.KoromonEvo },
                { DigimonType.Agumon, EvoTargetsListFactory.AgumonEvo },
                { DigimonType.Birdramon, new List<DigimonType>() { } },
                { DigimonType.Greymon, new List<DigimonType>() { } },
                { DigimonType.Palmon, new List<DigimonType>() { } }
            };

            return new ReadOnlyDictionary<DigimonType, IList<DigimonType>>(EvoTargetsDict);
        }

        public static ReadOnlyDictionary<DigimonType, EvoStage> CreateEvoStageReadOnlyDictionary()
        {
            var EvoStageDict = new Dictionary<DigimonType, EvoStage>()
            {
                { DigimonType.Koromon, EvoStage.InTraining }, { DigimonType.Agumon, EvoStage.Rookie }
            };

            return new ReadOnlyDictionary<DigimonType, EvoStage>(EvoStageDict);
        }

        public static ReadOnlyDictionary<DigimonType, Func<IEvoCriteria>> CreateEvoCriteriaReadOnlyDictionary()
        {
            var EvoCriteriaDigimonDict = new Dictionary<DigimonType, Func<IEvoCriteria>>()
            {
                { DigimonType.Gabumon, () => { return new Gabumon(); } },
                { DigimonType.Agumon, () => { return new Agumon(); } },
                { DigimonType.Greymon, () => { return new Greymon(); } },
                { DigimonType.Birdramon, () => { return new Birdramon(); } },
                { DigimonType.Centarumon, () => { return new Centarumon(); } },
                { DigimonType.Tyrannomon, () => { return new Tyrannomon(); } },
                { DigimonType.Monochromon, () => { return new Monochromon(); } }
            };

            return new ReadOnlyDictionary<DigimonType, Func<IEvoCriteria>>(EvoCriteriaDigimonDict);
        }
    }
}