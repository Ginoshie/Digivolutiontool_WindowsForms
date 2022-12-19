using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion;

public class Monochromon : IEvoCriteria
{
    public EvoStage EvoStage => EvoStage.Champion;

    public DigimonType DigimonType => DigimonType.Monochromon;

    public EvoCriterionCombatStats CombatStats { get; } = new(
        1000
        , 0
        , 0
        , 100
        , 0
        , 100
    );

    public EvoCriterionCareMistakes CareMistakes { get; } = new(
        3
        , true
    );

    public EvoCriterionWeight Weight { get; } = new(
        40
        , 5
    );

    public EvoCriterionHappiness Happiness { get; } = new(
        0
    );

    public EvoCriterionDiscipline Discipline { get; } = new(
        0
    );

    public EvoCriterionBattles Battles { get; } = new(
        5
        , true
    );

    public EvoCriterionTech Tech { get; } = new(
        35
    );

    public DigimonType? PrecursorDigimonType => null;

    public EvoCriteriaMain EvoCriteriaMain =>
        new()
        {
            CombatStats = CombatStats, CareMistakes = CareMistakes, Weight = Weight
        };

    public EvoCriteriaBonus EvoCriteriaBonus =>
        new()
        {
            Happiness = Happiness, Discipline = Discipline, Battles = Battles, Tech = Tech,
            PrecursorDigimonType = DigimonType
        };
}