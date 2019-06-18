#include <stdio.h>
#include <string.h>

int fun1 (char *arg)
{
	char buffer[1024];
	strcpy(buffer, arg);
}

void main (int argc, char *argv[])
{
	fun1(argv[1]);
}
