namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria
{
    public class EvoCriteriaCareMistakes
    {
        public EvoCriteriaCareMistakes(
            bool isCareMistakesCriteriaMaximum
            , int careMistakes
        )
        {
            isCareMistakesCriteriaMaximum = IsCareMistakesCriteriaAMaximum;
            careMistakes = CareMistakes;
        }

        public bool IsCareMistakesCriteriaAMaximum;

        public int CareMistakes;
    }
}
