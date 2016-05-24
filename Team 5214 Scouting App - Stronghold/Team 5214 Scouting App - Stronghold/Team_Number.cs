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
    public partial class Team_Number : Form
    {
        public Team_Number()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a match number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Robot_Info_Storage.infoIndex = listBox1.SelectedIndex;
                Team_Results newForm = new Team_Results();
                newForm.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Team_Number_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i < Robot_Info_Storage.index)
            {
                listBox1.Items.Add(Robot_Info_Storage.teamNumber[i]);
                i++;
            }
        }
    }
}
