using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaGreymon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Greymon;

        public DigimonCombatStats DigimonCombatStats { get; } = new DigimonCombatStats()
        {
            HP = 0
            , MP = 0
            , Off = 100
            , Def = 100
            , Speed = 100
            , Brains = 100
        };

        public bool IsCaremistakesCriteriaAMaximum => true;

        public int CareMistakes => 1;

        public int Weight => 30;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 90;

        public bool IsBattlesCriteriaAMaximum => false;

        public int Battles => 0;

        public int Tech => 35;

        public DigimonType? PrecursorDigimonType => null;
    }
}
