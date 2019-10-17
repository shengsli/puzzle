#include <stdio.h>

class A {
public:
	virtual ~A() { printf("A"); }
};

class B: public A {
public:
	~B() { printf("B"); }
};

class C: public B, private A {
public:
	~C() { printf("C"); }
};

int main () {
	B* c = new C();
	delete(c);
}
