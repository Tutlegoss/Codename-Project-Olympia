using System;
using System.Collections.Generic;

namespace PCO
{
	//! FigureSkating class is the superclass of the 3 FigureSkating events
	/*! DEFINITION: Skating done on ice in synchronization with music that is scored 
	 *              based upon technical tricks and or the synchronization of each athlete 
	 *              in a pair. One of the two main sporting categories that consist of 
	 *              three unique events which athletes participate separately as well as in pairs.
	 * 
     *  CONSTRAINTS: None
	 */
	/** @author Andrew Unger
	*/
	public abstract class FigureSkating : Event 
	{
		/** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/	
		public FigureSkating ()
		{
		}
		/** Inheritance member function for FigureSkating events
		    @param none
		    @return double pertaining to scores (completion of event of athlete)
		*/
		public abstract double fsScore();
		//! FigureSkating inheritance for FigureSkating events
		/** Interface so FigureSkating events can utilize inherited functions
		*/ 
		protected interface fsInheritance
		{
			double fsScore();
		}

		protected double officialFSTime;
	}
}

