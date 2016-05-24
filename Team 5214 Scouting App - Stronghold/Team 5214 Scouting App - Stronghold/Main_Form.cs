using System;
using System.Windows.Forms;
using System.IO;

namespace Team_5214_Scouting_App___Stronghold
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        string robotInfoPath = @"\Team 5214 Scouting Application Stronghold\Robot Info.txt";
        string matchInfoPath = @"\Team 5214 Scouting Application Stronghold\Match Info.txt";

        string pathCalc(string path)
        {
            return programDataPath + path;
        }

        private void combine(string fileLocation, string textFileName)
        {
            
        }

        void load(bool temp)
        {
            if (temp == false)
            {
                using (StreamReader robotReader = new StreamReader(pathCalc(robotInfoPath)))
                {
                    string rawData = robotReader.ReadToEnd();
                    if (rawData.Length > 1)
                    {
                        string[] info = rawData.Split('|');
                        int index = Convert.ToInt16(info[0]);
                        Robot_Info_Storage.index = index;
                        int i = 0;
                        int adjuster = 1;
                        while (i < index)
                        {
                            Robot_Info_Storage.teamNumber[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        adjuster = adjuster + index;
                        i = 0;
                        while (i < index)
                        {
                            Robot_Info_Storage.teamName[i] = info[i + adjuster];
                            i++;
                        }
                        adjuster = adjuster + index;
                        i = 0;
                        while (i < index)
                        {
                            Robot_Info_Storage.lowBar[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.portcullis[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.roughTerrain[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.moat[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.ramparts[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.drawbridge[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.sallyPort[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.rockWall[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.chevalDeFrise[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.humanPlayerStation[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.spy[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.scaleTower[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.highGoal[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.lowGoal[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.reach[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.crossDefense[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.shootHigh[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.shootLow[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.crossDefenseSpecification[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Robot_Info_Storage.notes[i] = info[i + adjuster];
                            i++;
                        }
                    }
                }
                using (StreamReader matchReader = new StreamReader(pathCalc(matchInfoPath)))
                {
                    string rawData = matchReader.ReadToEnd();
                    if (rawData.Length > 1)
                    {
                        string[] info = rawData.Split('|');
                        int index = Convert.ToInt16(info[0]);
                        int i = 0;
                        int adjuster = 1;
                        Match_Info_Storage.index = index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT1Number[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT1Score[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT1Notes[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT2Number[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT2Score[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT2Notes[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT3Number[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT3Score[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.rT3Notes[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT1Score[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT1Notes[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT2Number[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT2Score[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT2Notes[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT3Number[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT3Score[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.bT3Notes[i] = info[i + adjuster];
                            i++;
                        }
                        i = 0;
                        adjuster = adjuster + index;
                        while (i < index)
                        {
                            Match_Info_Storage.matchNumber[i] = Convert.ToInt16(info[i + adjuster]);
                            i++;
                        }
                    }
                }
            }
            else
            {

            }
        }

        void save()
        {
            using (StreamWriter robotWriter = new StreamWriter(pathCalc(robotInfoPath)))
            {
                robotWriter.Write(Robot_Info_Storage.index + "|");
                int i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.teamNumber[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.teamName[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.lowBar[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.portcullis[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.roughTerrain[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.moat[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.ramparts[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.drawbridge[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.sallyPort[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.rockWall[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.chevalDeFrise[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.humanPlayerStation[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.spy[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.scaleTower[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.highGoal[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.lowGoal[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.reach[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.crossDefense[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.shootHigh[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.shootLow[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.crossDefenseSpecification[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Robot_Info_Storage.index)
                {
                    robotWriter.Write(Robot_Info_Storage.notes[i] + "|");
                    i++;
                }
                robotWriter.Close();
            }
            using (StreamWriter matchWriter = new StreamWriter(pathCalc(matchInfoPath)))
            {
                matchWriter.Write(Match_Info_Storage.index + "|");
                int i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT1Number[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT1Score[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT1Notes[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT2Number[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT2Score[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT2Notes[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT3Number[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT3Score[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.rT3Notes[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT1Number[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT1Score[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT1Notes[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT2Number[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT2Score[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT2Notes[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT3Number[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT3Score[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.bT3Notes[i] + "|");
                    i++;
                }
                i = 0;
                while (i < Match_Info_Storage.index)
                {
                    matchWriter.Write(Match_Info_Storage.matchNumber[i] + "|");
                    i++;
                }
                matchWriter.Close();
            }
            Robot_Info_Storage.changes = false;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            int width = Convert.ToInt16(screenWidth);
            int height = Convert.ToInt16(screenHeight);
            groupBox1.Location = new System.Drawing.Point((width - 637) / 2, (height - 379) / 2); //Add main menu to the center of the screen
            closeButton.Location = new System.Drawing.Point(width - 145, 0); //Add the close button to the top right hand corner
            load(false);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Robot_Info_Storage.changes = false;
        }

        private void robotInfoInButton_Click(object sender, EventArgs e)
        {
            Robot_Information_Input newForm = new Robot_Information_Input();
            newForm.Show();
            groupBox1.Visible = false;
        }

        private void matchInfoInButton_Click(object sender, EventArgs e)
        {
            Match_Information_Input newForm = new Match_Information_Input();
            newForm.Show();
            groupBox1.Visible = false;
        }

        private void matchInfoRetrievalButton_Click(object sender, EventArgs e)
        {
            Match_Numbers newForm = new Match_Numbers();
            newForm.Show();
            groupBox1.Visible = false;
        }

        private void robotInfoRetrievalButton_Click(object sender, EventArgs e)
        {
            Team_Number newForm = new Team_Number();
            newForm.Show();
            groupBox1.Visible = false;
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (Robot_Info_Storage.changes == true)
            {
                var result = MessageBox.Show("Woud you like to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    save();
                }
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("All information will be deleted, there is no getting it back. Are you sure you want to clear all data?", "Clear All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Array.Clear(Robot_Info_Storage.teamNumber, 0, Robot_Info_Storage.teamNumber.Length);
                Array.Clear(Robot_Info_Storage.teamName, 0, Robot_Info_Storage.teamName.Length);
                Array.Clear(Robot_Info_Storage.lowBar, 0, Robot_Info_Storage.lowBar.Length);
                Array.Clear(Robot_Info_Storage.portcullis, 0, Robot_Info_Storage.portcullis.Length);
                Array.Clear(Robot_Info_Storage.roughTerrain, 0, Robot_Info_Storage.roughTerrain.Length);
                Array.Clear(Robot_Info_Storage.moat, 0, Robot_Info_Storage.moat.Length);
                Array.Clear(Robot_Info_Storage.ramparts, 0, Robot_Info_Storage.ramparts.Length);
                Array.Clear(Robot_Info_Storage.drawbridge, 0, Robot_Info_Storage.drawbridge.Length);
                Array.Clear(Robot_Info_Storage.sallyPort, 0, Robot_Info_Storage.sallyPort.Length);
                Array.Clear(Robot_Info_Storage.rockWall, 0, Robot_Info_Storage.rockWall.Length);
                Array.Clear(Robot_Info_Storage.chevalDeFrise, 0, Robot_Info_Storage.chevalDeFrise.Length);
                Array.Clear(Robot_Info_Storage.humanPlayerStation, 0, Robot_Info_Storage.humanPlayerStation.Length);
                Array.Clear(Robot_Info_Storage.spy, 0, Robot_Info_Storage.spy.Length);
                Array.Clear(Robot_Info_Storage.scaleTower, 0, Robot_Info_Storage.scaleTower.Length);
                Array.Clear(Robot_Info_Storage.highGoal, 0, Robot_Info_Storage.highGoal.Length);
                Array.Clear(Robot_Info_Storage.lowGoal, 0, Robot_Info_Storage.lowGoal.Length);
                Array.Clear(Robot_Info_Storage.reach, 0, Robot_Info_Storage.reach.Length);
                Array.Clear(Robot_Info_Storage.crossDefense, 0, Robot_Info_Storage.crossDefense.Length);
                Array.Clear(Robot_Info_Storage.shootHigh, 0, Robot_Info_Storage.shootHigh.Length);
                Array.Clear(Robot_Info_Storage.shootLow, 0, Robot_Info_Storage.shootLow.Length);
                Array.Clear(Robot_Info_Storage.crossDefenseSpecification, 0, Robot_Info_Storage.crossDefenseSpecification.Length);
                Array.Clear(Robot_Info_Storage.notes, 0, Robot_Info_Storage.notes.Length);
                Robot_Info_Storage.index = 0;
                Array.Clear(Match_Info_Storage.rT1Number, 0, Match_Info_Storage.rT1Number.Length);
                Array.Clear(Match_Info_Storage.rT1Score, 0, Match_Info_Storage.rT1Score.Length);
                Array.Clear(Match_Info_Storage.rT1Notes, 0, Match_Info_Storage.rT1Notes.Length);
                Array.Clear(Match_Info_Storage.rT2Number, 0, Match_Info_Storage.rT2Number.Length);
                Array.Clear(Match_Info_Storage.rT2Score, 0, Match_Info_Storage.rT2Score.Length);
                Array.Clear(Match_Info_Storage.rT2Notes, 0, Match_Info_Storage.rT2Notes.Length);
                Array.Clear(Match_Info_Storage.rT3Number, 0, Match_Info_Storage.rT3Number.Length);
                Array.Clear(Match_Info_Storage.rT3Score, 0, Match_Info_Storage.rT3Score.Length);
                Array.Clear(Match_Info_Storage.rT3Notes, 0, Match_Info_Storage.rT3Notes.Length);
                Array.Clear(Match_Info_Storage.bT1Number, 0, Match_Info_Storage.bT1Number.Length);
                Array.Clear(Match_Info_Storage.bT1Score, 0, Match_Info_Storage.bT1Score.Length);
                Array.Clear(Match_Info_Storage.bT1Notes, 0, Match_Info_Storage.bT1Notes.Length);
                Array.Clear(Match_Info_Storage.bT2Number, 0, Match_Info_Storage.bT2Number.Length);
                Array.Clear(Match_Info_Storage.bT2Score, 0, Match_Info_Storage.bT2Score.Length);
                Array.Clear(Match_Info_Storage.bT2Notes, 0, Match_Info_Storage.bT2Notes.Length);
                Array.Clear(Match_Info_Storage.bT3Number, 0, Match_Info_Storage.bT3Number.Length);
                Array.Clear(Match_Info_Storage.bT3Score, 0, Match_Info_Storage.bT3Score.Length);
                Array.Clear(Match_Info_Storage.bT3Notes, 0, Match_Info_Storage.bT3Notes.Length);
                Array.Clear(Match_Info_Storage.matchNumber, 0, Match_Info_Storage.matchNumber.Length);
                Match_Info_Storage.index = 0;
                File.Delete(pathCalc(robotInfoPath));
                File.Delete(pathCalc(matchInfoPath));
                File.Create(pathCalc(robotInfoPath));
                File.Create(pathCalc(matchInfoPath));
            }
        }

        private void exportButtton_Click(object sender, EventArgs e)
        {
            save();
            if (exportBrowser.ShowDialog() == DialogResult.OK)
            {
                string exportLocation = exportBrowser.SelectedPath;
                if (!Directory.Exists(exportLocation + @"\Team 5214 Scouting Application Stronghold"))
                {
                    Directory.CreateDirectory(exportLocation + @"\Team 5214 Scouting Application Stronghold");
                }
                File.Copy(pathCalc(robotInfoPath), exportLocation + robotInfoPath);
                File.Copy(pathCalc(matchInfoPath), exportLocation + matchInfoPath);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search newForm = new search();
            newForm.Show();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            save();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;

            }
        }
    }
}