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
    //! Display class for GUI
    /** @author Landen Marchand
    */
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //stores countries to compare medal winners
            string first, second, third;
            string[] countries = { "Team America", "Team Great Britain", "Team Norway", "Team Germany", "Team Canada", "Team South Korea", "Team China", "Team Japan", "Team Switzerland", "Team Sweden", "Team Azerbaijan", "Team Bosnia" };
            //count stores the medal count for each country as they get added incrimently
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //this is used to populate an event table
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
            //stores country name of first second and third places
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View1 = "SELECT * FROM \"ss500m Times Women\" ORDER BY Times DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View1, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View2 = "SELECT * FROM \"ss1000m Times Men\" ORDER BY Times DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View2, con);
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
            
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }



            string View3 = "SELECT * FROM \"ss1000m Times Women\" ORDER BY Times DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View3, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View4 = "SELECT * FROM \"ss1500m Times Men\" ORDER BY Times DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View4, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View5 = "SELECT * FROM \"ss1500m Times Women\" ORDER BY Times DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View5, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View6 = "SELECT * FROM \"Ice Dance Mens Scores\" ORDER BY Score DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View6, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View7 = "SELECT * FROM \"Ice Dance Womens Scores\" ORDER BY Score DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View7, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View8 = "SELECT * FROM \"Pair Skating Scores\" ORDER BY Score DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View8, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View9 = "SELECT * FROM \"Single Skating Men Scores\" ORDER BY Score DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View9, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            string View10 = "SELECT * FROM \"Single Skating Womens Scores\" ORDER BY Score DESC;";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View10, con);
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
            first = dataGridView1.Rows[0].Cells[3].Value.ToString();
            second = dataGridView1.Rows[1].Cells[3].Value.ToString();
            third = dataGridView1.Rows[2].Cells[3].Value.ToString();

            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for first if so add to count
                if (first == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for second if so add to count
                if (second == countries[i])
                {
                    count[i]++;
                }
            }
            //for loop loops through all possible countries to check
            for (int i = 0; i < 12; i++)
            {
                //if statement checks each country if they match for third if so add to count
                if (third == countries[i])
                {
                    count[i]++;
                }
            }
            //this will display county names in the datagridview
            string ViewT = "SELECT * FROM 'Team Information'";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB

                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(ViewT, con);
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
            //for loop used to populate the medal column
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = count[i];
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
