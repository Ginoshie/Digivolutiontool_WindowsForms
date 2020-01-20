using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriteriaBattles : IMinMaxCritieria
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
