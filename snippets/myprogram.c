// C program to use the above created header file
#include <stdio.h>
#include "myheader.h"

int main (int argc, char *argv[]) {
    add(4, 6);
	
    /*This calls add function written in myhead.h
      and therefore no compilation error.*/
    multiply(5, 5);
  
    // Same for the multiply function in myhead.h
    printf("BYE!See you Soon");
    return 0;
}
