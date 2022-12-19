using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionHappiness : IMinCriteria
    {
        public EvoCriterionHappiness(int amtHappiness)
        {
            Value = amtHappiness;
        }

        public int Value { get; }
    }
}