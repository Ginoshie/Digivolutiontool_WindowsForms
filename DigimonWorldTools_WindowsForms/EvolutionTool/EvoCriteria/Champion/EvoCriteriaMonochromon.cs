using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion
{
    public class EvoMonochromon : IEvoCriteria
    {
        public EvoStage EvoStage => EvoStage.Champion;

        public DigimonType DigimonType => DigimonType.Monochromon;

        public EvoCriteriaCombatStats CombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 1000
            , mp: 0
            , off: 0
            , def: 100
            , speed: 0
            , brains: 100
        );

        public EvoCriteriaCareMistakes CareMistakes { get; } = new EvoCriteriaCareMistakes(
            amtCareMistakes: 3
            , isMax: true
        );

        public EvoCriteriaWeight Weight { get; } = new EvoCriteriaWeight(
            amtWeight: 40
            , amtMaxDeviation: 5
        );

        public EvoCriteriaHappiness Happiness { get; } = new EvoCriteriaHappiness(
            amtHappiness: 0
        );

        public EvoCriteriaDiscipline Discipline { get; } = new EvoCriteriaDiscipline(
            amtDiscipline: 0
        );

        public EvoCriteriaBattles Battles { get; } = new EvoCriteriaBattles(
            amtBattles: 5
            , isMax: true
        );

        public EvoCriteriaTech Tech { get; } = new EvoCriteriaTech(
            amtTech: 35
        );

        public DigimonType? PrecursorDigimonType => null;
    }
}
