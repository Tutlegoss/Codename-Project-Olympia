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
            string ViewTable = "SELECT Teamname, AthleteFirstName, AthleteLastName FROM 'Athlete Information'; ";//gets team table from database
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
            if (selected == "Mens 500m Speed Skating, Monday, 12:00pm, Rink 1")
            {
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                    {
                        con.Open();//opens DB
                                   //checks connection and fills grid view with Race table
                        if (con.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Mens 500m Speed Skating', '" +
                                country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '12:00pm', 'Monday', 'Rink 1');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, con);
                            da.Fill(ds);

                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    con.Close();
                    MessageBox.Show("Athlete has been entered into Event!");
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                        {
                            conn.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (conn.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO \"ss500m Times Men\" ('Athlete First Name', 'Athlete Last Name', " +
                                    "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, conn);
                                da.Fill(ds);
                                conn.Close();
                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                    }

                }
               }
                if (selected == "Womens 500m Speed Skating, Monday, 12:00pm Rink 2")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Womens 500m Speed Skating', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '12:00pm', 'Monday', 'Rink 2');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"ss500m Times Women\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Mens 1000m Speed Skating, Tueday, 12:00pm, Rink 1")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Mens 1000m Speed Skating', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '12:00pm', 'Tuesday', 'Rink 1');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"ss1000m Times Men\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }

            }
                if (selected == "Womens 1000m Speed Skating, Tuesday, 12:00pm, Rink 2")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Womens 1000m Speed Skating', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '12:00pm', 'Tuesday', 'Rink 2');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"ss1000m Times Women\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Mens 1500m Speed Skating, Wednesday, 12:00pm, Rink 1")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Mens 1500m Speed Skating', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '12:00pm', 'Wednesday', 'Rink 1');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"ss1500m Times Men\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Womens 1500m Speed Skating, Wednesday, 12:00pm, Rink 2")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Womens 1500m Speed Skating', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '12:00pm', 'Wednesday', 'Rink 2');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"ss1500m Times Women\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Single Skating Mens, Monday, 11:00am, Rink 3")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Single Skating Mens', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '11:00am', 'Monday', 'Rink 3');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"Single Skating Men Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Single Skating Womens, Monday, 11:00am, Rink 4")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Single Skating Womens', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '11:00am', 'Monday', 'Rink 4');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"Single Skating Womens Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Ice Dance Mens, Tuesday, 2:00pm, Rink 3")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Ice Dance Mens', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '2:00pm', 'Tuesday', 'Rink 3');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"Ice Dance Mens Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Ice Dance Womens, Tuesday, 2:00pm, Rink 4")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Ice Dance Womens', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '2:00pm', 'Tuesday', 'Rink 4');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"Ice Dance Womens Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'TeamName') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
            }
                if (selected == "Couple Skating, Monday, 5:00pm, Rink 3")
                {
                    //creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();//opens DB
                                       //checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Couple Skating', '" +
                                    country + "', '" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '5:00pm', 'Tuesday', 'Rink 3');");
                                DataSet ds = new DataSet();
                                var da = new SQLiteDataAdapter(sql, con);
                                da.Fill(ds);

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        MessageBox.Show("Athlete has been entered into Event!");
                        con.Close();
                    }
                //creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();//opens DB
                                    //checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"Pair Skating Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + AddAthlete.firstName + "', '" + AddAthlete.lastName + "', '" + country + "');");
                            DataSet ds = new DataSet();
                            var da = new SQLiteDataAdapter(sql, conn);
                            da.Fill(ds);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                }
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
    }
}


    

