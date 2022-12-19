using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionDiscipline : IMinCriteria
    {
        public EvoCriterionDiscipline(int amtDiscipline)
        {
            Value = amtDiscipline;
        }

        public int Value { get; }
    }
}