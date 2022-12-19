using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion;

public class Birdramon : IEvoCriteria
{
    public EvoStage EvoStage => EvoStage.Champion;

    public DigimonType DigimonType => DigimonType.Birdramon;

    public EvoCriterionCombatStats CombatStats { get; } = new(
        0
        , 0
        , 0
        , 0
        , 100
        , 0
    );

    public EvoCriterionCareMistakes CareMistakes { get; } = new(
        3
        , false
    );

    public EvoCriterionWeight Weight { get; } = new(
        20
        , 5
    );

    public EvoCriterionHappiness Happiness { get; } = new(
        0
    );

    public EvoCriterionDiscipline Discipline { get; } = new(
        0
    );

    public EvoCriterionBattles Battles { get; } = new(
        0
        , false
    );

    public EvoCriterionTech Tech { get; } = new(
        35
    );

    public DigimonType? PrecursorDigimonType => DigimonType.Biyomon;

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