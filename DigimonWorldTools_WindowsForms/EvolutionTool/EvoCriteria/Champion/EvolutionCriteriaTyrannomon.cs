using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Champion
{
    public class EvolutionCriteriaTyrannomon: IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Tyrannomon;

        public EvoCriteriaCombatStats CombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 1000
            , mp: 0
            , off: 0
            , def: 100
            , speed: 0
            , brains: 0
        );

        public EvoCriteriaCareMistakes CareMistakes { get; } = new EvoCriteriaCareMistakes(
            amtCareMistakes: 5
            , isMax: true
        );

        public EvoCriteriaWeight Weight { get; } = new EvoCriteriaWeight(
            amtWeight: 30
            , amtMaxDeviation: 5
        );

        public EvoCriteriaHappiness Happiness { get; } = new EvoCriteriaHappiness(
            amtHappiness:0
        );

        public EvoCriteriaDiscipline Discipline { get; } = new EvoCriteriaDiscipline(
            amtDiscipline: 0
        );

        public EvoCriteriaBattles Battles { get; } = new EvoCriteriaBattles(
            amtBattles: 5
            , isMax: true
        );

        public EvoCriteriaTech Tech { get; } = new EvoCriteriaTech(
            amtTech: 28
        );

        public DigimonType? PrecursorDigimonType => DigimonType.Biyomon;
    }
}
