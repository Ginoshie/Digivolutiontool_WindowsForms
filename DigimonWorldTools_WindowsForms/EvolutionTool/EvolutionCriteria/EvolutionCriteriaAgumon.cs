using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    class EvolutionCriteriaAgumon : EvolutionCriteriaBase
    {
        public EvolutionCriteriaAgumon() : base(
            evolutionStage: EvolutionStage.Rookie
            , digimonType: DigimonType.Agumon
            , hp: 10
            , mp: 10
            , off: 1
            , def: 0
            , speed: 0
            , brains: 0
            , isCaremistakesCriteriaAMaximum: false
            , careMistakes: 0
            , weight: 15
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 0
            , isBattlesCriteriaAMaximum: false
            , battles: 0
            , tech: 0
            , precursorDigimonType: DigimonType.Koromon
        )
        { }
    }
}
