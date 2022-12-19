using System;
using System.Windows.Forms;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvoDetermination;

namespace DigimonWorldTools_WindowsForms;

public partial class EvoDeterminationForm : Form
{
    public EvoDeterminationForm()
    {
        InitializeComponent();

        CbCurrentDigimonType.DataSource = Enum.GetValues(typeof(DigimonType));
        CbTargetDigimon.DataSource = Enum.GetValues(typeof(DigimonType));
    }

    #region Events

    private void BtDigimonDigivolve_Click(object sender, EventArgs e)
    {
        DeterminationFlow.StartEvoDeterminationFlow(this);
    }

    #endregion

    #region Form properties

    public DigimonType CurrentDigimonType
    {
        get => (DigimonType)CbCurrentDigimonType.SelectedItem;
        set => CbCurrentDigimonType.SelectedItem = value;
    }

    public int HP
    {
        get => int.Parse(numUpDownHP.Text);
        set => numUpDownHP.Text = value.ToString();
    }

    public int HPDividedByTen => int.Parse(numUpDownHP.Text) / 10;

    public int MP
    {
        get => int.Parse(numUpDownMP.Text);
        set => numUpDownMP.Text = value.ToString();
    }

    public int MPDividedByTen => int.Parse(numUpDownMP.Text) / 10;

    public int Off
    {
        get => int.Parse(numUpDownOff.Text);
        set => numUpDownOff.Text = value.ToString();
    }

    public int Def
    {
        get => int.Parse(numUpDownDef.Text);
        set => numUpDownDef.Text = value.ToString();
    }

    public int Speed
    {
        get => int.Parse(numUpDownSpd.Text);
        set => numUpDownSpd.Text = value.ToString();
    }

    public int Brains
    {
        get => int.Parse(numUpDownBrn.Text);
        set => numUpDownBrn.Text = value.ToString();
    }

    public int CareMistakes
    {
        get => int.Parse(numUpDownCareMistakes.Text);
        set => numUpDownCareMistakes.Text = value.ToString();
    }

    public int Weight
    {
        get => int.Parse(numUpDownWeight.Text);
        set => numUpDownWeight.Text = value.ToString();
    }

    public int Happiness
    {
        get => int.Parse(numUpDownHappiness.Text);
        set => numUpDownHappiness.Text = value.ToString();
    }

    public int Discipline
    {
        get => int.Parse(numUpDownDiscipline.Text);
        set => numUpDownDiscipline.Text = value.ToString();
    }

    public int Battles
    {
        get => int.Parse(numUpDownBattles.Text);
        set => numUpDownBattles.Text = value.ToString();
    }

    public int Techniques
    {
        get => int.Parse(numUpDownTechniques.Text);
        set => numUpDownTechniques.Text = value.ToString();
    }

    public DigimonType EvoOutcome
    {
        get => (DigimonType)Enum.Parse(typeof(DigimonType), TbEvolutionOutcome.Text);
        set => TbEvolutionOutcome.Text = value.ToString();
    }

    #endregion
}