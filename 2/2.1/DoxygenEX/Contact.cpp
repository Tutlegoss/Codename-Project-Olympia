//FILE - Contact.cpp
//CLASS IMPLEMENTED: Contact (See Contact.h for documentation)
#include <iostream>
#include <cstdlib>
#include "Contact.h"
#include "Bank.h"

Contact::Contact()
{
	areaCode=100;
	prefixNum=100;
	suffixNum=1000;
}

Contact::Contact(int area, int prefix, int suffix)
{
	setArea(area);
	setPrefix(prefix);
	setSuffix(suffix);
}

void Contact::setArea(int area)
{
	if(area<100||area>999)
	{
		std::cout<<"Invalid Area Code\n";
		exit(1);
	}
	areaCode=area;
}

void Contact::setPrefix(int prefix)
{
	if(prefix<100||prefix>999)
	{
		std::cout<<"Invalid Prefix Digits\n";
		exit(1);
	}
	prefixNum=prefix;
}

void Contact::setSuffix(int suffix)
{
	if(suffix<1000||suffix>9999)
	{
		std::cout<<"Invalid Suffix Digits\n";
		exit(1);
	}
	suffixNum=suffix;
}

int Contact::getArea()
{
	return areaCode;
}

int Contact::getPrefix()
{
	return prefixNum;
}

int Contact::getSuffix()
{
	return suffixNum;
}

void Contact::display()
{
	std::cout<<"The phone number on file is:\n";
	std::cout<<areaCode<<"-"<<prefixNum<<"-"<<suffixNum<<std::endl;
	std::cout<<"The fax number on file is:\n";
	std::cout<<areaCode<<"-"<<prefixNum<<"-"<<suffixNum<<"\n\n";
}
