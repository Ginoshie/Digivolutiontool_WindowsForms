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
            return new UserDigimonDataObject
            {
                DigimonType = form1.CurrentDigimonType
                , HP = form1.HP
                , HPDividedByTen = form1.HPDevidedByTen
                , MP = form1.MP
                , MPDividedByTen = form1.MPDevidedByTen
                , Off = form1.Off
                , Def = form1.Def
                , Speed = form1.Speed
                , Brains = form1.Brains
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
