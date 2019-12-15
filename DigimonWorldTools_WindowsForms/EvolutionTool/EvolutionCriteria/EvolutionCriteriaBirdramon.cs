using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaBirdramon : EvolutionCriteriaBase
    {
        public EvolutionCriteriaBirdramon() : base(
            evolutionStage: EvolutionStage.Champion
            ,digimonType: DigimonType.Birdramon
            , hp: 0
            , mp: 0
            , off: 0
            , def: 0
            , speed: 100
            , brains: 0
            , isCaremistakesCriteriaAMaximum: false
            , careMistakes: 3
            , weight: 20
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 0
            , isBattlesCriteriaAMaximum: false
            , battles: 0
            , tech: 35
            , precursorDigimonType: DigimonType.Biyomon
        )
        { }
    }
}
