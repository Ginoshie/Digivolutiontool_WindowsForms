using DigimonWorldTools_WindowsForms.EvolutionTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria
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
