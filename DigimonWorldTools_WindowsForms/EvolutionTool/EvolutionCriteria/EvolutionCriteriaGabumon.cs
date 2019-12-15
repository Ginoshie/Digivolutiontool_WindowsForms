using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    class EvolutionCriteriaGabumon : EvolutionCriteriaBase
    {
        public EvolutionCriteriaGabumon() : base(
            evolutionStage: EvolutionStage.Rookie
            , digimonType: DigimonType.Gabumon
            , hp: 0
            , mp: 0
            , off: 0
            , def: 1
            , speed: 1
            , brains: 1
            , isCaremistakesCriteriaAMaximum: false
            , careMistakes: 0
            , weight: 15
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 0
            , isBattlesCriteriaAMaximum: false
            , battles: -2
            , tech: 0
            , precursorDigimonType: DigimonType.Koromon
        )
        { }
    }
}
