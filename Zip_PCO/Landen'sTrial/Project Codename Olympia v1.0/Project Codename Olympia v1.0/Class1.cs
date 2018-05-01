using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

//namespace Project_Codename_Olympia_v1._0
//{
    //Display will count how many medals are earned by each country

    //! Athlete class to input individual's personal information and events to partake in
    /*! DEFINITION: An individual who is a part of a team in the Winter Olympics.
	 * 
 	 *  CONSTRAINTS: Can only be registered if maximum allotted space on their respective 
 	 *               team has not been reached. This also includes the gender portion.
 	 */
    /** @author Landen Marchand
	*/
    public class Athlete
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Athlete()
        {

        }

        /** Sets and gets athlete's first name
		    @param string for first name
		    @return string of first name
		*/
        public string firstName { get; set; }
        /** Sets and gets athlete's last name
		    @param string for last name
		    @return string of last name
		*/
        public string lastName { get; set; }
        /** Sets and gets athlete's gender
			@param string for gender
			@return string of gender
		*/
        public string gender { get; set; }
    }
    //! DEPRECATED!!! Database SUBSYSTEM houses all the information of the Winter Olympics
    /*! DEFINITION: The collection of all information for all events in the Winter Olympics. 
	 *              A database also is a collection of all registrants information.
	 * 
 	 *  CONSTRAINTS: Must contain information apropos to the event and registrants at hand.
 	 */
    /** @author Landen Marchand
	*/
    public class Database
    {
        public Database()
        {
        }
    }
    //! IceDance class is one of the 3 FigureSkating events
    /*! DEFINITION: Form of figure skating where athletes participate in male/female 
	 *              pairs. The utilization of the same technique as Pair Skating is 
	 *              present but the dancing is all done in tandem versus implementing 
	 *              technical tricks.
	 * 
     *  CONSTRAINTS: The pairs are male/female. Each pair performs solo on the rink at 
     *               a given time. Total duration of performance is 4 mintues and 30 seconds.
	 */
    /** @author Landen Marchand
	*/
    public class IceDance
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public IceDance()
        {
        }
        /** Void function adds male to database for the event
            @param string for athlete's team name
            @param string for first name of athlete
            @param string for last name of athlete
        */
        public void AddAthleteMale(string country, string Fname, string Lname)
        {
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open(); //!< Opens DB
                               //!< Checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //!< Adds entry to athlete information
                        string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                            "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Ice Dance Mens', '" +
                            country + "', '" + Fname + "', '" + Lname + "', '2:00pm', 'Tuesday', 'Rink 3');");
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
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open(); //!< Opens DB
                                //!< Checks connection and fills grid view with Race table
                    if (conn.State == ConnectionState.Open)
                    {
                        //!< Adds entry to athlete information
                        string sql = String.Format("INSERT INTO \"Ice Dance Mens Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                            "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
        /** Void function adds female to database for the event
            @param string for athlete's team name
            @param string for first name of athlete
            @param string for last name of athlete
        */
        public void AddAthleteFemale(string country, string Fname, string Lname)
        {
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open(); //!< Opens DB
                               //!< Checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //!< Adds entry to athlete information
                        string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                            "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Ice Dance Womens', '" +
                            country + "', '" + Fname + "', '" + Lname + "', '2:00pm', 'Tuesday', 'Rink 4');");
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
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open(); //!< Opens DB
                                //!< Checks connection and fills grid view with Race table
                    if (conn.State == ConnectionState.Open)
                    {
                        //!< Adds entry to athlete information
                        string sql = String.Format("INSERT INTO \"Ice Dance Womens Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                            "'TeamName') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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

   // }
    //! Registration class registers Teams and Athletes
    /*! DEFINTION: The process of obtaining athletes who have successfully completed all 
	 *             qualification rounds prior to the Winter Olympics. Registration places 
	 *             athletes into their respective team and places athletes to a specified event.
	 * 
     *  CONSTRAINTS: Sets a maximum limit of athletes per event. Sets a max limit on number 
     *               of teams in the Winter Olympics.
	 */
    /** @author Landen Marchand
	*/
    public class Registration
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Registration()
        {

        }
    /** Void function registeres Athlete to Database/Registration
        @param string for first name of athlete
        @param string for last name of athlete
        @param string for athlete's team name
        @param string for athlete's team name
    */
    public void registerAthlete(string Fname, string Lname , string Gender, string team)
        {
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open(); //!< Opens DB
                    //!< Checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //!< Adds entry to athlete information
                        string sql = String.Format("INSERT INTO 'Athlete Information' ('TeamName' , 'AthleteFirstName', 'AthleteLastName', 'Gender') " +
                        "VALUES ('" + team + "', '" + Fname + "', '" + Lname + "', '" + Gender + "');");
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(sql, con);
                        da.Fill(ds);

                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }
                }
                MessageBox.Show("Entry has been entered into Database!");
                con.Close();
            }
        }
    /** Void function removes Athlete from Database/Registration
        @param string for first name of athlete
        @param string for last name of athlete
    */
    public void deleteAthlete(string Fname, string Lname)
        {
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open(); //!< Opens DB
                    //!< Checks connection and fills grid view with Race table
                    if (con.State == ConnectionState.Open)
                    {
                        //!< Adds entry to athlete information
                        string sql = String.Format("DELETE FROM 'Athlete Information' WHERE AthleteFirstName = '" + Fname + 
                            "' AND AthleteLastName = '" + Lname + "';");
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
        }
    }
    //! SS1000m is one of the 3 SpeedSkating events
    /*! DEFINTION: Form of speed skating where athletes utilize inline skates 
	 *             and race around a 400m rink 2.5 times. Whichever athlete crosses 
	 *             the finish line first has the lowest time.
	 * 
     *  CONSTRAINTS: A maximum of four athletes compete at a given time.
	 */
    /** @author Landen Marchand
	*/
    class SS1000m
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SS1000m()
        {
        }
    /** Void function adds male athletes to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */    
    public void AddAthleteMale(string country, string Fname, string Lname)
        {
                    //!< Creates variable for connection string
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open(); //!< Opens DB
                                       //!< Checks connection and fills grid view with Race table
                            if (con.State == ConnectionState.Open)
                            {
                                //!< Adds entry to athlete information
                                string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                                    "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Mens 1000m Speed Skating', '" +
                                    country + "', '" + Fname + "', '" + Lname + "', '12:00pm', 'Tuesday', 'Rink 1');");
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
                //!< Creates variable for connection string
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
                {
                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open(); //!< Opens DB
                                     //!< Checks connection and fills grid view with Race table
                        if (conn.State == ConnectionState.Open)
                        {
                            //!< Adds entry to athlete information
                            string sql = String.Format("INSERT INTO \"ss1000m Times Men\" ('Athlete First Name', 'Athlete Last Name', " +
                                "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
    /** Void function adds female athletes to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */    
    public void AddAthleteFemale(string country, string Fname, string Lname)
        {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                           //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Womens 1000m Speed Skating', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '12:00pm', 'Tuesday', 'Rink 2');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                             //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"ss1000m Times Women\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
    //! SS1500m is one of the 3 SpeedSkating events
    /*! DEFINTION: Form of speed skating where athletes utilize inline skates 
	 *             and race around a 400m rink 3.75 times. Whichever athlete crosses 
	 *             the finish line first has the lowest time.
	 * 
     *  CONSTRAINS: A maximum of four athletes compete at a given time.
	 */
    /** @author Landen Marchand
	*/
    class SS1500m
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SS1500m()
        {
        }
    /** Void function adds male athletes to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */ 
    public void AddathleteMale(string country, string Fname, string Lname)
        {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Mens 1500m Speed Skating', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '12:00pm', 'Wednesday', 'Rink 1');");
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
            //!< Creates variable for connection string
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
             {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
                {
                conn.Open(); //!< Opens DB
                             //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"ss1500m Times Men\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
    /** Void function adds female athletes to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */ 
    public void AddAthleteFemale(string country, string Fname, string Lname)
    {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Womens 1500m Speed Skating', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '12:00pm', 'Wednesday', 'Rink 2');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                             //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"ss1500m Times Women\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
    //! SS500m is one of the 3 SpeedSkating events
    /*! DEFINITION: Form of speed skating where athletes utilize inline skates 
	 *              and race around a 400m rink 1.25 times. Whichever athlete 
	 *              crosses the finish line first has the lowest time.
	 * 
     *  CONSTRAINTS: A maximum of four athletes compete at a given time.
	 */
    /** @author Landen Marchand
	*/
    class SS500m
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SS500m()
        {
        }
    /** Void function adds male athletes to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */ 
    public void AddAthleteMale(string Team, string Fname, string Lname)
    {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Mens 500m Speed Skating', '" +
                        Team + "', '" + Fname + "', '" + Lname + "', '12:00pm', 'Monday', 'Rink 1');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"ss500m Times Men\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + Team + "');");
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
    /** Void function adds female to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */ 
    public void AddAthleteFemale(string country, string Fname, string Lname)
    {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Womens 500m Speed Skating', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '12:00pm', 'Monday', 'Rink 2');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                             //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"ss500m Times Women\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
    //! Scoring class manages the official scores/times recorded by the judges
    /*! DEFINTION: The act of taking the judges scores that are given to the athlete 
	 *             or pair of athletes at their respective event.
	 * 
     *  CONSTRAINTS: NONE
	 */
    /** @author Landen Marchand
	*/
    public class Scoring
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Scoring()
        {
        }
        /** Sets and gets judge's score
		    @param double for judge's score
		    @return double of judge's score
		*/
        public double score { get; set; }
    /** Void function enters the time per athlete at hand
        @param string for time entry
        @param string for particular event time derived from
        @param string for first name of athlete
        @param string for last name of athlete
    */
        public void EnterTime(string entry, string selectedEvent, string Fname, string Lname)
        {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                           //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry from event to the specific event
                    string sql = String.Format("UPDATE \"" + selectedEvent + "\" SET Times = " + entry +
                    " WHERE \"Athlete First Name\" = '" + Fname + "' AND \"Athlete Last Name\" = '" + Lname + "';");
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
        MessageBox.Show("Time has been entered into " + Fname + " " + Lname + "'s time");
    }
    /** Void function adds female to database for the event
         @param string for score entry
         @param string for particular event score derived from
         @param string for first name of athlete
         @param string for last name of athlete
    */
        public void EnterScore(double entry, string selectedEvent, string Fname, string Lname)
        {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                           //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry from event to the specific event
                    string sql = String.Format("UPDATE \"" + selectedEvent + "\" SET Score = " + entry +
                    " WHERE \"Athlete First Name\" = '" + Fname + "' AND \"Athlete Last Name\" = '" + Lname + "';");
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
        MessageBox.Show("Score has been entered into " + Fname + " " + Lname + "'s score");
    }
    }
    //! SingleSkating class is one of the 3 FigureSkating events
    /*! DEFINITION: Form of figure skating where athletes participate individually. 
	 *              The utilization of long program style where each athlete is free 
	 *              to do their own unique performance complete with technical tricks 
	 *              is present.
	 * 
     *  CONSTRAINTS: Each athlete performs solo on the rink at a given time. 
     *               Total duration of performance is 4 minutes and 30 seconds.
	 */
    /** @author Landen Marchand
	*/
    public class SingleSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SingleSkating()
        {
        }
        /** Void function adds male to database for the event
            @param string for athlete's team name
            @param string for first name of athlete
            @param string for last name of athlete
		*/
        public void AddAthleteMale(string country, string Fname, string Lname)
        {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                           //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Single Skating Mens', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '11:00am', 'Monday', 'Rink 3');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"Single Skating Men Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
    /** Void function adds female to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */    
    public void AddAthleteFemale(string country, string Fname, string Lname)
    {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                           //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Single Skating Womens', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '11:00am', 'Monday', 'Rink 4');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"Single Skating Womens Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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
//! PairSkating class is one of the 3 FigureSkating events
/*! DEFINITION: Form of figure skating where athletes participate individually.
 *              The utilization of long program style where each athlete is free
 *              to do their own unique performance complete with technical tricks is present.
 * 
 *  CONSTRAINTS: Each athlete performs solo on the rink at a given time. 
 *               Total duration of performance is 4 minutes and 30 seconds.
 */
/** @author Landen Marchand
*/
public class PairSkating
{
    /** Void function adds an athlete to database for the event
        @param string for athlete's team name
        @param string for first name of athlete
        @param string for last name of athlete
    */
    public void AddAthlete(string country, string Fname, string Lname)
    {
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
                con.Open(); //!< Opens DB
                           //!< Checks connection and fills grid view with Race table
                if (con.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO Events ('Event Name', 'Team Name', 'Athlete First Name'," +
                        "'Athlete Last Name', 'Event_Time', 'Event Day', 'Rink') VALUES('Couple Skating', '" +
                        country + "', '" + Fname + "', '" + Lname + "', '5:00pm', 'Tuesday', 'Rink 3');");
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
        //!< Creates variable for connection string
        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
        {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conn))
            {
                conn.Open(); //!< Opens DB
                            //!< Checks connection and fills grid view with Race table
                if (conn.State == ConnectionState.Open)
                {
                    //!< Adds entry to athlete information
                    string sql = String.Format("INSERT INTO \"Pair Skating Scores\" ('Athlete First Name', 'Athlete Last Name', " +
                        "'Team Name') VALUES('" + Fname + "', '" + Lname + "', '" + country + "');");
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

    //! Team class to house the team name
    /*! DEFINITION: Represents each country in the Winter Olympics.
	 * 
     *  CONSTRAINTS: There must be the same amount of males as females in a team. 
     *               There is to only be one country per team.
	 */
    /** @author Landen Marchand
	*/
    class Team
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Team()
        {
        }
        /** Sets and gets team's name, which is their country's name
		    @param string for team name
		    @return string of team name
		*/
        public string countryName { get; set; }
        /** Function to add a team to be officially registered
		 	@param string for the Team's name (which is country name)
		*/
        public void AddTeam(string TeamName)
        {
            //!< Impeded sql statement to insert value into database
            string InsertDB = "INSERT INTO 'Team Information' ('TeamName') VALUES('" + TeamName + "');";
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open(); //!< Opens DB

                    if (con.State == ConnectionState.Open) //!< If connection, open was successful
                    {
                        //!< This sends sql commands to database
                        DataSet ds = new DataSet();
                        var da = new SQLiteDataAdapter(InsertDB, con);
                        da.Fill(ds);
                    }
                    else
                    {
                        MessageBox.Show("Connection failed.");
                    }

                }
                con.Close();
                MessageBox.Show(TeamName + " has been added to database!");
            }
        }
    /** Function to delete a team to be officially deregistered
        @param string for the Team's name (which is country name)
    */
    public void DeleteTeam(string TeamName)
        {
            //!< Impeded sql statement to delete value from database
            string DeleteDB = "DELETE FROM 'team information' WHERE TeamName = '" + TeamName + "';";
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open(); //!< Opens DB

                    if (con.State == ConnectionState.Open) //!< If connection, open was successful
                    {
                        //!< This sends sql commands to database
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
                MessageBox.Show(TeamName + " has been removed from database!");
            }
        }

    }