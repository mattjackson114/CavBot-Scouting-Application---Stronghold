using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Team_5214_Scouting_App___Stronghold
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            int i = 0;
            Series series = this.chart1.Series[0];
            while (i < Robot_Info_Storage.scoreIndex)
            {
                series.Points.Add(Robot_Info_Storage.scores[i]);
                i++;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
