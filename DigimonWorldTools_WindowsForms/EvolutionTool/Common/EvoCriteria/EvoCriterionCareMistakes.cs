using DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionCareMistakes : IMinMaxCritieria
    {
        public EvoCriterionCareMistakes(int amtCareMistakes, bool isMax)
        {
            Value = amtCareMistakes;

            IsMax = isMax;
        }

        public int Value { get; }

        public bool IsMax { get; }
    }
}