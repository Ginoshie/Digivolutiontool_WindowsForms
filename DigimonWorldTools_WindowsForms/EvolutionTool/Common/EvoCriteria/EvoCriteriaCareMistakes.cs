namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria
{
    public class EvoCriteriaCareMistakes
    {
        public EvoCriteriaCareMistakes(int amtCareMistakes, bool isMax)
        {
            Value = amtCareMistakes;

            IsMax = isMax;
        }

        public int Value { get; }

        public bool IsMax { get;  }
    }
}
