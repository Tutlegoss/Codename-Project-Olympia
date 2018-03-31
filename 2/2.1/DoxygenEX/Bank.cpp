//FILE: Bank.cpp
//CLASS IMPLEMENTED: Bank (See Bank.h for documentation)

#include<iostream>
#include"Bank.h"

Bank::Bank()
{ //Minimum default settings
	bank_ID = 1000;
	phone = Contact(100,100,1000);
	fax = Contact(100,100,1000);
}

Bank::Bank(int ID,Contact phoneNum,Contact faxNum)
{ //Settings per the driver test
	bank_ID = ID;
	phone = phoneNum;
	fax = faxNum;
}

void Bank::display() 
{
	std::cout<<"Here is your bank ID: "<<bank_ID<<std::endl;
	std::cout<<"Here is your phone number: ";
	std::cout<<phone.getArea()<<"-"<<phone.getPrefix()<<"-"<<
		       phone.getSuffix()<<std::endl;
	std::cout<<"Here is your fax number: ";
	std::cout<<fax.getArea()<<"-"<<fax.getPrefix()<<"-"<<
		       fax.getSuffix()<<std::endl;
}
