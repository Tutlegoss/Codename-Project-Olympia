using System;
using System.Collections.Generic;

namespace PCO
{
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
		public Judge ()
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
		/** Function to change the judge's schedule if needed
		 	@param none
		 	@return Schedule that is updated
        */
		public Schedule changeSchedule()
		{
			Schedule temp = new Schedule ();
			return temp;
		}
		/** Sets and gets the score for each event
		 	@param Scoring
		 	@return Scoring 
		*/ 	
		public Scoring judgeScore { get; set; }
		/** Function to change or delete a judge's score if necessary
		 	@param none
		 	@return Scoring
		*/
		public Scoring alterScore()
		{
			Scoring temp = new Scoring ();
			return temp;
		}
	}
}

