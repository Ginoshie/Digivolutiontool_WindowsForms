using System;

namespace DigimonWorldTools_WindowsForms
{
    partial class EvoDeterminationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDigimonDigivolve = new System.Windows.Forms.Button();
            this.GbBonusCriteria = new System.Windows.Forms.GroupBox();
            this.numUpDownTechniques = new System.Windows.Forms.NumericUpDown();
            this.numUpDownBattles = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDiscipline = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHappiness = new System.Windows.Forms.NumericUpDown();
            this.LbTechniques = new System.Windows.Forms.Label();
            this.LbBattles = new System.Windows.Forms.Label();
            this.LbDiscipline = new System.Windows.Forms.Label();
            this.LbHappiness = new System.Windows.Forms.Label();
            this.PEvolutionCriteria = new System.Windows.Forms.Panel();
            this.GbMainCriteria = new System.Windows.Forms.GroupBox();
            this.numUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownCareMistakes = new System.Windows.Forms.NumericUpDown();
            this.numUpDownBrn = new System.Windows.Forms.NumericUpDown();
            this.numUpDownSpd = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDef = new System.Windows.Forms.NumericUpDown();
            this.numUpDownOff = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMP = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHP = new System.Windows.Forms.NumericUpDown();
            this.CbTargetDigimon = new System.Windows.Forms.ComboBox();
            this.LbTargetDigimon = new System.Windows.Forms.Label();
            this.CbCurrentDigimonType = new System.Windows.Forms.ComboBox();
            this.LbCurrentDigimon = new System.Windows.Forms.Label();
            this.LbWeight = new System.Windows.Forms.Label();
            this.LbCareMistakes = new System.Windows.Forms.Label();
            this.LbBrains = new System.Windows.Forms.Label();
            this.LbSpeed = new System.Windows.Forms.Label();
            this.LbDef = new System.Windows.Forms.Label();
            this.LbOff = new System.Windows.Forms.Label();
            this.LbMP = new System.Windows.Forms.Label();
            this.LbHP = new System.Windows.Forms.Label();
            this.TbEvolutionOutcome = new System.Windows.Forms.TextBox();
            this.lbEvolutionOutcome = new System.Windows.Forms.Label();
            this.GbBonusCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTechniques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBattles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHappiness)).BeginInit();
            this.PEvolutionCriteria.SuspendLayout();
            this.GbMainCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCareMistakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBrn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHP)).BeginInit();
            this.SuspendLayout();
            // 
            // btDigimonDigivolve
            // 
            this.btDigimonDigivolve.Location = new System.Drawing.Point(12, 543);
            this.btDigimonDigivolve.Name = "btDigimonDigivolve";
            this.btDigimonDigivolve.Size = new System.Drawing.Size(317, 37);
            this.btDigimonDigivolve.TabIndex = 0;
            this.btDigimonDigivolve.Text = "Digimon digivolve!";
            this.btDigimonDigivolve.UseVisualStyleBackColor = true;
            this.btDigimonDigivolve.Click += new System.EventHandler(this.BtDigimonDigivolve_Click);
            // 
            // GbBonusCriteria
            // 
            this.GbBonusCriteria.Controls.Add(this.numUpDownTechniques);
            this.GbBonusCriteria.Controls.Add(this.numUpDownBattles);
            this.GbBonusCriteria.Controls.Add(this.numUpDownDiscipline);
            this.GbBonusCriteria.Controls.Add(this.numUpDownHappiness);
            this.GbBonusCriteria.Controls.Add(this.LbTechniques);
            this.GbBonusCriteria.Controls.Add(this.LbBattles);
            this.GbBonusCriteria.Controls.Add(this.LbDiscipline);
            this.GbBonusCriteria.Controls.Add(this.LbHappiness);
            this.GbBonusCriteria.Location = new System.Drawing.Point(3, 362);
            this.GbBonusCriteria.Name = "GbBonusCriteria";
            this.GbBonusCriteria.Size = new System.Drawing.Size(305, 156);
            this.GbBonusCriteria.TabIndex = 2;
            this.GbBonusCriteria.TabStop = false;
            this.GbBonusCriteria.Text = "Bonus criteria";
            // 
            // numUpDownTechniques
            // 
            this.numUpDownTechniques.Location = new System.Drawing.Point(142, 121);
            this.numUpDownTechniques.Maximum = new decimal(new int[] {
            56,
            0,
            0,
            0});
            this.numUpDownTechniques.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownTechniques.Name = "numUpDownTechniques";
            this.numUpDownTechniques.Size = new System.Drawing.Size(157, 26);
            this.numUpDownTechniques.TabIndex = 31;
            this.numUpDownTechniques.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownBattles
            // 
            this.numUpDownBattles.Location = new System.Drawing.Point(142, 89);
            this.numUpDownBattles.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownBattles.Name = "numUpDownBattles";
            this.numUpDownBattles.Size = new System.Drawing.Size(157, 26);
            this.numUpDownBattles.TabIndex = 30;
            // 
            // numUpDownDiscipline
            // 
            this.numUpDownDiscipline.Location = new System.Drawing.Point(142, 57);
            this.numUpDownDiscipline.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUpDownDiscipline.Name = "numUpDownDiscipline";
            this.numUpDownDiscipline.Size = new System.Drawing.Size(157, 26);
            this.numUpDownDiscipline.TabIndex = 29;
            // 
            // numUpDownHappiness
            // 
            this.numUpDownHappiness.Location = new System.Drawing.Point(142, 25);
            this.numUpDownHappiness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUpDownHappiness.Name = "numUpDownHappiness";
            this.numUpDownHappiness.Size = new System.Drawing.Size(157, 26);
            this.numUpDownHappiness.TabIndex = 28;
            // 
            // LbTechniques
            // 
            this.LbTechniques.AutoSize = true;
            this.LbTechniques.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbTechniques.Location = new System.Drawing.Point(41, 123);
            this.LbTechniques.Name = "LbTechniques";
            this.LbTechniques.Size = new System.Drawing.Size(95, 20);
            this.LbTechniques.TabIndex = 8;
            this.LbTechniques.Text = "Techniques:";
            // 
            // LbBattles
            // 
            this.LbBattles.AutoSize = true;
            this.LbBattles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbBattles.Location = new System.Drawing.Point(73, 91);
            this.LbBattles.Name = "LbBattles";
            this.LbBattles.Size = new System.Drawing.Size(63, 20);
            this.LbBattles.TabIndex = 6;
            this.LbBattles.Text = "Battles:";
            // 
            // LbDiscipline
            // 
            this.LbDiscipline.AutoSize = true;
            this.LbDiscipline.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbDiscipline.Location = new System.Drawing.Point(56, 59);
            this.LbDiscipline.Name = "LbDiscipline";
            this.LbDiscipline.Size = new System.Drawing.Size(80, 20);
            this.LbDiscipline.TabIndex = 4;
            this.LbDiscipline.Text = "Discipline:";
            // 
            // LbHappiness
            // 
            this.LbHappiness.AutoSize = true;
            this.LbHappiness.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbHappiness.Location = new System.Drawing.Point(47, 27);
            this.LbHappiness.Name = "LbHappiness";
            this.LbHappiness.Size = new System.Drawing.Size(89, 20);
            this.LbHappiness.TabIndex = 1;
            this.LbHappiness.Text = "Happiness:";
            // 
            // PEvolutionCriteria
            // 
            this.PEvolutionCriteria.Controls.Add(this.GbMainCriteria);
            this.PEvolutionCriteria.Controls.Add(this.GbBonusCriteria);
            this.PEvolutionCriteria.Location = new System.Drawing.Point(12, 12);
            this.PEvolutionCriteria.Name = "PEvolutionCriteria";
            this.PEvolutionCriteria.Size = new System.Drawing.Size(317, 525);
            this.PEvolutionCriteria.TabIndex = 3;
            // 
            // GbMainCriteria
            // 
            this.GbMainCriteria.Controls.Add(this.numUpDownWeight);
            this.GbMainCriteria.Controls.Add(this.numUpDownCareMistakes);
            this.GbMainCriteria.Controls.Add(this.numUpDownBrn);
            this.GbMainCriteria.Controls.Add(this.numUpDownSpd);
            this.GbMainCriteria.Controls.Add(this.numUpDownDef);
            this.GbMainCriteria.Controls.Add(this.numUpDownOff);
            this.GbMainCriteria.Controls.Add(this.numUpDownMP);
            this.GbMainCriteria.Controls.Add(this.numUpDownHP);
            this.GbMainCriteria.Controls.Add(this.CbTargetDigimon);
            this.GbMainCriteria.Controls.Add(this.LbTargetDigimon);
            this.GbMainCriteria.Controls.Add(this.CbCurrentDigimonType);
            this.GbMainCriteria.Controls.Add(this.LbCurrentDigimon);
            this.GbMainCriteria.Controls.Add(this.LbWeight);
            this.GbMainCriteria.Controls.Add(this.LbCareMistakes);
            this.GbMainCriteria.Controls.Add(this.LbBrains);
            this.GbMainCriteria.Controls.Add(this.LbSpeed);
            this.GbMainCriteria.Controls.Add(this.LbDef);
            this.GbMainCriteria.Controls.Add(this.LbOff);
            this.GbMainCriteria.Controls.Add(this.LbMP);
            this.GbMainCriteria.Controls.Add(this.LbHP);
            this.GbMainCriteria.Location = new System.Drawing.Point(3, 5);
            this.GbMainCriteria.Name = "GbMainCriteria";
            this.GbMainCriteria.Size = new System.Drawing.Size(305, 351);
            this.GbMainCriteria.TabIndex = 3;
            this.GbMainCriteria.TabStop = false;
            this.GbMainCriteria.Text = "Main criteria";
            // 
            // numUpDownWeight
            // 
            this.numUpDownWeight.Location = new System.Drawing.Point(142, 317);
            this.numUpDownWeight.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUpDownWeight.Name = "numUpDownWeight";
            this.numUpDownWeight.Size = new System.Drawing.Size(157, 26);
            this.numUpDownWeight.TabIndex = 27;
            // 
            // numUpDownCareMistakes
            // 
            this.numUpDownCareMistakes.Location = new System.Drawing.Point(142, 285);
            this.numUpDownCareMistakes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownCareMistakes.Name = "numUpDownCareMistakes";
            this.numUpDownCareMistakes.Size = new System.Drawing.Size(157, 26);
            this.numUpDownCareMistakes.TabIndex = 26;
            // 
            // numUpDownBrn
            // 
            this.numUpDownBrn.Location = new System.Drawing.Point(142, 253);
            this.numUpDownBrn.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownBrn.Name = "numUpDownBrn";
            this.numUpDownBrn.Size = new System.Drawing.Size(157, 26);
            this.numUpDownBrn.TabIndex = 25;
            // 
            // numUpDownSpd
            // 
            this.numUpDownSpd.Location = new System.Drawing.Point(142, 221);
            this.numUpDownSpd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownSpd.Name = "numUpDownSpd";
            this.numUpDownSpd.Size = new System.Drawing.Size(157, 26);
            this.numUpDownSpd.TabIndex = 24;
            // 
            // numUpDownDef
            // 
            this.numUpDownDef.Location = new System.Drawing.Point(142, 189);
            this.numUpDownDef.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownDef.Name = "numUpDownDef";
            this.numUpDownDef.Size = new System.Drawing.Size(157, 26);
            this.numUpDownDef.TabIndex = 23;
            // 
            // numUpDownOff
            // 
            this.numUpDownOff.Location = new System.Drawing.Point(142, 157);
            this.numUpDownOff.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownOff.Name = "numUpDownOff";
            this.numUpDownOff.Size = new System.Drawing.Size(157, 26);
            this.numUpDownOff.TabIndex = 22;
            // 
            // numUpDownMP
            // 
            this.numUpDownMP.Location = new System.Drawing.Point(142, 125);
            this.numUpDownMP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownMP.Name = "numUpDownMP";
            this.numUpDownMP.Size = new System.Drawing.Size(157, 26);
            this.numUpDownMP.TabIndex = 21;
            // 
            // numUpDownHP
            // 
            this.numUpDownHP.Location = new System.Drawing.Point(142, 93);
            this.numUpDownHP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownHP.Name = "numUpDownHP";
            this.numUpDownHP.Size = new System.Drawing.Size(157, 26);
            this.numUpDownHP.TabIndex = 6;
            // 
            // CbTargetDigimon
            // 
            this.CbTargetDigimon.Location = new System.Drawing.Point(142, 59);
            this.CbTargetDigimon.Name = "CbTargetDigimon";
            this.CbTargetDigimon.Size = new System.Drawing.Size(157, 28);
            this.CbTargetDigimon.TabIndex = 19;
            // 
            // LbTargetDigimon
            // 
            this.LbTargetDigimon.AutoSize = true;
            this.LbTargetDigimon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbTargetDigimon.Location = new System.Drawing.Point(18, 62);
            this.LbTargetDigimon.Name = "LbTargetDigimon";
            this.LbTargetDigimon.Size = new System.Drawing.Size(118, 20);
            this.LbTargetDigimon.TabIndex = 20;
            this.LbTargetDigimon.Text = "Target digimon:";
            // 
            // CbCurrentDigimonType
            // 
            this.CbCurrentDigimonType.Location = new System.Drawing.Point(142, 25);
            this.CbCurrentDigimonType.Name = "CbCurrentDigimonType";
            this.CbCurrentDigimonType.Size = new System.Drawing.Size(157, 28);
            this.CbCurrentDigimonType.Sorted = true;
            this.CbCurrentDigimonType.TabIndex = 0;
            // 
            // LbCurrentDigimon
            // 
            this.LbCurrentDigimon.AutoSize = true;
            this.LbCurrentDigimon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbCurrentDigimon.Location = new System.Drawing.Point(8, 28);
            this.LbCurrentDigimon.Name = "LbCurrentDigimon";
            this.LbCurrentDigimon.Size = new System.Drawing.Size(128, 20);
            this.LbCurrentDigimon.TabIndex = 18;
            this.LbCurrentDigimon.Text = "Current Digimon:";
            // 
            // LbWeight
            // 
            this.LbWeight.AutoSize = true;
            this.LbWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbWeight.Location = new System.Drawing.Point(73, 319);
            this.LbWeight.Name = "LbWeight";
            this.LbWeight.Size = new System.Drawing.Size(63, 20);
            this.LbWeight.TabIndex = 16;
            this.LbWeight.Text = "Weight:";
            // 
            // LbCareMistakes
            // 
            this.LbCareMistakes.AutoSize = true;
            this.LbCareMistakes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbCareMistakes.Location = new System.Drawing.Point(22, 287);
            this.LbCareMistakes.Name = "LbCareMistakes";
            this.LbCareMistakes.Size = new System.Drawing.Size(114, 20);
            this.LbCareMistakes.TabIndex = 14;
            this.LbCareMistakes.Text = "Care mistakes:";
            // 
            // LbBrains
            // 
            this.LbBrains.AutoSize = true;
            this.LbBrains.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbBrains.Location = new System.Drawing.Point(98, 255);
            this.LbBrains.Name = "LbBrains";
            this.LbBrains.Size = new System.Drawing.Size(38, 20);
            this.LbBrains.TabIndex = 12;
            this.LbBrains.Text = "Brn:";
            // 
            // LbSpeed
            // 
            this.LbSpeed.AutoSize = true;
            this.LbSpeed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbSpeed.Location = new System.Drawing.Point(94, 223);
            this.LbSpeed.Name = "LbSpeed";
            this.LbSpeed.Size = new System.Drawing.Size(42, 20);
            this.LbSpeed.TabIndex = 10;
            this.LbSpeed.Text = "Spd:";
            // 
            // LbDef
            // 
            this.LbDef.AutoSize = true;
            this.LbDef.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbDef.Location = new System.Drawing.Point(97, 191);
            this.LbDef.Name = "LbDef";
            this.LbDef.Size = new System.Drawing.Size(39, 20);
            this.LbDef.TabIndex = 8;
            this.LbDef.Text = "Def:";
            // 
            // LbOff
            // 
            this.LbOff.AutoSize = true;
            this.LbOff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbOff.Location = new System.Drawing.Point(102, 159);
            this.LbOff.Name = "LbOff";
            this.LbOff.Size = new System.Drawing.Size(35, 20);
            this.LbOff.TabIndex = 6;
            this.LbOff.Text = "Off:";
            // 
            // LbMP
            // 
            this.LbMP.AutoSize = true;
            this.LbMP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbMP.Location = new System.Drawing.Point(101, 127);
            this.LbMP.Name = "LbMP";
            this.LbMP.Size = new System.Drawing.Size(36, 20);
            this.LbMP.TabIndex = 4;
            this.LbMP.Text = "MP:";
            // 
            // LbHP
            // 
            this.LbHP.AutoSize = true;
            this.LbHP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbHP.Location = new System.Drawing.Point(101, 95);
            this.LbHP.Name = "LbHP";
            this.LbHP.Size = new System.Drawing.Size(35, 20);
            this.LbHP.TabIndex = 1;
            this.LbHP.Text = "HP:";
            // 
            // TbEvolutionOutcome
            // 
            this.TbEvolutionOutcome.Location = new System.Drawing.Point(519, 98);
            this.TbEvolutionOutcome.Name = "TbEvolutionOutcome";
            this.TbEvolutionOutcome.Size = new System.Drawing.Size(157, 26);
            this.TbEvolutionOutcome.TabIndex = 5;
            // 
            // lbEvolutionOutcome
            // 
            this.lbEvolutionOutcome.AutoSize = true;
            this.lbEvolutionOutcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbEvolutionOutcome.Location = new System.Drawing.Point(370, 101);
            this.lbEvolutionOutcome.Name = "lbEvolutionOutcome";
            this.lbEvolutionOutcome.Size = new System.Drawing.Size(143, 20);
            this.lbEvolutionOutcome.TabIndex = 4;
            this.lbEvolutionOutcome.Text = "EvolutionOutcome:";
            // 
            // EvolutionDeterminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 586);
            this.Controls.Add(this.TbEvolutionOutcome);
            this.Controls.Add(this.lbEvolutionOutcome);
            this.Controls.Add(this.PEvolutionCriteria);
            this.Controls.Add(this.btDigimonDigivolve);
            this.Name = "EvolutionDeterminationForm";
            this.Text = "Form1";
            this.GbBonusCriteria.ResumeLayout(false);
            this.GbBonusCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTechniques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBattles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHappiness)).EndInit();
            this.PEvolutionCriteria.ResumeLayout(false);
            this.GbMainCriteria.ResumeLayout(false);
            this.GbMainCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCareMistakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBrn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDigimonDigivolve;
        private System.Windows.Forms.GroupBox GbBonusCriteria;
        private System.Windows.Forms.Label LbHappiness;
        private System.Windows.Forms.Panel PEvolutionCriteria;
        private System.Windows.Forms.GroupBox GbMainCriteria;
        private System.Windows.Forms.Label LbWeight;
        private System.Windows.Forms.Label LbCareMistakes;
        private System.Windows.Forms.Label LbBrains;
        private System.Windows.Forms.Label LbSpeed;
        private System.Windows.Forms.Label LbDef;
        private System.Windows.Forms.Label LbOff;
        private System.Windows.Forms.Label LbMP;
        private System.Windows.Forms.Label LbHP;
        private System.Windows.Forms.Label LbDiscipline;
        private System.Windows.Forms.Label LbTechniques;
        private System.Windows.Forms.Label LbBattles;
        private System.Windows.Forms.Label LbCurrentDigimon;
        private System.Windows.Forms.ComboBox CbCurrentDigimonType;
        private System.Windows.Forms.TextBox TbEvolutionOutcome;
        private System.Windows.Forms.Label lbEvolutionOutcome;
        private System.Windows.Forms.ComboBox CbTargetDigimon;
        private System.Windows.Forms.Label LbTargetDigimon;
        private System.Windows.Forms.NumericUpDown numUpDownHP;
        private System.Windows.Forms.NumericUpDown numUpDownTechniques;
        private System.Windows.Forms.NumericUpDown numUpDownBattles;
        private System.Windows.Forms.NumericUpDown numUpDownDiscipline;
        private System.Windows.Forms.NumericUpDown numUpDownHappiness;
        private System.Windows.Forms.NumericUpDown numUpDownWeight;
        private System.Windows.Forms.NumericUpDown numUpDownCareMistakes;
        private System.Windows.Forms.NumericUpDown numUpDownBrn;
        private System.Windows.Forms.NumericUpDown numUpDownSpd;
        private System.Windows.Forms.NumericUpDown numUpDownDef;
        private System.Windows.Forms.NumericUpDown numUpDownOff;
        private System.Windows.Forms.NumericUpDown numUpDownMP;
    }
}

