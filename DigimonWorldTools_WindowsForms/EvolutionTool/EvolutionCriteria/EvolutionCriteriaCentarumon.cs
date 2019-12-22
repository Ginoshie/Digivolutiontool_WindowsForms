using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaCentarumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Centarumon;

        public int HP => 0;

        public int MP => 0;

        public int Off => 0;

        public int Def => 0;

        public int Speed => 0;

        public int Brains => 100;

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
