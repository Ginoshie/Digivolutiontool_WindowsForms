using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion;

public class Centarumon : IEvoCriteria
{
    public EvoStage EvoStage => EvoStage.Champion;

    public DigimonType DigimonType => DigimonType.Centarumon;

    public EvoCriterionCombatStats CombatStats { get; } = new(
        0
        , 0
        , 0
        , 0
        , 0
        , 100
    );

    public EvoCriterionCareMistakes CareMistakes { get; } = new(
        3
        , true
    );

    public EvoCriterionWeight Weight { get; } = new(
        30
        , 5
    );

    public EvoCriterionHappiness Happiness { get; } = new(
        0
    );

    public EvoCriterionDiscipline Discipline { get; } = new(
        60
    );

    public EvoCriterionBattles Battles { get; } = new(
        0
        , false
    );

    public EvoCriterionTech Tech { get; } = new(
        28
    );

    public DigimonType? PrecursorDigimonType => null;

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