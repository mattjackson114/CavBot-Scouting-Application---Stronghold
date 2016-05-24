using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_5214_Scouting_App___Stronghold
{
    public partial class Team_Results : Form
    {
        public Team_Results()
        {
            InitializeComponent();
        }

        private void Team_Results_Load(object sender, EventArgs e)
        {
            int index = Robot_Info_Storage.infoIndex;
            teamNumberTextBox.Text = Convert.ToString(Robot_Info_Storage.teamNumber[index]);
            teamNameTextBox.Text = Robot_Info_Storage.teamName[index];
            if(Robot_Info_Storage.lowBar[index] == 1)
            {
                lowBarCheckBox.Checked = true;
            }
            else
            {
                lowBarCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.portcullis[index] == 1)
            {
                portcullisCheckBox.Checked = true;
            }
            else
            {
                portcullisCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.roughTerrain[index] == 1)
            {
                roughTerrainCheckBox.Checked = true;
            }
            else
            {
                roughTerrainCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.moat[index] == 1)
            {
                moatCheckBox.Checked = true;
            }
            else
            {
                moatCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.ramparts[index] == 1)
            {
                rampartsCheckBox.Checked = true;
            }
            else
            {
                rampartsCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.drawbridge[index] == 1)
            {
                drawbridgeCheckBox.Checked = true;
            }
            else
            {
                drawbridgeCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.sallyPort[index] == 1)
            {
                sallyPortCheckBox.Checked = true;
            }
            else
            {
                sallyPortCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.rockWall[index] == 1)
            {
                rockWallCheckBox.Checked = true;
            }
            else
            {
                rockWallCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.chevalDeFrise[index] == 1)
            {
                chevalDeFriseCheckBox.Checked = true;
            }
            else
            {
                chevalDeFriseCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.humanPlayerStation[index] ==1)
            {
                humanPlayerStationCheckBox.Checked = true;
            }
            else
            {
                humanPlayerStationCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.spy[index] == 1)
            {
                spyCheckBox.Checked = true;
            }
            else
            {
                spyCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.scaleTower[index] == 1)
            {
                scaleTowerCheckBox.Checked = true;
            }
            else
            {
                scaleTowerCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.highGoal[index] == 1)
            {
                highGoalCheckBox.Checked = true;
            }
            else
            {
                highGoalCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.lowGoal[index] == 1)
            {
                lowGoalCheckBox.Checked = true;
            }
            else
            {
                lowGoalCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.reach[index] == 1)
            {
                reachCheckBox.Checked = true;
            }
            else
            {
                reachCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.crossDefense[index] == 1)
            {
                crossDefenseCheckBox.Checked = true;
            }
            else
            {
                crossDefenseCheckBox.Checked = false;
            }
            if (Robot_Info_Storage.shootHigh[index] == 1)
            {
                shootHighCheckBox.Checked = true;
            }
            else
            {
                shootHighCheckBox.Checked = false;
            }
            if(Robot_Info_Storage.shootLow[index] == 1)
            {
                shootLowCheckBox.Checked = true;
            }
            else
            {
                shootLowCheckBox.Checked = false;
            }
            crossDefenseSpecificationTextBox.Text = Robot_Info_Storage.crossDefenseSpecification[index];
            notes.Text = Robot_Info_Storage.notes[index];
            if(Match_Info_Storage.index > 0)
            {
                int i = 0;
                while(i < Match_Info_Storage.index)
                {
                    if(Match_Info_Storage.rT1Number[i] == Convert.ToInt16(teamNumberTextBox.Text))
                    {
                        Robot_Info_Storage.scores[Robot_Info_Storage.scoreIndex] = Match_Info_Storage.rT1Score[i];
                        Robot_Info_Storage.scoreIndex++;
                    }
                    else if(Match_Info_Storage.rT2Number[i] == Convert.ToInt16(teamNumberTextBox.Text))
                    {
                        Robot_Info_Storage.scores[Robot_Info_Storage.scoreIndex] = Match_Info_Storage.rT2Score[i];
                        Robot_Info_Storage.scoreIndex++;
                    }
                    else if (Match_Info_Storage.rT3Number[i] == Convert.ToInt16(teamNumberTextBox.Text))
                    {
                        Robot_Info_Storage.scores[Robot_Info_Storage.scoreIndex] = Match_Info_Storage.rT3Score[i];
                        Robot_Info_Storage.scoreIndex++;
                    }
                    else if (Match_Info_Storage.bT1Number[i] == Convert.ToInt16(teamNumberTextBox.Text))
                    {
                        Robot_Info_Storage.scores[Robot_Info_Storage.scoreIndex] = Match_Info_Storage.bT1Score[i];
                        Robot_Info_Storage.scoreIndex++;
                    }
                    else if (Match_Info_Storage.bT2Number[i] == Convert.ToInt16(teamNumberTextBox.Text))
                    {
                        Robot_Info_Storage.scores[Robot_Info_Storage.scoreIndex] = Match_Info_Storage.bT2Score[i];
                        Robot_Info_Storage.scoreIndex++;
                    }
                    else if (Match_Info_Storage.bT3Number[i] == Convert.ToInt16(teamNumberTextBox.Text))
                    {
                        Robot_Info_Storage.scores[Robot_Info_Storage.scoreIndex] = Match_Info_Storage.bT3Score[i];
                        Robot_Info_Storage.scoreIndex++;
                    }
                    i++;
                }
                int meanBuffer = 0;
                int temp = 0;
                int h = 0;
                while (h < Robot_Info_Storage.scoreIndex)
                {
                    temp = meanBuffer + Robot_Info_Storage.scores[h];
                    meanBuffer = 0;
                    meanBuffer += temp;
                    h++;
                }
                int actualMean = meanBuffer / Robot_Info_Storage.scoreIndex;
                averageScoreTextBox.Text = Convert.ToString(actualMean);
                int standardDev = 0;
                temp += 0;
                h = 0;
                while(h < Robot_Info_Storage.scoreIndex)
                {
                    temp = (Robot_Info_Storage.scores[h] - actualMean)*(Robot_Info_Storage.scores[h] - actualMean) + standardDev;
                    standardDev = 0;
                    standardDev += temp;
                    h++;
                }
                double actualStandardDev = Math.Sqrt(Convert.ToDouble(standardDev / Robot_Info_Storage.scoreIndex));
                standardDevTextBox.Text = Convert.ToString(actualStandardDev);
            }
            string current = notes.Text;
            string[] competitionNotes = new string[200];
            int[] matchNumber = new int[200];
            int matchNumberIndex = 0;
            int j = 0;
            int notesIndex = 0;
            while(j < Match_Info_Storage.index)
            {
                if(teamNumberTextBox.Text == Convert.ToString(Match_Info_Storage.rT1Number[j]))
                {
                    competitionNotes[notesIndex] = Match_Info_Storage.rT1Notes[j];
                    matchNumber[matchNumberIndex] = Match_Info_Storage.matchNumber[j];
                    matchNumberIndex++;
                    notesIndex++;
                }
                else if (teamNumberTextBox.Text == Convert.ToString(Match_Info_Storage.rT2Number[j]))
                {
                    competitionNotes[notesIndex] = Match_Info_Storage.rT2Notes[j];
                    matchNumber[matchNumberIndex] = Match_Info_Storage.matchNumber[j];
                    matchNumberIndex++;
                    notesIndex++;
                }
                else if (teamNumberTextBox.Text == Convert.ToString(Match_Info_Storage.rT3Number[j]))
                {
                    competitionNotes[notesIndex] = Match_Info_Storage.rT3Notes[j];
                    matchNumber[matchNumberIndex] = Match_Info_Storage.matchNumber[j];
                    matchNumberIndex++;
                    notesIndex++;
                }
                else if (teamNumberTextBox.Text == Convert.ToString(Match_Info_Storage.bT1Number[j]))
                {
                    competitionNotes[notesIndex] = Match_Info_Storage.bT1Notes[j];
                    matchNumber[matchNumberIndex] = Match_Info_Storage.matchNumber[j];
                    matchNumberIndex++;
                    notesIndex++;
                }
                else if (teamNumberTextBox.Text == Convert.ToString(Match_Info_Storage.bT2Number[j]))
                {
                    competitionNotes[notesIndex] = Match_Info_Storage.bT2Notes[j];
                    matchNumber[matchNumberIndex] = Match_Info_Storage.matchNumber[j];
                    matchNumberIndex++;
                    notesIndex++;
                }
                else if (teamNumberTextBox.Text == Convert.ToString(Match_Info_Storage.bT3Number[j]))
                {
                    competitionNotes[notesIndex] = Match_Info_Storage.bT3Notes[j];
                    matchNumber[matchNumberIndex] = Match_Info_Storage.matchNumber[j];
                    matchNumberIndex++;
                    notesIndex++;
                }
                j++;
            }
            notes.AppendText("\r\n");
            notes.AppendText("------------------------");
            notes.AppendText("\r\n");
            j = 0;
            while(j < notesIndex)
            {
                notes.AppendText(competitionNotes[j]);
                notes.AppendText("\r\n");
                notes.AppendText("-----Match Number " + matchNumber[j] + "-----");
                notes.AppendText("\r\n");
                j++;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            Graph newForm = new Graph();
            newForm.Show();
        }
    }
}
