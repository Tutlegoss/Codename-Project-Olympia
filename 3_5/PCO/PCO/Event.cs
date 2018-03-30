using System;
using System.Collections.Generic;

namespace PCO
{
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
		public Event ()
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
		public abstract void runEvent (List<Judge> j, List<Team> t);
		/** Inheritance member function for SpeedSkating and FigureSkating events
		 	Juges/Teams to be scheduled for future events
		 	@param List<Judge> List of judges for event
		 	@param List<Team> List of teams for event
		 	@return non
		*/
		public abstract void schedEvent (List<Judge> j, List<Team> t);
		/** Inheritance member function for SpeedSkating and FigureSkating events
		/** Interface so SpeedSkating and FigureSkating events can utilize inherited functions
		*/ 
		public interface eventInheritance
		{
			int eventNum();
			void runEvent (List<Judge> j, List<Team> t);
			void schedEvent (List<Judge> j, List<Team> t);
		}

		/**
		 
        */
		public Schedule scheduleOfEvent { get; set; }

	}
}

