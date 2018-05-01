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

namespace Project_Codename_Olympia_v1._0
{
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
        /** Sets and gets the schedule for each athlete
		 	@param Schedule 
		 	@return Schedule
		*/
        public Schedule setSchedule { get; set; }
        /** Sets and gets athlete's medal count for gold/silver/bronze
		 	@param Tuple<int,int,int>
		 	@return Tuple<int,int,int> Gold,Silver,Bronze ints
		*/
        public Tuple<int, int, int> medals { get; set; }

    }

    
	//! Schedule class is the organization of athletes and events
	/*! DEFINTION: The chronological listing of events over the course of two weeks. 
	 *             Scheduling implements where and when events are held. Schedule is 
	 *             also the organization of athletes placed into their respective events.
	 * 
     *  CONSTRAINTS: Must not organize events such that they happen concurrently on the 
     *               same rink. Must not allot more than the appropriate amount of athletes 
     *               per event. Must make sure any event is done as a pair contains one male 
     *               and one female athlete per team.
	 */
	/** @author Landen Marchand
	*/
	public class Schedule
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Schedule()
        {
        }
        /** Function to obtain a schedule list<Tuple<int,int>> where each int is unix time
		    \*\*JUST ACCEPT THIS AND IT WILL COME TO FRUITION LATER**
		    @param List<Tuple<int,int>> something with unix time
		    @return List<Tuple<int,int>> something with unix time
		*/
        public List<Tuple<int, int>> eventScheduler { get; set; }

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
    //! Event class is the superclass of all the 2 event types and 6 specific events
    /*! DEFINITION: The specific competition at a specified rink determined by the schedule.
	 * 
 	 *  CONSTRAINTS: Limited to the six official events of the Winter Olympics. Events will not 
 	 *               disturb those who are not registered for that specific event. Expunges the 
 	 *               highest and lowest scores an individual or pair receives. Total score is the 
 	 *               average of the remaining judges scores. Timed events utilize time as the score 
 	 *               which a judge verifies.
 	 */
    /** @author Landen Marchand
	*/
    public abstract class Event
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Event()
        {
        }
        /** Inheritance member function for SpeedSkating and FigureSkating events
		    Special identification number for unique event
		    @param none
		    @return int pertaining to event ID
		*/
        public abstract int eventNum();
        /** Inheritance member function for SpeedSkating and FigureSkating events
		    Judges/Teams to run specific event
		 	@param List<Judge> List of judges for event
		 	@param List<Team> List of teams for event
		 	@return none
		*/
        public abstract void runEvent(List<Judge> j, List<Team> t);
        /** Inheritance member function for SpeedSkating and FigureSkating events
		 	Juges/Teams to be scheduled for future events
		 	@param List<Judge> List of judges for event
		 	@param List<Team> List of teams for event
		 	@return none
		*/
        public abstract void schedEvent(List<Judge> j, List<Team> t);
        /** Inheritance member function for SpeedSkating and FigureSkating events
		/** Interface so SpeedSkating and FigureSkating events can utilize inherited functions
		*/
        public interface eventInheritance
        {
            int eventNum();
            void runEvent(List<Judge> j, List<Team> t);
            void schedEvent(List<Judge> j, List<Team> t);
        }
    }
    //! FigureSkating class is the superclass of the 3 FigureSkating events
    /*! DEFINITION: Skating done on ice in synchronization with music that is scored 
	 *              based upon technical tricks and or the synchronization of each athlete 
	 *              in a pair. One of the two main sporting categories that consist of 
	 *              three unique events which athletes participate separately as well as in pairs.
	 * 
     *  CONSTRAINTS: None
	 */
    /** @author Landen Marchand
	*/
    public abstract class FigureSkating : Event
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public FigureSkating()
        {
        }
        /** Inheritance member function for FigureSkating events
		    @param none
		    @return double pertaining to scores (completion of event of athlete)
		*/
        public abstract double fsScore();
        /** Interface so FigureSkating events can utilize inherited functions
		*/
        protected interface ssInheritance
        {
            double fsScore();
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
    public class IceDance : FigureSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public IceDance()
        {
        }
        /** Function to override inherited fsScore() function
		*/
        public override double fsScore()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited eventNum() function
		*/
        public override int eventNum()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited runEvent(..) function
		*/
        public override void runEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited schedEvent(..) function
		*/
        public override void schedEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
    }
    //! Judge class houses and disperses all the qualified judges
    /*! DEFINTION: A qualified person to score and assess each event. A judge 
	 *             is independent of all teams and free of any bias.
	 * 
     *  CONSTRAINTS: Provides a score ranging from 0 through 100 on scored events. 
     *               Verifies accurate timing on timed events. Remains corruption- 
     *               free and has no contact with athletes.
	 */
    /** @author Landen Marchand
	*/
    public class Judge
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Judge()
        {
        }
        /** Sets and gets judge's ID number
		    @param int for ID number
		    @return int ID number
		*/
        public int judgeID { get; set; }
        /** Sets and gets the schedule for each judge
		 	@param Schedule 
		 	@return Schedule
		*/
        public Schedule judgeSchedule { get; set; }
        /** Sets and gets the score for each event
		 	@param Scoring
		 	@return Scoring 
		*/
        public Scoring judgeScore { get; set; }
    }
    //! PairSkating class is one of the 3 FigureSkating events
    /*! DEFINITION: Form of figure skating where athletes participate in male/female 
	 *              pairs. The utilization of long program style where each athlete 
	 *              is free to do their own unique performance complete with technical
	 *              tricks is present.
	 * 
     *  CONSTRAINTS: The pairs are male female. Each pair performs solo on the rink at 
     *               a given time. Total duration of performance is 4 mintues and 30 seconds.
	 */
    /** @author Landen Marchand
	*/
    public class PairSkating : FigureSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public PairSkating()
        {
        }
        /** Function to override inherited fsScore() function
		*/
        public override double fsScore()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited eventNum() function
		*/
        public override int eventNum()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited runEvent(..) function
		*/
        public override void runEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited schedEvent(..) function
		*/
        public override void schedEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }

    }
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
        /** Officially enters a team into the Winter Olympics
		 	\*\*NOTE: THIS WILL BE MODIFIED AFTER MORE INFO IS OBTAINED**
		    @param none
		    @return List<Team> which is the official list of all teams
		                       and their athletes
		*/
        public void registerAthlete(string Fname, string Lname , string Gender, string team)
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
        public void deleteAthlete(string Fname, string Lname)
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
    //! Rink class is the physical area in which events are held
    /*! DEFINITION: The location of each event determined by the schedule.
	 * 
     *  CONSTRAINTS: May only be occupied by one event at any given time. 
     *               Must be in operation concurrent with the other rinks.
	 */
    /** @author Landen Marchand
	*/
    public class Rink
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public Rink()
        {
        }
        /** Function to obtain all the events that are held on a certain rink 
		    @param none
		    @return List<Event> which is the list of all events that are
		                        held on a particular rink
		*/
        public List<Event> rinkEvents()
        {
            List<Event> temp = new List<Event>();
            return temp;
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
    class SS1000m : SpeedSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SS1000m()
        {
        }
        /** Function to override inherited ssTime() function
		*/
        public override double ssTime()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited eventNum() function
		*/
        public override int eventNum()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited runEvent(..) function
		*/
        public override void runEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited schedEvent(..) function
		*/
        public override void schedEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
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
    class SS1500m : SpeedSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SS1500m()
        {
        }
        /** Function to override inherited ssTime() function
		*/
        public override double ssTime()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited eventNum() function
		*/
        public override int eventNum()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited runEvent(..) function
		*/
        public override void runEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited schedEvent(..) function
		*/
        public override void schedEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
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
    class SS500m : SpeedSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SS500m()
        {
        }
        /** Function to override inherited ssTime() function
		*/
        public override double ssTime()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited eventNum() function
		*/
        public override int eventNum()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited runEvent(..) function
		*/
        public override void runEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited schedEvent(..) function
		*/
        public override void schedEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
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
    public class SingleSkating : FigureSkating
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SingleSkating()
        {
        }
        /** Function to override inherited fsScore() function
		*/
        public override double fsScore()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited eventNum() function
		*/
        public override int eventNum()
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited runEvent(..) function
		*/
        public override void runEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
        /** Function to override inherited schedEvent(..) function
		*/
        public override void schedEvent(List<Judge> j, List<Team> t)
        {
            throw new NotImplementedException();
        }
    }
    //! SpeedSkating class is the superclass of the 3 SpeedSkating events
    /*! DEFINTION: Skating done on ice at a fast pace around an oval track 
	 *             utilizing inline skates where scoring is based upon time. 
	 *             One of the two main sporting categories that consist of three 
	 *             unique events which athletes participate separately.
	 * 
     *  CONSTRAINTS: None
	 */
    /** @author Landen Marchand
	*/
    public abstract class SpeedSkating : Event
    {
        /** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/
        public SpeedSkating()
        {

        }
        /** Inheritance member function for SpeedSkating events
		    @param none
		    @return double pertaining to time (completion of event of athlete)
		*/
        public abstract double ssTime();
        /** Inheritance member function for SpeedSkating events
		    @param none
		    @return int pertaining to event ID
		*/
        protected interface ssInheritance
        {
            double ssTime();
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
    public class Team
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
        /** Function to return current number of athletes in a specific team
		 	@param none
		 	@return int for number of athletes on the team
		*/
        public void AddTeam(string TeamName)
        {
            //impeded sql statement to insert value into database
            string InsertDB = "INSERT INTO 'Team Information' ('TeamName') VALUES('" + TeamName + "');";
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=OlympiaDB.sqlite"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();//opens DB

                    if (con.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        //this sends sql commands to database
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
            public void DeleteTeam(string TeamName)
            {
                //impeded sql statement to delete value from database
                string DeleteDB = "DELETE FROM 'team information' WHERE TeamName = '" + TeamName + "';";
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
                    MessageBox.Show(TeamName + " has been removed from database!");
                }
            }

        }
    }



