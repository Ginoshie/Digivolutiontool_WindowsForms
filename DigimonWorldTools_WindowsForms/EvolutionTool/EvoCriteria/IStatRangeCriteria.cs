namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria
{
    public interface IStatRangeCriteria
    {
        int Value { get; }

        int MaxDeviationBoundsIncluded { get; }
    }
}