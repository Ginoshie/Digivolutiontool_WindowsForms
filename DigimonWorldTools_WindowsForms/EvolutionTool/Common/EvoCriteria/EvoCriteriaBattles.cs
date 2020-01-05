namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria
{
    public class EvoCriteriaBattles
    {
        public EvoCriteriaBattles(int amtBattles, bool isMax)
        {
            Value = amtBattles;

            IsMax = isMax;
        }

        public int Value { get; }

        public bool IsMax { get; }
    }
}
