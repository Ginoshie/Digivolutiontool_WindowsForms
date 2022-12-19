using DigimonWorldTools_WindowsForms;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvoDetermination;
using NUnit.Framework;

namespace EvoToolTests;

[TestFixture]
public class EvoDeterminationTests
{
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

    private EvoDeterminationForm evoDeterminationForm;

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

            CareMistakes = 3,

            Weight = 30,

            Happiness = 100,

            Discipline = 100,

            Battles = 0,

            Techniques = 49
        };
    }

    private void FillFormForAgumonEvo()
    {
        evoDeterminationForm = new EvoDeterminationForm
        {
            CurrentDigimonType = DigimonType.Koromon,

            HP = 1300,

            MP = 30,

            Off = 60,

            Def = 129,

            Speed = 129,

            Brains = 129,

            CareMistakes = 0,

            Weight = 1,

            Happiness = -100,

            Discipline = -30,

            Battles = 10,

            Techniques = 49
        };
    }

    [TestCase(DigimonType.Greymon)]
    public void AgumonIntoGreymonEvoFlow(DigimonType expectedEvoResult)
    {
        // Given
        FillFormForGreymonEvo();

        // When
        DeterminationFlow.StartEvoDeterminationFlow(evoDeterminationForm);

        // Then
        Assert.That(evoDeterminationForm.EvoOutcome, Is.EqualTo(expectedEvoResult));
    }

    [TestCase(DigimonType.Agumon)]
    public void KoromonIntoAgumonEvoFlow(DigimonType expectedEvoResult)
    {
        // Given
        FillFormForAgumonEvo();

        // When
        DeterminationFlow.StartEvoDeterminationFlow(evoDeterminationForm);

        // Then
        Assert.That(evoDeterminationForm.EvoOutcome, Is.EqualTo(expectedEvoResult));
    }
}