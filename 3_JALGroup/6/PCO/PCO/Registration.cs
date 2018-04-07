using System;
using System.Collections.Generic;

namespace PCO
{
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
		public Registration ()
		{

		}
		/** Officially enters a team into the Winter Olympics
		 	\*\*NOTE: THIS WILL BE MODIFIED AFTER MORE INFO IS OBTAINED**
		    @param none
		    @return List<Team> which is the official list of all teams
		                       and their athletes
		*/
		public List<Team> registerTeam()
		{
			List<Team> temp = new List<Team>();
			return temp;
		}
		/** Officially deregisteres an entire team from the Winter Olympics
		 	@none
			@List<Team> that is updated and contains one less team
		*/
		public List<Team> deregisterTeam()
		{
			List<Team> temp = new List<Team>();
			return temp;
		}

		private List<Team> winterOlympicsTeams;
	}
}

