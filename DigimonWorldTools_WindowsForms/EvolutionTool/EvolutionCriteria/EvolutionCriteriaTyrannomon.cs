using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaTyrannomon: EvolutionCriteriaBase
    {
        public EvolutionCriteriaTyrannomon() : base(
            evolutionStage: EvolutionStage.Champion
            , digimonType: DigimonType.Tyrannomon
            , hp: 1000
            , mp: 0
            , off: 0
            , def: 100
            , speed: 0
            , brains: 0
            , isCaremistakesCriteriaAMaximum: true
            , careMistakes: 5
            , weight: 30
            , maxDeviationFromWeightBoundsIncluded: 5
            , happiness: 0
            , discipline: 0
            , isBattlesCriteriaAMaximum: true
            , battles: 5
            , tech: 28
            , precursorDigimonType: DigimonType.Biyomon
        )
        { }
    }
}
