using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaCentarumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Centarumon;

        public DigimonCombatStats DigimonCombatStats { get; } = new DigimonCombatStats()
        {
            HP = 0
            , MP = 0
            , Off = 0
            , Def = 0
            , Speed = 0
            , Brains = 100
        };

        public bool IsCaremistakesCriteriaAMaximum => true;

        public int CareMistakes => 3;

        public int Weight => 30;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 60;

        public bool IsBattlesCriteriaAMaximum => false;

        public int Battles => 0;

        public int Tech => 28;

        public DigimonType? PrecursorDigimonType => null;
    }
}
