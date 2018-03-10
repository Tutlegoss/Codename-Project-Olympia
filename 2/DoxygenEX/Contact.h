/*FILE: Contact.h
*CLASS PROVIDED: Contact
*
**NOTE* - Reason for boundaries is because integers do not print leading
*         zeroes, so the smallest integer has to be 100
*
*CONSTRUCTORS for the Contact class:
* Contact()
*   Postcondition: areaCode, prefixNum, suffixNum all set to zero
*
* Contact(int area, int prefix, int suffix)
*   Postcondition: areaCode set between (100-999) inclusive, 
*                  prefixNum set between (100-999) inclusive,
*                  suffixNum set between (1000-9999) inclusive
*
*MODIFICATION MEMBER FUNCTIONS for the Contact class:
* void setArea(int area)
*   Precondition: area has been given a value between 100-999
*   Postcondition: areaCode has been assigned a value between 100-999
*
* void setPrefix(int prefix)
*   Precondition: prefix has been given a value between 100-999
*   Postcondition: prefixNum has been assigned a value between 100-999
*
* void setSuffix(int suffix)
*   Precondition: suffix has been given a value between 100-9999
*   Postcondition: suffixNum has been assigned a value between 100-9999
*
*CONSTANT MEMBER FUNCTIONS for the Contact class:
* int getArea()
*   Postcondition: Value in areaCode is returned
*
* int getPrefix()
*   Postcondition: Value in prefixNum is returned
*
* int getSuffix()
*   Postcondition: Value in suffixNum is returneda
*
* void display()
*   Precondition: Proper values given to areaCode, prefixNum, suffixNum
*   Postcondition: Values are outputted to the user
*
*VALUE SEMANTICS for the Contact class:
*	Assignments and the copy constructor may be used with Contact objects
*/	

#ifndef CONTACT_H
#define CONTACT_H
class Contact
{
	public:
		Contact();
		Contact(int area, int prefix, int suffix);
		void setArea(int area);
		void setPrefix(int prefix);
		void setSuffix(int suffix);
		int getArea();
		int getPrefix();
		int getSuffix();
		void display();
	private:
		int areaCode;
		int prefixNum;
		int suffixNum;
};
#endif

