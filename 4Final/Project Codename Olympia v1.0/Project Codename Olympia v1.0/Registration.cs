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
    //! Registration class for GUI
    public partial class AthleteForm : Form
    {
        public AthleteForm()
        {
            InitializeComponent();
        }

        private void AthleteForm_Load(object sender, EventArgs e)
        {
            ///populate list box
            listBox1.Items.Add("Male");
            listBox1.Items.Add("Female");
            string ViewTable = "SELECT * FROM 'Athlete Information'";///gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB

                    if (con.State == ConnectionState.Open) /// if connection.Open was successful
                    {
                        ///this sends sql commands to database
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
            string View = "SELECT * FROM 'Team Information'";///gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();///opens DB

                    if (con.State == ConnectionState.Open) /// if connection.Open was successful
                    {
                        ///this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(View, con);
                        da.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }

                }
                con.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ///string used to place cell contents into
            string country;
            ///gets selected row
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            ///enters selected row into a string variable
            country = dataGridView2.CurrentCell.Value.ToString();
            ///string to store selected gender
            string selected = listBox1.GetItemText(listBox1.SelectedItem);
            ///object used to store athletes info
            Athlete AddAthlete = new Athlete();
            ///add athletes info to object
            AddAthlete.firstName = textBox1.Text;
            AddAthlete.lastName = textBox2.Text;
            AddAthlete.gender = selected;
            ///object from registration class 
            Registration RegAthlete = new Registration();
            ///calls member function of Registration
            RegAthlete.registerAthlete(AddAthlete.firstName, AddAthlete.lastName, AddAthlete.gender, country);
            ///this will refresh the list
            string ViewTable = "SELECT * FROM 'Athlete Information'";///gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();///opens DB

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

        private void button2_Click(object sender, EventArgs e)
        {
            ///stores name of athlete seleceted from DB
            string DeleteFName = dataGridView1.SelectedCells[1].Value.ToString();
            string DeleteLName = dataGridView1.SelectedCells[2].Value.ToString();
            ///object created to delete entry
            Registration DelAthlete = new Registration();
            ///member function deletes athlete from registration
            DelAthlete.deleteAthlete(DeleteFName, DeleteLName);
            ///this will call a refreshed table
            string ViewTable = "SELECT * FROM 'Athlete Information'";///gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();///opens DB

                    if (con.State == ConnectionState.Open) /// if connection.Open was successful
                    {
                        ///this sends sql commands to database
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

        private void button3_Click(object sender, EventArgs e)
        {
            ///enters selected row into a string variable
            string country = dataGridView2.CurrentCell.Value.ToString();
            ///gets team table from database
            string ViewTable = "SELECT * FROM 'Athlete Information' WHERE \"TeamName\" = '" + country + "';";
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();///opens DB

                    if (con.State == ConnectionState.Open) /// if connection.Open was successful
                    {
                        ///this sends sql commands to database
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
    }
}
