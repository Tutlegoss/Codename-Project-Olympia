using System;
using System.Collections.Generic;

namespace PCO
{
	//! PairSkating class is one of the 3 FigureSkating events
	/*! DEFINITION: Form of figure skating where athletes participate in male/female 
	 *              pairs. The utilization of long program style where each athlete 
	 *              is free to do their own unique performance complete with technical
	 *              tricks is present.
	 * 
     *  CONSTRAINTS: The pairs are male female. Each pair performs solo on the rink at 
     *               a given time. Total duration of performance is 4 mintues and 30 seconds.
	 */
	/** @author Landen Marchand
	*/
	public class PairSkating : FigureSkating
	{
		/** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/	
		public PairSkating ()
		{
		}
		/** Function to override inherited fsScore() function
		*/
		public override double fsScore ()
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

