namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria
{
    public class EvoCriteriaWeight
    {
        public EvoCriteriaWeight(
            int maxDeviationFromWeightBoundsIncluded
            , int weight
        )
        {
            MaxDeviationFromWeightBoundsIncluded = maxDeviationFromWeightBoundsIncluded;
            Weight = weight;
        }

        public int MaxDeviationFromWeightBoundsIncluded;

        public int Weight;
    }
}
