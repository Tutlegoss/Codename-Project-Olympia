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

namespace Project_Codename_Olympia_v1._0
{

    public partial class ScoringForm : Form
    {
        private string SelectedEvent;
        public ScoringForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mens 500m Speed Skating");
            listBox1.Items.Add("Womens 500m Speed Skating");
            listBox1.Items.Add("Mens 1000m Speed Skating");
            listBox1.Items.Add("Womens 1000m Speed Skating");
            listBox1.Items.Add("Mens 1500m Speed Skating");
            listBox1.Items.Add("Womens 1500m Speed Skating");
            listBox1.Items.Add("Ice Dance Mens");
            listBox1.Items.Add("Ice Dance Womens");
            listBox1.Items.Add("Single Skating Mens");
            listBox1.Items.Add("Single Skating Womens");
            listBox1.Items.Add("Pair Skating Scores");




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string selected = listBox1.GetItemText(listBox1.SelectedItem);
            if (selected == "Mens 500m Speed Skating")
            {
                //global string used to place event name into it
                SelectedEvent = "\"ss500m Times Men\"";
                label1.Text = "Mens 500m Speed Skating"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"ss500m Times Men\" ORDER BY Times DESC;";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                //make buttons visible that will work with this table to enter times in
                button2.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;

            }
            if (selected == "Womens 500m Speed Skating")
            {
                //global string used to place event name into it
                SelectedEvent = "\"ss500m Times Women\"";
                label1.Text = "Womens 500m Speed Skating"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"ss500m Times Women\" ORDER BY Times DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();
                    //make buttons visible that will work with this table to enter times in
                    button2.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    //makes sure unused components are disabled
                    label6.Visible = false;
                    label7.Visible = false;
                    button3.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            if (selected == "Mens 1000m Speed Skating")
            {
                SelectedEvent = "\"ss1000m Times Men\"";
                label1.Text = "Mens 1000m Speed Skating"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"ss1000m Times Men\" ORDER BY Times DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();
                    //make buttons visible that will work with this table to enter times in
                    button2.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    //makes sure unused components are disabled
                    label6.Visible = false;
                    label7.Visible = false;
                    button3.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            if (selected == "Womens 1000m Speed Skating")
            {
                SelectedEvent = "\"ss1000m Times Women\"";
                label1.Text = "Womens 1000m Speed Skating"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"ss1000m Times Women\" ORDER BY Times DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();
                    //make buttons visible that will work with this table to enter times in
                    button2.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    //makes sure unused components are disabled
                    label6.Visible = false;
                    label7.Visible = false;
                    button3.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            if (selected == "Mens 1500m Speed Skating")
            {
                SelectedEvent = "\"ss1500m Times Men\"";
                label1.Text = "Mens 1500m Speed Skating"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"ss1500m Times Men\" ORDER BY Times DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //make buttons visible that will work with this table to enter times in
                button2.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                //makes sure unused components are disabled
                label6.Visible = false;
                label7.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            if (selected == "Womens 1500m Speed Skating")
            {
                SelectedEvent = "\"ss1500m Times Women\"";
                label1.Text = "Womens 1500m Speed Skating"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"ss1500m Times Women\" ORDER BY Times DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();
                    //make buttons visible that will work with this table to enter times in
                    button2.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    //makes sure unused components are disabled
                    label6.Visible = false;
                    label7.Visible = false;
                    button3.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            if (selected == "Ice Dance Mens")
            {
                SelectedEvent = "\"Ice Dance Mens Scores\"";
                label1.Text = "Ice Dance Mens"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"Ice Dance Mens Scores\" ORDER BY Score DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                //makes the correct components are visible to enter scores
                label6.Visible = true;
                label7.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                //makes sure the other components are disabled
                button2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;

            }
            if (selected == "Ice Dance Womens")
            {
                SelectedEvent = "\"Ice Dance Womens Scores\"";
                label1.Text = "Ice Dance Womens"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"Ice Dance Womens Scores\" ORDER BY Score DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                //makes the correct components are visible to enter scores
                label6.Visible = true;
                label7.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                //makes sure the other components are disabled
                button2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
            }
            if (selected == "Single Skating Mens")
            {
                SelectedEvent = "\"Single Skating Men Scores\"";
                label1.Text = "Single Skating Mens"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"Single Skating Men Scores\" ORDER BY Score DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                //makes the correct components are visible to enter scores
                label6.Visible = true;
                label7.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                //makes sure the other components are disabled
                button2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
            }
            if (selected == "Single Skating Womens")
            {
                SelectedEvent = "\"Single Skating Womens Scores\"";
                label1.Text = "Single Skating Womens"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"Single Skating Womens Scores\" ORDER BY Score DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                //makes the correct components are visible to enter scores
                label6.Visible = true;
                label7.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                //makes sure the other components are disabled
                button2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
            }
            if (selected == "Pair Skating Scores")
            {
                SelectedEvent = "\"Pair Skating Scores\"";
                label1.Text = "Pair Skating Scores"; label1.Refresh();
                string ViewTable = "SELECT * FROM \"Pair Skating Scores\" ORDER BY Score DESC";//gets team table from database
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                        if (con.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            //this sends sql commands to database
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(ViewTable, con);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();

                }
                //this gets the number of entries the event has
                int GridCount = dataGridView1.Rows.Count;
                //for loop used to populate the scores column with places
                for (int i = 0; i < GridCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                //makes the correct components are visible to enter scores
                label6.Visible = true;
                label7.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                //makes sure the other components are disabled
                button2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string time = textBox1.Text;//gets team from text box
            //class created to store athletes info
            Athlete AthleteScore = new Athlete();
            //stores name of athlete
            AthleteScore.firstName = dataGridView1.SelectedCells[1].Value.ToString();
            AthleteScore.lastName = dataGridView1.SelectedCells[2].Value.ToString();
            //creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    //checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //adds entry from event to the specific event
                        string sql = String.Format("UPDATE " + SelectedEvent + " SET Times = " + time +
                        " WHERE \"Athlete First Name\" = '" + AthleteScore.firstName + "' AND \"Athlete Last Name\" = '" + AthleteScore.lastName + "';");
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(sql, con);
                        da.Fill(ds);
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }
            }
            MessageBox.Show("Time has been entered into " + AthleteScore.firstName + " " + AthleteScore.lastName + "'s time");
            //this will update the score board to reflect the changes
            string View = "SELECT * FROM " + SelectedEvent + " ORDER BY Times DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View, con);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double total;
            double[] num = new double[7];
            num[0] = Convert.ToDouble(textBox2.Text);
            num[1] = Convert.ToDouble(textBox3.Text);
            num[2] = Convert.ToDouble(textBox4.Text);
            num[3] = Convert.ToDouble(textBox5.Text);
            num[4] = Convert.ToDouble(textBox6.Text);
            num[5] = Convert.ToDouble(textBox7.Text);
            num[6] = Convert.ToDouble(textBox8.Text);
            total = num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6];
            total = total - (num.Min() + num.Max());
            total = total / 5;

            //class created to store athletes info
            Athlete AthleteScore = new Athlete();
            //stores name of athlete
            AthleteScore.firstName = dataGridView1.SelectedCells[1].Value.ToString();
            AthleteScore.lastName = dataGridView1.SelectedCells[2].Value.ToString();
            //creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    //checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //adds entry from event to the specific event
                        string sql = String.Format("UPDATE " + SelectedEvent + " SET Score = " + total +
                        " WHERE \"Athlete First Name\" = '" + AthleteScore.firstName + "' AND \"Athlete Last Name\" = '" + AthleteScore.lastName + "';");
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(sql, con);
                        da.Fill(ds);
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }
            }
            MessageBox.Show("Score has been entered into " + AthleteScore.firstName + " " + AthleteScore.lastName + "'s score");
            //this will update the score board to reflect the changes
            string View = "SELECT * FROM " + SelectedEvent + " ORDER BY Score DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View, con);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }
                con.Close();
            }


        }
    }
}
