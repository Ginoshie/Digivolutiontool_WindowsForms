using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriteriaWeight : IStatRangeCriteria
    {
        public EvoCriteriaWeight(int amtWeight, int amtMaxDeviation)
        {
            Value = amtWeight;

            amtMaxDeviation = MaxDeviationBoundsIncluded;
        }

        public int Value { get; }

        public int MaxDeviationBoundsIncluded { get; }
    }
}
