using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionBattles : IMinMaxCritieria
    {
        public EvoCriterionBattles(int amtBattles, bool isMax)
        {
            Value = amtBattles;

            IsMax = isMax;
        }

        public int Value { get; }

        public bool IsMax { get; }
    }
}