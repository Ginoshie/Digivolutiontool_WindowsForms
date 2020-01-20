using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria
{
    public interface IEvoCriteria
    {
        EvoStage EvoStage { get; }

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
