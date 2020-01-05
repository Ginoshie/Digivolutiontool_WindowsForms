using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Champion
{
    public class EvolutionCriteriaGreymon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Greymon;

        public EvoCriteriaCombatStats CombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 0
            , mp: 0
            , off: 100
            , def: 100
            , speed: 100
            , brains: 100
        );

        public EvoCriteriaCareMistakes CareMistakes { get; } = new EvoCriteriaCareMistakes(
            amtCareMistakes: 1
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
            amtDiscipline: 90
        );

        public EvoCriteriaBattles Battles { get; } = new EvoCriteriaBattles(
            amtBattles: 0
            , isMax: false
        );

        public EvoCriteriaTech Tech { get; } = new EvoCriteriaTech(
            amtTech: 35
        );

        public DigimonType? PrecursorDigimonType => null;
    }
}
