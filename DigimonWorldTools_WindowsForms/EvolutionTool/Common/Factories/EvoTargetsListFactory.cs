using System.Collections.Generic;

namespace DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon
{
    public static class EvoTargetsListFactory
    {
        static EvoTargetsListFactory()
        {
            KoromonEvo = new List<DigimonType>() { DigimonType.Agumon, DigimonType.Gabumon };
            AgumonEvo = new List<DigimonType>() { DigimonType.Greymon, DigimonType.Centarumon, DigimonType.Monochromon, DigimonType.Tyrannomon };
        }

        public static List<DigimonType> KoromonEvo { get; }

        public static List<DigimonType> AgumonEvo { get; }
    }
}
