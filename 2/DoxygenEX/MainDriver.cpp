//FILE - MainDriver.cpp - Driver file to test the classes Loan,
//       ID, Contact, and Bank

#include<iostream>
#include "Bank.h"
#include "Contact.h"
#include "ID.h"
#include "Loan.h"

using namespace std;

int main()
{	
//TEST CASES for the class Contact
	//CONSTRUCTORS
	Contact contact1;
	Contact contact2(333,555,8888);
	contact1.display();
	contact2.display();
	//CONSTANT MEMBER FUNCTIONS
	Contact contact3(999,999,9999); //Boundary upper
	int areaCode;
	areaCode = contact3.getArea();
	cout<<"AREA CODE TEST: "<<areaCode<<endl;

	Contact contact4(100,100,1000); //Boundary lower
	int prefixNum;
	prefixNum = contact4.getPrefix();
	cout<<"PREFIX TEST: "<<prefixNum<<endl;

	Contact contact5(723,239,8712); //Random
	int suffixNum;
	suffixNum = contact5.getSuffix();
	cout<<"SUFFIX TEST: "<<suffixNum<<endl<<endl;

	contact3.display();
	contact4.display();
	contact5.display();
	//MODIFIER MEMBER FUNCTIONS
	{
		Contact contact6; //Boundary upper for functions
		int a=999,p=999,s=9999;
		contact6.setArea(a);
		contact6.setPrefix(p);
		contact6.setSuffix(s);
		contact6.display();
	}

	{
		Contact contact7; //Boundary lower for functions
		int a=100,p=100,s=1000;
		contact7.setArea(a);
		contact7.setPrefix(p);
		contact7.setSuffix(s);
		contact7.display();
	}

	{
		Contact contact8; //Random
		int a=123,p=833,s=3409;
		contact8.setArea(a);
		contact8.setPrefix(p);
		contact8.setSuffix(s);
		contact8.display();
	}

//TEST CASES for class ID
	//CONSTRUCTORS with CONSTANT MEMBER FUNCTION
	ID id1; //Default
	ID id2(100,10,1000); //Boundary lower
	ID id3(999,99,9999); //Boundary upper
	ID id4(234,64,3498); //Random
	cout<<"ID CLASS TESTS:\n";
	cout<<"DEFAULT: ";
	id1.display();
	cout<<"\nLOWER BOUND: ";
	id2.display();
	cout<<"\nUPPER BOUND: ";
	id3.display();
	cout<<"\nRANDOM: ";
	id4.display();
	cout<<endl<<endl;

//TEST CASES for class Bank
	//CONSTRUCTORS with CONSTANT MEMBER FUNCTION
	Bank bank1;
	Bank bank2(1000, contact3, contact4);
	cout<<"BANK CLASS TESTS:\n";
	cout<<"DEFAULT: ";
	bank1.display();
	cout<<"\nPARAMETER CONSTRUCTOR with UPPER/LOWER BOUND CONTACTS:\n";
	bank2.display();
	cout<<endl<<endl;

//TEST CASES for class Loan
	//CONSTRUCTORS with CONSTANT MEMBER FUNCTION
	Loan loan1;
	Loan loan2(bank2, id4, 5220, 5.5, 12);
	cout<<"LOAN CLASS TESTS:\n";
	//Default constructor is left empty, so values assigned are random
	//but they are initialized to something before being overridden later
	cout<<"DEFAULT: *NOTE* DEFAULT VALUES ONLY RANDOM PLACEHOLDERS!!!";
	loan1.display();
	cout<<"\nPARAMETER CONSTRUCTOR:\n";
	loan2.display();
	cout<<endl;
	//MODIFICATION FUNCTION
	Loan loan3;
	loan3.set();
	loan3.display();
	cout<<endl;

	return 0;
}
