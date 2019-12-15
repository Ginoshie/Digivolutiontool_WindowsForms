using DigimonWorldTools_WindowsForms.EvolutionTool;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.MessageboxTextMessages;
using System;
using System.Windows.Forms;

namespace DigimonWorldTools_WindowsForms
{
    public partial class EvolutionDeterminationForm : Form
    {
        public EvolutionDeterminationForm()
        {
            InitializeComponent();

            CbCurrentDigimonType.DataSource = Enum.GetValues(typeof(DigimonType));
            CbTargetDigimon.DataSource = Enum.GetValues(typeof(DigimonType));

            TestSetUserDigimonStats();
        }
        #region Form properties
        public DigimonType CurrentDigimonType
        {
            get { return (DigimonType)CbCurrentDigimonType.SelectedItem; }
            set { CbCurrentDigimonType.SelectedItem = value; }
        }

        public int HP
        {
            get { return int.Parse(numUpDownHP.Text); }
            set { numUpDownHP.Text = value.ToString(); }
        }

        public int HPDevidedByTen
        {
            get { return (int.Parse(numUpDownHP.Text) / 10); }
        }

        public int MP
        {
            get { return int.Parse(numUpDownMP.Text); }
            set { numUpDownMP.Text = value.ToString(); }
        }

        public int MPDevidedByTen
        {
            get { return (int.Parse(numUpDownMP.Text) / 10); }
        }

        public int Off
        {
            get { return int.Parse(numUpDownOff.Text); }
            set { numUpDownOff.Text = value.ToString(); }
        }

        public int Def
        {
            get { return int.Parse(numUpDownDef.Text); }
            set { numUpDownDef.Text = value.ToString(); }
        }

        public int Speed
        {
            get { return int.Parse(numUpDownSpd.Text); }
            set { numUpDownSpd.Text = value.ToString(); }
        }

        public int Brains
        {
            get { return int.Parse(numUpDownBrn.Text); }
            set { numUpDownBrn.Text = value.ToString(); }
        }

        public int Caremistakes
        {
            get { return int.Parse(numUpDownCareMistakes.Text); }
            set { numUpDownCareMistakes.Text = value.ToString(); }
        }

        public int Weight
        {
            get { return int.Parse(numUpDownWeight.Text); }
            set { numUpDownWeight.Text = value.ToString(); }
        }

        public int Happiness
        {
            get { return int.Parse(numUpDownHappiness.Text); }
            set { numUpDownHappiness.Text = value.ToString(); }
        }

        public int Discipline
        {
            get { return int.Parse(numUpDownDiscipline.Text); }
            set { numUpDownDiscipline.Text = value.ToString(); }
        }

        public int Battles
        {
            get { return int.Parse(numUpDownBattles.Text); }
            set { numUpDownBattles.Text = value.ToString(); }
        }

        public int Techniques
        {
            get { return int.Parse(numUpDownTechniques.Text); }
            set { numUpDownTechniques.Text = value.ToString(); }
        }

        public DigimonType EvolutionOutcome
        {
            get { return (DigimonType)Enum.Parse(typeof(DigimonType), TbEvolutionOutcome.Text); }
            set { TbEvolutionOutcome.Text = value.ToString(); }
        }
        #endregion

        #region Events
        private void BtDigimonDigivolve_Click(object sender, EventArgs e)
        {
            EvolutionDeterminationFlow.StartEvolutionDeterminiationFlow(this);
        }
        #endregion

        #region Test functions/methods
        private void TestSetUserDigimonStats()
        {
            CbCurrentDigimonType.SelectedItem = null;

            numUpDownHP.Text = "1600";

            numUpDownMP.Text = "900";

            numUpDownOff.Text = "160";

            numUpDownDef.Text = "100";

            numUpDownSpd.Text = "100";

            numUpDownBrn.Text = "100";

            numUpDownCareMistakes.Text = "3";

            numUpDownWeight.Text = "30";

            numUpDownHappiness.Text = "100";

            numUpDownDiscipline.Text = "100";

            numUpDownBattles.Text = "0";

            numUpDownTechniques.Text = "49";
        }
        #endregion
    }
}
