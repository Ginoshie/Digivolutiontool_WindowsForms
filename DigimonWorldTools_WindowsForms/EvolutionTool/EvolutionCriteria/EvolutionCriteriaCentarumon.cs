using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaCentarumon : EvolutionCriteriaBase
    {
        public EvolutionCriteriaCentarumon() : base(
            evolutionStage: EvolutionStage.Champion
            , digimonType: DigimonType.Centarumon
            , hp: 0
            , mp: 0
            , off: 0
            , def: 0
            , speed: 0
            , brains: 100
            , isCaremistakesCriteriaAMaximum: true
            , careMistakes: 3
            , weight: 30
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 60
            , isBattlesCriteriaAMaximum: false
            , battles: 0
            , tech: 28
            , precursorDigimonType: null
        )
        { }
    }
}
