#include <string.h>
#include <stdlib.h>

char *reverse(char *input) {
	int len = strlen(input);
	char output[len];
	for (int i=0; i<len; i++) {
		output[len-i-1] = input[i];
	}
	return output;
}

int main (int argc, char *argv[]) {
	char input[] = "test string";
	char *output = malloc(sizeof(char)*strlen(input));
	char output[] = reverse(input);
	printf("%s\n", output);
}
