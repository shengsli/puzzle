#include <stdio.h>
int main () {
	int counter = 0;
	unsigned char num = 200;
	for (unsigned char i = 0; i < 2 * num; ++i) {//i interger overflow
		printf("i = %d.\n", i);
		counter++;
		printf("%d\n", counter);
	}
	/* char *a[2] = {"hello", "hi"}; */
	/* printf("%s", *(a+1)); */
	/* return 0; */
}
