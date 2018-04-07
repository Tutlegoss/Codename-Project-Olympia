using System;
using System.Collections.Generic;

namespace PCO
{
	//! Rink class is the physical area in which events are held
	/*! DEFINITION: The location of each event determined by the schedule.
	 * 
     *  CONSTRAINTS: May only be occupied by one event at any given time. 
     *               Must be in operation concurrent with the other rinks.
	 */
	/** @author Andrew Unger
	*/
	public class Rink
	{
		/** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/	
		public Rink ()
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
		/** Function to add an event to the rink
		 	@param Event
		 	@return List<Event> updated
		*/
		public List<Event> addEvent()
		{
			List<Event> temp = new List<Event> ();
			return temp;
		}
		/** Function to delete an event to the rink
		 	@param Event
		 	@return List<Event> updated
		*/
		public List<Event> deleteEvent()
		{
			List<Event> temp = new List<Event> ();
			return temp;
		}

		private List<Event> uniqueEvents;
	}
}

