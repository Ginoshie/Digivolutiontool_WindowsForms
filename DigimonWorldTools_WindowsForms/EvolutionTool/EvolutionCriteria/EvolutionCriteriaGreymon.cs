using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaGreymon : EvolutionCriteriaBase
    {
        public EvolutionCriteriaGreymon() : base(
            evolutionStage: EvolutionStage.Champion
            , digimonType: DigimonType.Greymon
            , hp: 0
            , mp: 0
            , off: 100
            , def: 100
            , speed: 100
            , brains: 100
            , isCaremistakesCriteriaAMaximum: true
            , careMistakes: 1
            , weight: 30
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 90
            , isBattlesCriteriaAMaximum: false
            , battles: 0
            , tech: 35
            , precursorDigimonType: null
        )
        { }
    }
}
