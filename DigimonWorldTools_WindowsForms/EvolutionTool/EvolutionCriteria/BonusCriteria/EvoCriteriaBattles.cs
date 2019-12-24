namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.BonusCriteria
{
    public class EvoCriteriaBattles
    {
        public EvoCriteriaBattles(
            bool isBattlesCriteriaAMaximum
            , int battles
        )
        {
            IsBattlesCriteriaAMaximum = isBattlesCriteriaAMaximum;
            Battles = battles;
        }

        public bool IsBattlesCriteriaAMaximum;

        public int Battles;
    }
}
