using System;
using System.Collections.Generic;

namespace PCO
{
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
		public Athlete ()
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
		public string lastName  { get; set; }
		/** Sets and gets athlete's gender
			@param string for gender
			@return string of gender
		*/
		public string gender    { get; set; }
		/** Sets and gets the schedule for each athlete
		 	@param Schedule 
		 	@return Schedule
		*/ 	
		public Schedule setSchedule { get; set; }
		/** Sets and gets athlete's medal count for gold/silver/bronze
		 	@param Tuple<int,int,int>
		 	@return Tuple<int,int,int> Gold,Silver,Bronze ints
		*/
		public Tuple<int,int,int> medals { get; set; }

	}
}

