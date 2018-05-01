using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace PCO._0
{
    //! Main Screen class for GUI

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var TeamForm = new TeamForm();
            TeamForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AthleteForm = new AthleteForm();
            AthleteForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var RegisterEventForm = new RegisterEventForm();
            RegisterEventForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ScoringForm = new ScoringForm();
            ScoringForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form6 = new Display();
            form6.Show();
        }
    }
}
