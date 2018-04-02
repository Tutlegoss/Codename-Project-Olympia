using System;
using System.Collections.Generic;

namespace PCO
{
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
		public SpeedSkating ()
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
}

