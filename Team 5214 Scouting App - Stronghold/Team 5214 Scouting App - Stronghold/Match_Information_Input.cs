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
    public partial class Match_Information_Input : Form
    {
        public Match_Information_Input()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Match_Info_Storage.index == 200)
            {
                MessageBox.Show("You have have no storage left, export the data then clear all.", "No Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(rT1NumberTextBox.Text) | string.IsNullOrWhiteSpace(rT1ScoreTextBox.Text) | string.IsNullOrWhiteSpace(rT1NotesTextBox.Text) | string.IsNullOrWhiteSpace(rT2NumberTextBox.Text) | string.IsNullOrWhiteSpace(rT2ScoreTextBox.Text) | string.IsNullOrWhiteSpace(rT2NotesTextBox.Text) | string.IsNullOrWhiteSpace(rT3NumberTextBox.Text) | string.IsNullOrWhiteSpace(rT3ScoreTextBox.Text) | string.IsNullOrWhiteSpace(rT3NotesTextBox.Text) | string.IsNullOrWhiteSpace(bT1NumberTextBox.Text) | string.IsNullOrWhiteSpace(bT1ScoreTextBox.Text) | string.IsNullOrWhiteSpace(bT1NotesTextBox.Text) | string.IsNullOrWhiteSpace(bT2NumberTextBox.Text) | string.IsNullOrWhiteSpace(bT2ScoreTextBox.Text) | string.IsNullOrWhiteSpace(bT2NotesTextBox.Text) | string.IsNullOrWhiteSpace(bT3NumberTextBox.Text) | string.IsNullOrWhiteSpace(bT3ScoreTextBox.Text) | string.IsNullOrWhiteSpace(bT3NotesTextBox.Text) | string.IsNullOrWhiteSpace(matchNumberTextBox.Text))
                {
                    MessageBox.Show("You are mssing required information.", "Error, Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int index = Match_Info_Storage.index;
                    Match_Info_Storage.rT1Number[index] = Convert.ToInt16(rT1NumberTextBox.Text);
                    Match_Info_Storage.rT2Number[index] = Convert.ToInt16(rT2NumberTextBox.Text);
                    Match_Info_Storage.rT3Number[index] = Convert.ToInt16(rT3NumberTextBox.Text);
                    Match_Info_Storage.bT1Number[index] = Convert.ToInt16(bT1NumberTextBox.Text);
                    Match_Info_Storage.bT2Number[index] = Convert.ToInt16(bT2NumberTextBox.Text);
                    Match_Info_Storage.bT3Number[index] = Convert.ToInt16(bT3NumberTextBox.Text);
                    Match_Info_Storage.rT1Score[index] = Convert.ToInt16(rT1ScoreTextBox.Text);
                    Match_Info_Storage.rT2Score[index] = Convert.ToInt16(rT2ScoreTextBox.Text);
                    Match_Info_Storage.rT3Score[index] = Convert.ToInt16(rT3ScoreTextBox.Text);
                    Match_Info_Storage.bT1Score[index] = Convert.ToInt16(bT1ScoreTextBox.Text);
                    Match_Info_Storage.bT2Score[index] = Convert.ToInt16(bT2ScoreTextBox.Text);
                    Match_Info_Storage.bT3Score[index] = Convert.ToInt16(bT3ScoreTextBox.Text);
                    Match_Info_Storage.rT1Notes[index] = rT1NotesTextBox.Text;
                    Match_Info_Storage.rT2Notes[index] = rT2NotesTextBox.Text;
                    Match_Info_Storage.rT3Notes[index] = rT3NotesTextBox.Text;
                    Match_Info_Storage.bT1Notes[index] = bT1NotesTextBox.Text;
                    Match_Info_Storage.bT2Notes[index] = bT2NotesTextBox.Text;
                    Match_Info_Storage.bT3Notes[index] = bT3NotesTextBox.Text;
                    Match_Info_Storage.matchNumber[index] = Convert.ToInt16(matchNumberTextBox.Text);
                    Match_Info_Storage.index++;
                    Robot_Info_Storage.changes = true;
                    rT1NumberTextBox.Text = "";
                    rT2NumberTextBox.Text = "";
                    rT3NumberTextBox.Text = "";
                    bT1NumberTextBox.Text = "";
                    bT2NumberTextBox.Text = "";
                    bT3NumberTextBox.Text = "";
                    rT1ScoreTextBox.Text = "";
                    rT2ScoreTextBox.Text = "";
                    rT3ScoreTextBox.Text = "";
                    bT1ScoreTextBox.Text = "";
                    bT2ScoreTextBox.Text = "";
                    bT3ScoreTextBox.Text = "";
                    rT1NotesTextBox.Text = "";
                    rT2NotesTextBox.Text = "";
                    rT3NotesTextBox.Text = "";
                    bT1NotesTextBox.Text = "";
                    bT2NotesTextBox.Text = "";
                    bT3NotesTextBox.Text = "";
                    matchNumberTextBox.Text = "";
                    rT1NumberTextBox.Focus();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
