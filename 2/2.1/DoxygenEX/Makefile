# Makefile for Lab 1
# CS 23021 Separate Files Lab

# Makefile "variables", occurrences of ${CXX} are replaced with g++
CXX = g++
CXXFLAGS = -Wall

#----------------------------------------------------------------------------
# Link, make shapes executable

#target: (tab) file_1_it_needs (space) file_2_it_needs  #called dependencies
#(tab)  rule_to_make_dependencies
TestClass:    ID.o Bank.o Contact.o Loan.o MainDriver.o 
	${CXX} ${CXXFLAGS} ID.o Bank.o Contact.o MainDriver.o Loan.o -o TestClass


# Compile Contact.cpp 
Contact.o:     Contact.h Contact.cpp 
	${CXX} ${CXXFLAGS} -c Contact.cpp

# Compile ID.cpp 
ID.o:     ID.h ID.cpp 
	${CXX} ${CXXFLAGS} -c ID.cpp

# Compile Bank.cpp
Bank.o:   Bank.cpp Bank.h
	${CXX} ${CXXFLAGS} -c Bank.cpp

# Compile Loan.cpp 
Loan.o:   Loan.h Loan.cpp 
	${CXX} ${CXXFLAGS} -c Loan.cpp

# Compile MainDriver.cpp
MainDriver.o:   MainDriver.cpp
	${CXX} ${CXXFLAGS} -c MainDriver.cpp

#----------------------------------------------------------------------------
clean:
	rm -f TestClass  # remove the executable avg file
	rm -f *.o  # remove ALL object files in the directory

