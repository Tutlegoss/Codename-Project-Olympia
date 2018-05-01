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
    //! Team class for GUI
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            string ViewTable = "SELECT * FROM 'Team Information'";//gets team table from database
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //object decleration
            Team AddTeam = new Team();
            AddTeam.countryName = textBox1.Text;//gets team from text box
            //calls member function that adds team name to DB
            AddTeam.AddTeam(AddTeam.countryName);
            
            //this updates the table with added entry
            string ViewTable = "SELECT * FROM 'Team Information'";//gets team table from database
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string used to place cell contents into
            string remove;
            //gets selected row
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //enters selected row into a string variable
            remove = dataGridView1.CurrentCell.Value.ToString();

            //impeded sql statement to delete value from database
            string DeleteDB = "DELETE FROM 'team information' WHERE TeamName = '" + remove + "';";
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB

                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(DeleteDB, con);
                        da.Fill(ds);
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }

                }
                con.Close();
                MessageBox.Show(remove + " has been removed from database!");
            }
            //this updates the table with deleted entry
            string ViewTable = "SELECT * FROM 'Team Information'";//gets team table from database
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
