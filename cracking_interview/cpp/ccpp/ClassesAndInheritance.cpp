#include <iostream>
#include <string>

#define NAME_SIZE 50 

class Person {
	int id;
	char names[NAME_SIZE];

public:
	// Person(int a) : id(a) {}
	// ~Person() {}
	virtual void aboutMe() {
		std::cout << "I am a person." <<std::endl;
	}
	virtual bool addCourse(std::string s) = 0;
};

class Student : public Person {
public:
	void aboutMe() {
		std::cout << "I am a student" << std::endl; 
	}
	bool addCourse(std::string s) {
		std::cout << "Added course " << s << " to student." << std::endl;
		return true;
	}
};

int main() {
	Student * s = new Student();
	Person * p = new Student();
	s->aboutMe();
	p->aboutMe();
	p->addCourse("History");
	delete s;
	delete p;
	return 0;
}
