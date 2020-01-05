using System.Collections.Generic;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon
{
    public static class EvolutionTargetsListFactory
    {
        static EvolutionTargetsListFactory()
        {
            KoromonEvolutions = new List<DigimonType>() { DigimonType.Agumon, DigimonType.Gabumon };
            AgumonEvolutions = new List<DigimonType>() { DigimonType.Greymon, DigimonType.Centarumon, DigimonType.Monochromon, DigimonType.Tyrannomon };
        }

        public static List<DigimonType> KoromonEvolutions { get; }

        public static List<DigimonType> AgumonEvolutions { get; }
    }
}
