using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    class EvolutionCriteriaAgumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Rookie;

        public DigimonType DigimonType => DigimonType.Agumon;

        public int HP => 10;

        public int MP => 10;

        public int Off => 1;

        public int Def => 0;

        public int Speed => 0;

        public int Brains => 0;

        public bool IsCaremistakesCriteriaAMaximum => false;

        public int CareMistakes => 0;

        public int Weight => 15;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 0;

        public bool IsBattlesCriteriaAMaximum => false;

        public int Battles => 0;

        public int Tech => 0;

        public DigimonType? PrecursorDigimonType => DigimonType.Koromon;
    }
}
