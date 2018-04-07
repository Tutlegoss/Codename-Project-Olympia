using System;
using System.Collections.Generic;

namespace PCO
{
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
		public Team ()
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
		public int teamSize()
		{
			return 499;
		}
		/** Adds an athlete to a respective team
		 	@param none
			@return none
		*/
		public void addAthlete()
		{
		}
		/** Deletes an athlete from a respective team
		    @param none
		    @return none
		*/
		public void deleteAthlete()
		{
		}

		private int currentSize;
	}
}

