using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriteriaTech : IMinCriteria
    {
        public EvoCriteriaTech(int amtTech)
        {
            Value = amtTech;
        }

        public int Value { get; }
    }
}
