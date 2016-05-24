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
    public partial class Match_Results : Form
    {
        public Match_Results()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Match_Results_Load(object sender, EventArgs e)
        {
            int index = Match_Info_Storage.infoIndex;
            rT1NumberTextBox.Text = Convert.ToString(Match_Info_Storage.rT1Number[index]);
            rT2NumberTextBox.Text = Convert.ToString(Match_Info_Storage.rT2Number[index]);
            rT3NumberTextBox.Text = Convert.ToString(Match_Info_Storage.rT3Number[index]);
            bT1NumberTextBox.Text = Convert.ToString(Match_Info_Storage.bT1Number[index]);
            bT2NumberTextBox.Text = Convert.ToString(Match_Info_Storage.bT2Number[index]);
            bT3NumberTextBox.Text = Convert.ToString(Match_Info_Storage.bT3Number[index]);
            rT1ScoreTextBox.Text = Convert.ToString(Match_Info_Storage.rT1Score[index]);
            rT2ScoreTextBox.Text = Convert.ToString(Match_Info_Storage.rT2Score[index]);
            rT3ScoreTextBox.Text = Convert.ToString(Match_Info_Storage.rT3Score[index]);
            bT1ScoreTextBox.Text = Convert.ToString(Match_Info_Storage.bT1Score[index]);
            bT2ScoreTextBox.Text = Convert.ToString(Match_Info_Storage.bT2Score[index]);
            bT3ScoreTextBox.Text = Convert.ToString(Match_Info_Storage.bT3Score[index]);
            rT1NotesTextBox.Text = Match_Info_Storage.rT1Notes[index];
            rT2NotesTextBox.Text = Match_Info_Storage.rT2Notes[index];
            rT3NotesTextBox.Text = Match_Info_Storage.rT3Notes[index];
            bT1NotesTextBox.Text = Match_Info_Storage.bT1Notes[index];
            bT2NotesTextBox.Text = Match_Info_Storage.bT2Notes[index];
            bT3NotesTextBox.Text = Match_Info_Storage.bT3Notes[index];
            matchNumberTextBox.Text = Convert.ToString(Match_Info_Storage.matchNumber[index]);
        }
    }
}
