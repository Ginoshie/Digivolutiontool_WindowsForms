using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Stats;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public static class EvolutionDeterminationFlow
    {
        public static void StartEvolutionDeterminiationFlow(EvolutionDeterminationForm evolutionDeterminatorForm)
        {
            EvolutionDeterminator evolutionDeterminator = new EvolutionDeterminator(CreateFilledUserDigimonDataObject(evolutionDeterminatorForm));

            evolutionDeterminatorForm.EvolutionOutcome = evolutionDeterminator.DetermineEvolutionResult();
        }

        private static UserDigimonDataObject CreateFilledUserDigimonDataObject(EvolutionDeterminationForm form1)
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
                , DigimonCombatStats = digimonCombatStats
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
