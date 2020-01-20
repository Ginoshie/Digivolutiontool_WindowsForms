using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;

namespace DigimonWorldTools_WindowsForms.EvoTool
{
    public class EvoParametersChampionAndUltimate
    {
        public EvoParametersChampionAndUltimate()
        {
            HighestPrioEvo = DigimonType.Numemon;

            HighestEvoScore = 0;

            AmountCriteriaStats = 0;

            CriteriaStatCount = 0;

            CarriedOverAmountStats = 0;

            CarriedOverCriteriaStatCount = 0;
        }

        public DigimonType HighestPrioEvo { get; set; }

        public int HighestEvoScore { get; set; }

        public int EvoScore
        {
            get { return (AmountCriteriaStats + CarriedOverAmountStats) / (CriteriaStatCount + CarriedOverCriteriaStatCount); }
        }

        public int AmountCriteriaStats { get; set; }

        public int CriteriaStatCount { get; set; }

        public int CarriedOverAmountStats { get; set; }

        public int CarriedOverCriteriaStatCount { get; set; }
    }
}
