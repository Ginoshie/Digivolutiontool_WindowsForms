using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using System.Collections.Generic;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox
{
    public static class DigimonToolbox
    {
        public static EvoStage GetEvoStageUserDigimon(DigimonType userDigimonDigimonType)
        {
            return ReadOnlyDictionaryFactory.CreateEvoStageReadOnlyDictionary()[userDigimonDigimonType];
        }

        public static IList<DigimonType> GetEvoTargetsListOfUserDigimon(DigimonType userDigimonDigimonType)
        {
            return ReadOnlyDictionaryFactory.CreateEvoTargetsReadOnlyDictionary()[userDigimonDigimonType];
        }
    }
}
