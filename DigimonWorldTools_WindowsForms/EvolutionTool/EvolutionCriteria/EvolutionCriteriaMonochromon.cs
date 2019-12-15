using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaMonochromon : EvolutionCriteriaBase
    {
        public EvolutionCriteriaMonochromon() : base(
            evolutionStage: EvolutionStage.Champion
            , digimonType: DigimonType.Monochromon
            , hp: 1000
            , mp: 0
            , off: 0
            , def: 100
            , speed: 0
            , brains: 100
            , isCaremistakesCriteriaAMaximum: true
            , careMistakes: 3
            , weight: 40
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 0
            , isBattlesCriteriaAMaximum: true
            , battles: 5
            , tech: 35
            , precursorDigimonType: null
        )
        {}
    }
}
