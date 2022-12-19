using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria
{
    public class EvoCriteriaBonus
    {
        public EvoCriterionHappiness Happiness { get; set; }

        public EvoCriterionDiscipline Discipline { get; set; }

        public EvoCriterionBattles Battles { get; set; }

        public EvoCriterionTech Tech { get; set; }

        public DigimonType? PrecursorDigimonType { get; set; }
    }
}