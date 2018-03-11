//! A Brief Desc?

/*! FILE: Loan.h
 * CLASS PROVIDED: Loan
 *
 * CONSTRUCTORS for the Loan class:
 *  Loan()
 *    Postcondition: Bank, id, amount, rate, term are all set to zero
 *  Loan(Bank b, ID id, float amount, float rate, int term)
 *    Postcondition:  bank is set per the Bank criteria, id is set
 *					  per the ID
 *
 * MODIFICATION MEMBER FUNCTIONS for the Loan class:
 *  void set()
 *    Postcondition: bank, id, amount, rate, term are all set to
 *                   legal terms as per the documentation for the 
 *                   respective classes by the user.
 *
 * CONSTANT MEMBER FUNCTIONS for the Loan class:
 *  void display()
 *    Precondition: bank, id, amount, rate, term have been set to
 *                  legal terms as per the documentation for the
 *                  respective classes.
 *    Postcondition: All values across all classes are out putted
 *                   to the screen for the user to see
 *
 * *NOTE* see Contact.h documentation as to why above needs to be true
 *
 * VALUE SEMANTICS for the Date class:
 *	Assignments and the copy constructor may be used with Card objects 
 *
 */


#ifndef LOAN_H
#define LOAN_H
#include "Bank.h"
#include "ID.h"
class Loan

	/** @author Landen Marchand
	 */
{
	public:
		/** Searches whatever
		    @param  Name of an item wer are seeing
			@return What the hell this is
		*/
		Loan();
		Loan(Bank b, ID id, float amount, float rate, int term);
		void set(); //!< TEST diz This function sets the amounts.
		void display(); //!< a member function.
	private:
		Bank bank; 
		ID id; /*!< Assume unique int in 3 int parts */
		float amount; /*!< $ amount of the loan */
		float rate; /*!< Annual interest rate */
		int term; //# of months, length of the loan
};
#endif
