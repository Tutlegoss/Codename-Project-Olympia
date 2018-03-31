/*
   Thing.h

   Declaration file for the class Thing.

   
*/

#ifndef INCLUDED_THING_H
#define INCLUDED_THING_H

#include <list>
using namespace std;

/**
   List all the elements that are things

   @author Angela Guercio aguercio@kent.edu
*/
class Thing {
public:

     /**
	Searches the items to see if it is a thing.

	@param item Name of an item we are seeing if is a thing

	@return Whether the item is a thing
    */
    bool isItAThing(int item) const;

private:

    list<int> items;
};

#endif
