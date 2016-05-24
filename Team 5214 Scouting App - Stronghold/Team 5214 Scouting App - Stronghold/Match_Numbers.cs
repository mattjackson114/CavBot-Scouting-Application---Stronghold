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
    public partial class Match_Numbers : Form
    {
        public Match_Numbers()
        {
            InitializeComponent();
        }

        private void Match_Numbers_Load(object sender, EventArgs e)
        {
                int i = 0;
                while (i < Match_Info_Storage.index)
                {
                    listBox1.Items.Add(Match_Info_Storage.matchNumber[i]);
                    i++;
                }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a match number first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Match_Info_Storage.infoIndex = listBox1.SelectedIndex;
                Match_Results newForm = new Match_Results();
                newForm.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
