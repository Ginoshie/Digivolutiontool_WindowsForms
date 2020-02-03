using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionWeight : IStatRangeCriteria
    {
        public EvoCriterionWeight(int amtWeight, int amtMaxDeviation)
        {
            Value = amtWeight;

            MaxDeviationBoundsIncluded = amtMaxDeviation;
        }

        public int Value { get; }

        public int MaxDeviationBoundsIncluded { get; }
    }
}
