using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaMonochromon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Monochromon;

        public DigimonCombatStats DigimonCombatStats { get; } = new DigimonCombatStats()
        {
            HP = 1000
            , MP = 0
            , Off = 0
            , Def = 100
            , Speed = 0
            , Brains = 100
        };

        public bool IsCaremistakesCriteriaAMaximum => true;

        public int CareMistakes => 3;

        public int Weight => 40;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 0;

        public bool IsBattlesCriteriaAMaximum => true;

        public int Battles => 5;

        public int Tech => 35;

        public DigimonType? PrecursorDigimonType => null;
    }
}
