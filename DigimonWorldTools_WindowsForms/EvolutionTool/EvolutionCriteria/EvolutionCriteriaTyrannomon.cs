using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaTyrannomon: IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Tyrannomon;

        public int HP => 1000;

        public int MP => 0;

        public int Off => 0;

        public int Def => 100;

        public int Speed => 0;

        public int Brains => 0;

        public bool IsCaremistakesCriteriaAMaximum => true;

        public int CareMistakes => 5;

        public int Weight => 30;

        public int MaxDeviationFromWeightBoundsIncluded => 5;

        public int Happiness => 0;

        public int Discipline => 0;

        public bool IsBattlesCriteriaAMaximum => true;

        public int Battles => 5;

        public int Tech => 28;

        public DigimonType? PrecursorDigimonType => DigimonType.Biyomon;
    }
}
