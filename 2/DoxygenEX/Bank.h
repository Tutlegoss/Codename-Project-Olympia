/*FILE: Bank.h
 *CLASS PROVIDED: Bank
 *
 * CONSTRUCTORS for the Bank class:
 *  Bank()
 *    Postcondition: ID initialized to 1000, phone/fax have been given 0 values
 *  Bank(int bank_ID,Contact phone,Contact fax)
 *    Postcondition: ID set between (1000 - 9999) inclusive, phone/fax have 
 *                   values set such that areaCode is between (100-999), 
 *                   prefixNum is between (100-999) inclusive, and suffix 
 *                   is between (1000-9999) inclusive.
 *
 * CONSTANT MEMBER FUNCTIONS for the Bank class:
 *  void display()
 *    Preconditon: bank_ID, phone, and fax are all set to corresponding values
 *    Postcondition: bank_ID, phone, and fax outputted to user
 *
 * *NOTE* see Contact.h documentation as to why above needs to be true
 *
 * VALUE SEMANTICS for the Date class:
 *	Assignments and the copy constructor may be used with Card objects 
 */

#ifndef BANK_H
#define BANK_H
#include "Contact.h" //Need because constructor arguments are objects of
                     //this class, which leads to private members of this class
class Bank
{
	public:
		Bank();
		Bank(int ID, Contact phoneNum, Contact faxNum);
		void display();
	private:
		int bank_ID; //4 digit int
		Contact phone; //object 3 int pieces ###,###,####
		Contact fax; //object 3 int pieces ###,###,####
};
#endif
