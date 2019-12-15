using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaBase : IEvolutionCriteria
    {
        protected EvolutionCriteriaBase(
            EvolutionStage evolutionStage
            , DigimonType digimonType
            , int hp
            , int mp
            , int off
            , int def
            , int speed
            , int brains
            , bool isCaremistakesCriteriaAMaximum
            , int careMistakes
            , int weight
            , int maxDeviationFromWeightBoundsIncluded
            , int happiness
            , int discipline
            , bool isBattlesCriteriaAMaximum
            , int battles
            , int tech
            , DigimonType? precursorDigimonType
        )
        {
            EvolutionStage = evolutionStage;

            DigimonType = digimonType;

            HP = hp;

            MP = mp;

            Off = off;

            Def = def;

            Speed = speed;

            Brains = brains;

            IsCaremistakesCriteriaAMaximum = isCaremistakesCriteriaAMaximum;

            CareMistakes = careMistakes;

            Weight = weight;

            MaxDeviationFromWeightBoundsIncluded = maxDeviationFromWeightBoundsIncluded;

            Happiness = happiness;

            Discipline = discipline;

            IsBattlesCriteriaAMaximum = isBattlesCriteriaAMaximum;

            Battles = battles;

            Tech = tech;

            PrecursorDigimonType = precursorDigimonType;
        }

        public EvolutionStage EvolutionStage { get; }
        
        public DigimonType DigimonType { get; }

        #region Main Criteria
        #region Stats
        public int HP { get; }

        public int MP { get; }

        public int Off { get; }

        public int Def { get; }

        public int Speed { get; }

        public int Brains { get; }
        #endregion

        public bool IsCaremistakesCriteriaAMaximum { get; }

        public int CareMistakes { get; }

        public int Weight { get; }

        public int MaxDeviationFromWeightBoundsIncluded { get; }
        #endregion

        #region Bonus Criteria
        public int Happiness { get; }

        public int Discipline { get; }

        public bool IsBattlesCriteriaAMaximum { get; }

        public int Battles { get; }

        public int Tech { get; }

        public DigimonType? PrecursorDigimonType { get; }
        #endregion
    }
}
