/*FILE: ID.h
 *CLASS PROVIDED: ID
 *
 * CONSTRUCTORS for the ID class:
 *  ID()
 *    Postcondition: left, middle, right are all set to zero
 *  ID(int l, int m, int r)
 *    Postcondition:  left, middle, right are set to user's choice
 *                    with left between (100-999) inclusive, middle
 *                    between (10-99) inclusive, and right between
 *                    (1000-9999) inclusive
 *
 * CONSTANT MEMBER FUNCTIONS for the ID class:
 *  void display()
 *    Precondition: left, right, middle have been assigned legal values
 *
 *    Postcondition: left, right, middle are outputted to user
 *
 * VALUE SEMANTICS for the ID class:
 *	Assignments and the copy constructor may be used with ID objects 
 */

#ifndef ID_H
#define ID_H
#include <iostream>

class ID
{
	public:
		ID();
		ID(int l,int m,int r);
		void display();
	private:
		int left;
		int middle;
		int right;
};
#endif
