# Makefile Example

# Makefile "variables", occurrences of ${CXX} are replaced with g++
CXX = g++
CXXFLAGS = -Wall

#----------------------------------------------------------------------------
# Link, make shapes executable

#target:	file_1_it_needs file_2_it_needs  #called dependencies
#	rule_to_make_dependencies
#thg:    Thing.o Thing_driver.o 
#	${CXX} ${CXXFLAGS} Thing_driver.o Thing.o -o thg 

# Compile Thing.cpp 
Thing.o:	Thing.h Thing.cpp 
	${CXX} ${CXXFLAGS} -c Thing.cpp

#List here the other compilations. Mimic Compile Thing.cpp

#----------------------------------------------------------------------------
clean:
#	rm -f thg  # remove the executable if thg produced
	rm -f *.o  # remove ALL object files in the directory
