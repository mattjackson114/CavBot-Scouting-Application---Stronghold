using System;
using System.Windows.Forms;
using System.IO;

namespace Team_5214_Scouting_App___Stronghold
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void duration_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 45)
            {
                Main_Form newForm = new Main_Form();
                this.Hide();
                newForm.Show();
                this.Close();
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string finalPath = @"\Team 5214 Scouting Application Stronghold";
            string path = filePath + finalPath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(path + @"\Robot Info.txt");
                File.Create(path + @"\Match Info.txt");
            }
        }
    }
}
