using System;
using System.Collections.Generic;

namespace PCO
{
	//! Scoring class manages the official scores/times recorded by the judges
	/*! DEFINTION: The act of taking the judges scores that are given to the athlete 
	 *             or pair of athletes at their respective event.
	 * 
     *  CONSTRAINTS: NONE
	 */
	/** @author Landen Marchand
	*/
	public class Scoring
	{
		/** Default Constructor Provided Automatically
		 	@param None
			@return Default Values
		*/	
		public Scoring ()
		{
		}
		/** Sets and gets judge's score
		    @param double for judge's score
		    @return double of judge's score
		*/
		public double score { get; set; }

		private double officialScore;

	}

}

