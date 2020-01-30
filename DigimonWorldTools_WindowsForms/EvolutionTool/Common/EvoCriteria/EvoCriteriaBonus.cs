using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria
{
    public class EvoCriteriaBonus
    {
        public EvoCriteriaHappiness Happiness { get; set; }

        public EvoCriteriaDiscipline Discipline { get; set; }

        public EvoCriteriaBattles Battles { get; set; }

        public EvoCriteriaTech Tech { get; set; }

        public DigimonType? PrecursorDigimonType {get; set;}
    }
}
