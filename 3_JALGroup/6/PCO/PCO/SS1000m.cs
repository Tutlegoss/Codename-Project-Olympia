using System;
using System.Collections.Generic;

namespace PCO
{
	//! SS1000m is one of the 3 SpeedSkating events
	/*! DEFINTION: Form of speed skating where athletes utilize inline skates 
	 *             and race around a 400m rink 2.5 times. Whichever athlete crosses 
	 *             the finish line first has the lowest time.
	 * 
     *  CONSTRAINTS: A maximum of four athletes compete at a given time.
	 */
	/** @author Josh King
	*/
	class SS1000m : SpeedSkating
	{
		/** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/	
		public SS1000m ()
		{
		}
		/** Function to override inherited ssTime() function
		*/
		public override double ssTime ()
		{
			throw new NotImplementedException ();
		}
		/** Function to override inherited eventNum() function
		*/
		public override int eventNum()
		{
			throw new NotImplementedException ();
		}
		/** Function to override inherited runEvent(..) function
		*/ 
		public override void runEvent (List<Judge> j, List<Team> t)
		{
			throw new NotImplementedException ();
		}
		/** Function to override inherited schedEvent(..) function
		*/ 
		public override void schedEvent (List<Judge> j, List<Team> t)
		{
			throw new NotImplementedException ();
		}

	}
}
