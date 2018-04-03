using System;
using System.Collections.Generic;

namespace PCO
{
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
		public Schedule ()
		{
		}
		/** Function to obtain a schedule list<Tuple<int,int>> where each int is unix time
		    \*\*JUST ACCEPT THIS AND IT WILL COME TO FRUITION LATER**
		    @param List<Tuple<int,int>> something with unix time
		    @return List<Tuple<int,int>> something with unix time
		*/
		public List<Tuple<int,int>> eventScheduler { get; set; }

	}
}

