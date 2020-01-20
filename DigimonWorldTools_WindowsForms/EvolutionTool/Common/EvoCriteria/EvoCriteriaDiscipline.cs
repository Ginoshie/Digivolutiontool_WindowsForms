using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriteriaDiscipline : IMinCriteria
    {
        public EvoCriteriaDiscipline(int amtDiscipline)
        {
            Value = amtDiscipline;
        }

        public int Value { get; }
    }
}
