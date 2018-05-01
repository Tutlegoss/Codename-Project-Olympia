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
    //! Register Event class for GUI
    public partial class RegisterEventForm : Form
    {
        public RegisterEventForm()
        {
            InitializeComponent();
        }

        private void RegisterEventForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mens 500m Speed Skating, Monday, 12:00pm, Rink 1");
            listBox1.Items.Add("Womens 500m Speed Skating, Monday, 12:00pm Rink 2");
            listBox1.Items.Add("Mens 1000m Speed Skating, Tueday, 12:00pm, Rink 1");
            listBox1.Items.Add("Womens 1000m Speed Skating, Tuesday, 12:00pm, Rink 2");
            listBox1.Items.Add("Mens 1500m Speed Skating, Wednesday, 12:00pm, Rink 1");
            listBox1.Items.Add("Womens 1500m Speed Skating, Wednesday, 12:00pm, Rink 2");
            listBox1.Items.Add("Single Skating Mens, Monday, 11:00am, Rink 3");
            listBox1.Items.Add("Single Skating Womens, Monday, 11:00am, Rink 4");
            listBox1.Items.Add("Ice Dance Mens, Tuesday, 2:00pm, Rink 3");
            listBox1.Items.Add("Ice Dance Womens, Tuesday, 2:00pm, Rink 4");
            listBox1.Items.Add("Couple Skating, Monday, 5:00pm, Rink 3");
            string ViewTable = "SELECT * FROM 'Athlete Information'; ";//gets team table from database
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
            string View = "SELECT * FROM 'Events'; ";//gets team table from database
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
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }
                con.Close();
            }
            string ViewTeams = "SELECT * FROM 'Team Information'";//gets team table from database
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB

                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(ViewTeams, con);
                        da.Fill(ds);
                        dataGridView3.DataSource = ds.Tables[0].DefaultView;
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

            //class created to store athletes info
            Athlete AddAthlete = new Athlete();
            //objects used to store the athletes info
           
            AddAthlete.firstName = dataGridView1.SelectedCells[1].Value.ToString();
            AddAthlete.lastName = dataGridView1.SelectedCells[2].Value.ToString();
            //stores country name
            string country = dataGridView1.SelectedCells[0].Value.ToString();
            //select puts the selected event into a string
            string selected = listBox1.GetItemText(listBox1.SelectedItem);
            //if statements check the selected item from list box and will execute 
            //the corresponding class member functions
            if (selected == "Mens 500m Speed Skating, Monday, 12:00pm, Rink 1")
            {
                //create new instance of an object
                SS500m EventRegister = new SS500m();
                //member function adds athlete to database
                EventRegister.AddAthleteMale(country, AddAthlete.firstName, AddAthlete.lastName);

            }
            if (selected == "Womens 500m Speed Skating, Monday, 12:00pm Rink 2")
            {
                //create new instance of an object
                SS500m EventRegister = new SS500m();
                //member function adds athlete to database
                EventRegister.AddAthleteFemale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Mens 1000m Speed Skating, Tueday, 12:00pm, Rink 1")
            {
                //create new instance of an object
                SS1000m EventRegister = new SS1000m();
                //member function adds athlete to database
                EventRegister.AddAthleteMale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Womens 1000m Speed Skating, Tuesday, 12:00pm, Rink 2")
            {
                //create new instance of an object
                SS1000m EventRegister = new SS1000m();
                //member function adds athlete to database
                EventRegister.AddAthleteFemale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Mens 1500m Speed Skating, Wednesday, 12:00pm, Rink 1")
            {
                //create new instance of an object
                SS1500m EventRegister = new SS1500m();
                //member function adds athlete to database
                EventRegister.AddathleteMale(country, AddAthlete.firstName, AddAthlete.lastName);

            }
            if (selected == "Womens 1500m Speed Skating, Wednesday, 12:00pm, Rink 2")
            {
                //create new instance of an object
                SS1500m EventRegister = new SS1500m();
                //member function adds athlete to database
                EventRegister.AddAthleteFemale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Single Skating Mens, Monday, 11:00am, Rink 3")
            {
                //create new instance of an object
                SingleSkating EventRegister = new SingleSkating();
                //member function adds athlete to database
                EventRegister.AddAthleteMale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Single Skating Womens, Monday, 11:00am, Rink 4")
            {
                //create new instance of an object
                SingleSkating EventRegister = new SingleSkating();
                //member function adds athlete to database
                EventRegister.AddAthleteFemale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Ice Dance Mens, Tuesday, 2:00pm, Rink 3")
            {
                //create new instance of an object
                IceDance EventRegister = new IceDance();
                //member function adds athlete to database
                EventRegister.AddAthleteMale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Ice Dance Womens, Tuesday, 2:00pm, Rink 4")
            {
                //create new instance of an object
                IceDance EventRegister = new IceDance();
                //member function adds athlete to database
                EventRegister.AddAthleteFemale(country, AddAthlete.firstName, AddAthlete.lastName);
            }
            if (selected == "Couple Skating, Monday, 5:00pm, Rink 3")
            {
                //create new instance of an object
                PairSkating EventRegister = new PairSkating();
                //member function adds athlete to database
                EventRegister.AddAthlete(country, AddAthlete.firstName, AddAthlete.lastName);

            }
            //this will repopulate Event with the added entry
            string View = "SELECT * FROM 'Events'";//gets team table from database
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

      

        private void button3_Click(object sender, EventArgs e)
        {
            //class created to store athletes info
            Athlete DeleteAthlete = new Athlete();
            //stores name of athlete
            DeleteAthlete.firstName = dataGridView2.SelectedCells[2].Value.ToString();
            DeleteAthlete.lastName = dataGridView2.SelectedCells[3].Value.ToString();
            //creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB
                    //checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //deletes entry from athlete information
                        string sql = String.Format("DELETE FROM Events WHERE \"Athlete First Name\"  = '"+ DeleteAthlete.firstName + "'" +
                        "AND \"Athlete Last Name\" = '" + DeleteAthlete.lastName + "'; ");
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(sql, con);
                        da.Fill(ds);
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }

                MessageBox.Show("Entry has been deleted from database!");
                con.Close();
            }
            //this will repopulate Event with the added entry
            string View = "SELECT * FROM 'Events'";//gets team table from database
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

        private void button2_Click(object sender, EventArgs e)
        {
            //enters selected row into a string variable
            string country = dataGridView3.CurrentCell.Value.ToString();
            //gets team table from database
            string ViewTable = "SELECT * FROM 'Athlete Information' WHERE \"TeamName\" = '" + country + "';";
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

        private void button4_Click(object sender, EventArgs e)
        {
            string selected = dataGridView3.CurrentCell.Value.ToString();
            string ViewTable = "SELECT * FROM 'Events' WHERE \"Team Name\" = '" + selected + "';";
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
    }
}


    

