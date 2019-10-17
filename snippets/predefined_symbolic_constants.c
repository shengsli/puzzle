#include <stdio.h>

int main (int argc, char *argv[]) {
	printf("line %d\n", __LINE__);
	printf("%s\n", __FILE__);
	printf("%s %s\n", __DATE__, __TIME__);
}
