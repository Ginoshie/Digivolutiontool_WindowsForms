using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

public interface IEvoCriteria
{
    EvoStage EvoStage { get; }

    DigimonType DigimonType { get; }

    #region Main Criteria

    EvoCriterionCombatStats CombatStats { get; }

    EvoCriterionCareMistakes CareMistakes { get; }

    EvoCriterionWeight Weight { get; }

    EvoCriteriaMain EvoCriteriaMain { get; }

    #endregion

    #region Bonus Criteria

    EvoCriterionHappiness Happiness { get; }

    EvoCriterionDiscipline Discipline { get; }

    EvoCriterionBattles Battles { get; }

    EvoCriterionTech Tech { get; }

    DigimonType? PrecursorDigimonType { get; }

    EvoCriteriaBonus EvoCriteriaBonus { get; }

    #endregion
}