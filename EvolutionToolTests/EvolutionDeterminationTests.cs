using DigimonWorldTools_WindowsForms;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvoDetermination;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using NUnit.Framework;

namespace EvoToolTests
{
    [TestFixture]
    public class EvoDeterminationTests
    {
        private EvoDeterminationForm evoDeterminationForm;

        [SetUp]
        public void Setup()
        {
            evoDeterminationForm = new EvoDeterminationForm();
        }

        [TearDown]
        public void TearDown()
        {
            evoDeterminationForm = null;
        }

        private void FillFormForGreymonEvo()
        {
            evoDeterminationForm = new EvoDeterminationForm
            {
                CurrentDigimonType = DigimonType.Agumon,

                HP = 1600,

                MP = 900,

                Off = 160,

                Def = 100,

                Speed = 100,

                Brains = 100,

                Caremistakes = 3,

                Weight = 30,

                Happiness = 100,

                Discipline = 100,

                Battles = 0,

                Techniques = 49
            };
        }

        [TestCase(DigimonType.Greymon)]
        public void AgumonIntoGreymonEvoFlow(DigimonType expectedEvoResult)
        {
            // Given
            FillFormForGreymonEvo();

            // When
            DeterminationFlow.StartEvoDeterminiationFlow(evoDeterminationForm);

            // Then
            Assert.That(evoDeterminationForm.EvoOutcome, Is.EqualTo(expectedEvoResult));
        }
    }
}
