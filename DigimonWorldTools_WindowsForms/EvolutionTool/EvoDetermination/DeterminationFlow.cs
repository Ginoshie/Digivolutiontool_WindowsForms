using DigimonWorldTools_WindowsForms.EvoTool;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvoDetermination
{
    public static class DeterminationFlow
    {
        public static void StartEvoDeterminiationFlow(EvoDeterminationForm evoDeterminatorForm)
        {
            Determinator evoDeterminator = new Determinator(CreateFilledUserDigimonDataObject(evoDeterminatorForm));

            evoDeterminatorForm.EvoOutcome = evoDeterminator.DetermineEvoResult();
        }

        private static UserDigimonDataObject CreateFilledUserDigimonDataObject(EvoDeterminationForm form1)
        {
            CombatStats digimonCombatStats = new CombatStats()
            {
                HP = form1.HP
                , MP = form1.MP
                , Off = form1.Off
                , Def = form1.Def
                , Speed = form1.Speed
                , Brains = form1.Brains
            };

            return new UserDigimonDataObject()
            {
                DigimonType = form1.CurrentDigimonType
                , CombatStats = digimonCombatStats
                , CareMistakes = form1.Caremistakes
                , Weight = form1.Weight
                , Happiness = form1.Happiness
                , Discipline = form1.Discipline
                , Battles = form1.Battles
                , Tech = form1.Techniques
            };
        }
    }
}
