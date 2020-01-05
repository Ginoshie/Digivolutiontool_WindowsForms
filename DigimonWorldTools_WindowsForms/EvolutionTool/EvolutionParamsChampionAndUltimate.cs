using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public class EvolutionParamsChampionAndUltimate
    {
        public EvolutionParamsChampionAndUltimate()
        {
            HighestPrioEvolution = DigimonType.Numemon;

            HighestEvolutionScore = 0;

            AmountCriteriaStats = 0;

            CriteriaStatCount = 0;

            CarriedOverAmountStats = 0;

            CarriedOverCriteriaStatCount = 0;
        }

        public DigimonType HighestPrioEvolution { get; set; }

        public int HighestEvolutionScore { get; set; }

        public int EvolutionScore
        {
            get { return (AmountCriteriaStats + CarriedOverAmountStats) / (CriteriaStatCount + CarriedOverCriteriaStatCount); }
        }

        public int AmountCriteriaStats { get; set; }

        public int CriteriaStatCount { get; set; }

        public int CarriedOverAmountStats { get; set; }

        public int CarriedOverCriteriaStatCount { get; set; }
    }
}
