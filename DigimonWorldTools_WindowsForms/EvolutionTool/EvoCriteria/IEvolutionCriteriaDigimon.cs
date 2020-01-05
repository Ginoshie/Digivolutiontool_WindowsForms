using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
//using DigimonWorldTools_WindowsForms.EvolutionTool.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public interface IEvolutionCriteria
    {
        EvolutionStage EvolutionStage { get; }

        DigimonType DigimonType { get; }

        #region Main Criteria
        EvoCriteriaCombatStats CombatStats { get; }

        EvoCriteriaCareMistakes CareMistakes { get; }

        EvoCriteriaWeight Weight { get; }
        #endregion

        #region Bonus Criteria
        EvoCriteriaHappiness Happiness { get; }

        EvoCriteriaDiscipline Discipline { get; }

        EvoCriteriaBattles Battles { get; }

        EvoCriteriaTech Tech { get; }

        DigimonType? PrecursorDigimonType { get; }
        #endregion
    }
}
