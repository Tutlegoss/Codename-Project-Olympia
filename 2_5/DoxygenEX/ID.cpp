//FILE ID.cpp
//CLASS IMPLEMENTED: ID (See ID.h for documentation)

#include <iostream>
#include <cassert>
#include "ID.h"

	ID::ID()
	{ //If I do not initialize to something, it defaults to big numbers
		left=0;
		middle=0;
		right=0;
	}

	ID::ID(int l,int m,int r)
	{
		left = l;
		assert(left>99 && left<1000);
		middle = m;
		assert(middle>9 && middle<100);
		right = r;
		assert(right>999 && right<10000);
	}

	void ID::display()
	{
		std::cout<< "Here is your Loan ID: "
			     <<left<<"-"<<middle<<"-"<<right<<std::endl;
	}

