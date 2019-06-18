/**
 * palindrome.cpp
 * \author: sheng
 * find the longest palindromic substring 
 * time:  O(n^2)
 * space: O(1)
 */
#include <cstdio>
#include <iostream>
#include <string>
#include <cstring>

void print_substr(char *str, int lo, int hi)
{
	for (int i=lo; i<=hi; ++i)
		printf("%c", str[i]);
}

int longest_palstr(char *str)
{
	int maxlen = 1;
	int start = 0;
	int len = strlen(str);
	int lo = 0, hi = 0;
	for (int i=1; i<len; ++i)
	{
		/* find the longest even palindromic string */
		lo=i-1;
		hi=i;
		while (lo >= 0 && hi < len && str[lo]==str[hi])
		{
			if (hi-lo+1 > maxlen)
			{
				start = lo;
				maxlen = hi-lo+1;
			}
			--lo;
			++hi;
		}
		
		/* find the longest odd palindromic string */
		lo=i-1;
		hi=i+1;
		while (lo >= 0 && hi < len && str[lo]==str[hi])
		{
			if (hi-lo+1 > maxlen)
			{
				start = lo;
				maxlen = hi-lo+1;
			}
			--lo;
			++hi;
		}
	}

	std::cout << "longest palidromic string is ";
	print_substr(str, start, start+maxlen-1);
	std::cout << std::endl;
	return maxlen;
}

int main ()
{
	char str[] = "forgeeksskeegfor";
	std::string s(str);
	std::cout << "find the longest palidromic string from " << s << std::endl
			  << "max length is " << longest_palstr(str) << std::endl;
}
