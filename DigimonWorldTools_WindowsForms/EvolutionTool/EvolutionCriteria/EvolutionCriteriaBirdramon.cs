using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaBirdramon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Birdramon;

        public DigimonCombatStats DigimonCombatStats { get; } = new DigimonCombatStats()
        {
            HP = 0
            , MP = 0
            , Off = 0
            , Def = 0
            , Speed = 100
            , Brains = 0
        };

        public bool IsCaremistakesCriteriaAMaximum => false;

        public int CareMistakes => 3;

        public int Weight => 20;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 0;

        public bool IsBattlesCriteriaAMaximum => false;

        public int Battles => 0;

        public int Tech => 35;

        public DigimonType? PrecursorDigimonType => DigimonType.Biyomon;
    }
}
