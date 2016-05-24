using System;
using System.Windows.Forms;

namespace Team_5214_Scouting_App___Stronghold
{
    public partial class Robot_Information_Input : Form
    {
        public Robot_Information_Input()
        {
            InitializeComponent();
        }

        void clearAll() //Clears all text boxes and check boxes and sets the cursor back to the first text box.
        {
            teamNumberTextBox.Text = "";
            teamNameTextBox.Text = "";
            lowBarCheckBox.Checked = false;
            portcullisCheckBox.Checked = false;
            roughTerrainCheckBox.Checked = false;
            moatCheckBox.Checked = false;
            chevalDeFriseCheckBox.Checked = false;
            rampartsCheckBox.Checked = false;
            drawbridgeCheckBox.Checked = false;
            sallyPortCheckBox.Checked = false;
            rockWallCheckBox.Checked = false;
            humanPlayerStationCheckBox.Checked = false;
            spyCheckBox.Checked = false;
            scaleTowerCheckBox.Checked = false;
            highGoalCheckBox.Checked = false;
            lowGoalCheckBox.Checked = false;
            reachCheckBox.Checked = false;
            crossDefenseCheckBox.Checked = false;
            shootHighCheckBox.Checked = false;
            shootLowCheckBox.Checked = false;
            crossDefenseSpecificationTextBox.Text = "";
            notes.Text = "";
            teamNumberTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(teamNumberTextBox.Text)) //Check to see if they have unsubmitted data
            {
                var doubleCheck = MessageBox.Show("Closing without submitting data will reult in the loss of all unsumbitted data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //Ask before closing.
                if (doubleCheck == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Robot_Info_Storage.index == 200) //Check to see if the filled the array.
            {
                MessageBox.Show("You have have no storage left, export the data then clear all.", "No Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool error = false;
                int i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    if (Robot_Info_Storage.teamNumber[i] == Convert.ToInt16(teamNumberTextBox.Text)) //Check to see if they have already entered that team.
                    {
                        MessageBox.Show("This team has already been interviewed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                        break;
                    }
                    i++;
                }
                if (error == false)
                {
                    if (crossDefenseCheckBox.Checked == true && string.IsNullOrWhiteSpace(crossDefenseSpecificationTextBox.Text))
                    {
                        MessageBox.Show("Please specify what defenses can be crossed while in autonomous.", "Error, Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrWhiteSpace(teamNumberTextBox.Text) | string.IsNullOrWhiteSpace(teamNameTextBox.Text))
                    {
                        MessageBox.Show("You are mssing required information.", "Error, Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int index = Robot_Info_Storage.index;
                        Robot_Info_Storage.teamNumber[index] = Convert.ToInt16(teamNumberTextBox.Text);
                        Robot_Info_Storage.teamName[index] = teamNameTextBox.Text;
                        if (lowBarCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.lowBar[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.lowBar[index] = 0;
                        }
                        if (portcullisCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.portcullis[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.portcullis[index] = 0;
                        }
                        if (roughTerrainCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.roughTerrain[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.roughTerrain[index] = 0;
                        }
                        if (moatCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.moat[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.moat[index] = 0;
                        }
                        if (rampartsCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.ramparts[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.ramparts[index] = 0;
                        }
                        if (drawbridgeCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.drawbridge[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.drawbridge[index] = 0;
                        }
                        if (sallyPortCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.sallyPort[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.sallyPort[index] = 0;
                        }
                        if (rockWallCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.rockWall[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.rockWall[index] = 0;
                        }
                        if (chevalDeFriseCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.chevalDeFrise[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.chevalDeFrise[index] = 0;
                        }
                        if (humanPlayerStationCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.humanPlayerStation[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.humanPlayerStation[index] = 0;
                        }
                        if (spyCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.spy[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.spy[index] = 0;
                        }
                        if (scaleTowerCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.scaleTower[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.scaleTower[index] = 0;
                        }
                        if (highGoalCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.highGoal[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.highGoal[index] = 0;
                        }
                        if (lowGoalCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.lowGoal[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.lowGoal[index] = 0;
                        }
                        if (reachCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.reach[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.reach[index] = 0;
                        }
                        if (crossDefenseCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.crossDefense[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.crossDefense[index] = 0;
                        }
                        if (shootHighCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.shootHigh[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.shootHigh[index] = 0;
                        }
                        if (shootLowCheckBox.Checked == true)
                        {
                            Robot_Info_Storage.shootLow[index] = 1;
                        }
                        else
                        {
                            Robot_Info_Storage.shootLow[index] = 0;
                        }
                        if (string.IsNullOrWhiteSpace(crossDefenseSpecificationTextBox.Text))
                        {
                            Robot_Info_Storage.crossDefenseSpecification[index] = " ";
                        }
                        else
                        {
                            Robot_Info_Storage.crossDefenseSpecification[index] = crossDefenseSpecificationTextBox.Text;
                        }
                        if (string.IsNullOrWhiteSpace(notes.Text))
                        {
                            Robot_Info_Storage.notes[index] = " ";
                        }
                        else
                        {
                            Robot_Info_Storage.notes[index] = notes.Text;
                        }
                        Robot_Info_Storage.index++;
                        Robot_Info_Storage.changes = true;
                        clearAll();
                    }
                }
                else
                {
                    clearAll();
                }
            }
        }
    }
}
