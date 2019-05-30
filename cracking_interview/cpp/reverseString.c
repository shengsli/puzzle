/**
 * reverse null terminated string  
 */

#include <stdio.h>
#include <string.h>

void reverse(char *str)
{
	char *end = str;
	char tmp;
	if (str)
	{
		while (*end) /* find end of the string */
			++end;
		--end; /* set one char back, since last char is null */

		while (str < end)
		{
			tmp = *str;
			*str++ = *end;
			*end-- = tmp;
		}
	}
}

int main(int argc, char *argv[])
{
	/* if (argc != 2) */
	/* { */
	/* 	printf("Error: invliad number of arguments.\n"); */
	/* 	return -1; */
	/* } */

	char *str = "soltuion";
	reverse(str);

	int i;
	for (i=0; i<3; i++)
	{
		printf("%c",*(str+i));
	}
	
    return 0;
}
