using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionTech : IMinCriteria
    {
        public EvoCriterionTech(int amtTech)
        {
            Value = amtTech;
        }

        public int Value { get; }
    }
}
