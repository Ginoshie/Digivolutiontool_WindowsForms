using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool
{
    public class UserDigimonDataObject : DigimonStats
    {
        public DigimonType DigimonType { get; set; }

        public int HPDividedByTen { get; set; }

        public int MPDividedByTen { get; set; }
    }
}
