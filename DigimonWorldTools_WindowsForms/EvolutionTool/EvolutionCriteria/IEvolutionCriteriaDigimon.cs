using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public interface IEvolutionCriteria
    {
        EvolutionStage EvolutionStage { get; }

        DigimonType DigimonType { get; }

        #region Main Criteria
        #region Stats
        int HP { get; }

        int MP { get; }

        int Off { get; }

        int Def { get; }

        int Speed { get; }

        int Brains { get; }
        #endregion

        bool IsCaremistakesCriteriaAMaximum { get; }

        int CareMistakes { get; }

        int Weight { get; }
        #endregion

        #region Bonus Criteria
        int MaxDeviationFromWeightBoundsIncluded { get; }

        int Happiness { get; }

        int Discipline { get; }

        bool IsBattlesCriteriaAMaximum { get; }

        int Battles { get; }

        int Tech { get; }

        DigimonType? PrecursorDigimonType { get; }
        #endregion
    }
}
