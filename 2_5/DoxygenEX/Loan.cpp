//FILE: Loan.cpp
//CLASS IMPLEMENTED: Loan (See Loan.h for documentation)

#include "Loan.h"
#include "Bank.h"
#include "ID.h" 
#include <iostream>
#include <cassert> //ASSERTS express numerical boundaries!
using namespace std;

Loan::Loan( ) 
{

} 

Loan::Loan(Bank b, ID I, float am, float rt, int trm) 
{ 
	bank = b; //Added to include Bank object for Loan
	id = I; 
	amount = am; 
	rate = rt; 
	term = trm; 
} 

void Loan::set( ) 
{ 
	//New questions for user to set bank values
	//Temporary variables to set these vales
	int idBank;
	int areaPhone, prefixPhone, suffixPhone;
	int areaFax, prefixFax, suffixFax;

	cout<<"Enter the 4- digit ID of the bank account\n";
	cin>>idBank;
	assert(idBank>999 && idBank<10000);

	cout<<"Enter the area code of your phone number\n";
	cin>>areaPhone;
	assert(areaPhone>99 && areaPhone<1000);

	cout<<"Enter the prefix of your phone number\n";
	cin>>prefixPhone;
	assert(prefixPhone>99 && prefixPhone<1000);

	cout<<"Enter the suffix of your phone number\n";
	cin>>suffixPhone;
	assert(suffixPhone>999 && suffixPhone<10000);
	
	cout<<"Enter the area code of your fax number\n";
	cin>>areaFax;
	assert(areaFax>99 && areaFax<1000);

	cout<<"Enter the prefix of your fax number\n";
	cin>>prefixFax;
	assert(prefixFax>99 && prefixFax<1000);

	cout<<"Enter the suffix of your fax number\n";
	cin>>suffixFax;
	assert(suffixFax>999 && suffixFax<10000);

	//Put the values into the bank object of class Loan
	bank = Bank(idBank, Contact(areaPhone, prefixPhone, suffixPhone),
			Contact(areaFax, prefixFax, suffixFax));

	int l, m, r;  
	cout << "Enter the 3-digit left part of the loan ID \n"; 
	cin >> l; 
	assert(l>99 && l<1000);

	cout << "Enter the 2-digit middle part of the loan ID \n"; 
	cin >> m; 
	assert(m>9 && m<100);

	cout << "Enter the 4-digit right part of the loan ID \n"; 
	cin >> r; 
	assert(r>999 && r<10000);

	id = ID(l, m, r); 

	cout << "Enter the amount of this loan \n"; 
	cin >> amount; 

	cout << "Enter the annual interest rate of this loan (in %) \n"; 
	cin >> rate; 

	cout << "Enter the term (number of months, length of the loan) \n"; 
	cin >> term; 
}

void Loan::display() 
{ 
	bank.display();
	id.display(); 
	cout << "Here is your Loan amount: " << amount << endl; 
	cout << "Here is your Loan rate: " << rate << endl; 
	cout << "Here is your Loan term: " << term << endl; 
} 
