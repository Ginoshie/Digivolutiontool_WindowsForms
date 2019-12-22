using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    class EvolutionCriteriaGabumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Rookie;

        public DigimonType DigimonType => DigimonType.Gabumon;

        public DigimonCombatStats DigimonCombatStats { get; } = new DigimonCombatStats()
        {
            HP = 0
            , MP = 0
            , Off = 0
            , Def = 1
            , Speed = 0
            , Brains = 0
        };

        public bool IsCaremistakesCriteriaAMaximum => false;

        public int CareMistakes => 0;

        public int Weight => 15;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 0;

        public bool IsBattlesCriteriaAMaximum => false;

        public int Battles => -2;

        public int Tech => 0;

        public DigimonType? PrecursorDigimonType => DigimonType.Koromon;
    }
}
