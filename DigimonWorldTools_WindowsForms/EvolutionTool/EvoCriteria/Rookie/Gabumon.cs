using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Rookie;

internal class Gabumon : IEvoCriteria
{
    public EvoStage EvoStage => EvoStage.Rookie;

    public DigimonType DigimonType => DigimonType.Gabumon;

    public EvoCriterionCombatStats CombatStats { get; } = new(
        0
        , 0
        , 0
        , 1
        , 0
        , 0
    );

    public EvoCriterionCareMistakes CareMistakes { get; } = new(
        0
        , false
    );

    public EvoCriterionWeight Weight { get; } = new(
        15
        , 5
    );

    public EvoCriterionHappiness Happiness { get; } = new(
        0
    );

    public EvoCriterionDiscipline Discipline { get; } = new(
        0
    );

    public EvoCriterionBattles Battles { get; } = new(
        -2
        , false
    );

    public EvoCriterionTech Tech { get; } = new(
        0
    );

    public DigimonType? PrecursorDigimonType => DigimonType.Koromon;

    public EvoCriteriaMain EvoCriteriaMain =>
        new()
        {
            CombatStats = CombatStats,
            CareMistakes = CareMistakes,
            Weight = Weight
        };

    public EvoCriteriaBonus EvoCriteriaBonus =>
        new()
        {
            Happiness = Happiness,
            Discipline = Discipline,
            Battles = Battles,
            Tech = Tech,
            PrecursorDigimonType = DigimonType
        };
}