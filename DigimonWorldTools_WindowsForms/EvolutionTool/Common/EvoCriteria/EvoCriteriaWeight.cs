namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria
{
    public class EvoCriteriaWeight
    {
        public EvoCriteriaWeight(int amtWeight, int amtMaxDeviation)
        {
            Value = amtWeight;

            amtMaxDeviation = MaxDeviationBoundsIncluded;
        }

        public int Value { get; }

        public int MaxDeviationBoundsIncluded;
    }
}
