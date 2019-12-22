using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.BonusCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public interface IEvolutionCriteria
    {
        EvolutionStage EvolutionStage { get; }

        DigimonType DigimonType { get; }

        #region Main Criteria
        EvoCriteriaCombatStats EvoCriteriaCombatStats { get; }

        EvoCriteriaCareMistakes EvoCriteriaCareMistakes { get; }

        EvoCriteriaWeight EvoCriteriaWeight { get; }
        #endregion

        #region Bonus Criteria

        int Happiness { get; }

        int Discipline { get; }

        EvoCriteriaBattles EvoCriteriaBattles { get; }

        int Tech { get; }

        DigimonType? PrecursorDigimonType { get; }
        #endregion
    }
}
