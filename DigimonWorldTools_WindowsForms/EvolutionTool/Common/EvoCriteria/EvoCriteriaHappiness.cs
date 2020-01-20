using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriteriaHappiness : IMinCriteria
    {
        public EvoCriteriaHappiness(int amtHappiness)
        {
            Value = amtHappiness;
        }

        public int Value { get; }
    }
}
