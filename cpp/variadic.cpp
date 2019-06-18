#include <iostream>
 
// Function that accepts no parameter
// It is to break the recursion chain of vardiac template function
void log()
{
}
 
template<typename T, typename ... Args>
void log(T first, Args ... args) {
	// Print the First Element
	std::cout<<first<<",";
	// Forward the remaining arguments
	log(args ...);
}
 
 
int main() {
	log(2, 3.4, "aaa");
	std::cout << std::endl;
	return 0;
}
