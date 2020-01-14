using DigimonWorldTools_WindowsForms;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using NUnit.Framework;
using DigimonWorldTools_WindowsForms.EvolutionTool;

namespace EvolutionToolTests
{
    [TestFixture]
    public class EvolutionDeterminationTests
    {
        private EvolutionDeterminationForm evolutionDeterminationForm;

        [SetUp]
        public void Setup()
        {
            evolutionDeterminationForm = new EvolutionDeterminationForm();
        }

        [TearDown]
        public void TearDown()
        {
            evolutionDeterminationForm = null;
        }

        private void FillFormForGreymonEvolution()
        {
            evolutionDeterminationForm = new EvolutionDeterminationForm
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
        public void AgumonIntoGreymonEvolutionFlow(DigimonType expectedEvolutionResult)
        {
            // Given
            FillFormForGreymonEvolution();

            // When
            EvolutionDeterminationFlow.StartEvolutionDeterminiationFlow(evolutionDeterminationForm);

            // Then
            Assert.That(evolutionDeterminationForm.EvolutionOutcome, Is.EqualTo(expectedEvolutionResult));
        }
    }
}
