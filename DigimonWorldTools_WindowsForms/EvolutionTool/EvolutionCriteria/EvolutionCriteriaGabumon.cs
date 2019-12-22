using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    class EvolutionCriteriaGabumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Rookie;

        public DigimonType DigimonType => DigimonType.Gabumon;

        public int HP => 0;

        public int MP => 0;

        public int Off => 0;

        public int Def => 1;

        public int Speed => 1;

        public int Brains => 1;

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
