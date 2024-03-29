﻿using System.Collections.Generic;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Factories;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Toolbox;

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