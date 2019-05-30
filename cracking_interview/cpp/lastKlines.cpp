/**
 * print the last K lines of an input file   
 */
#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

void printLast10Lines(char *filename)
{
	const int K=10;
	std::ifstream file (filename);
	std::string L[K];
	int size=0;

	while (file.peek()!=EOF)
	{
		getline(file, L[size%K]);
		size++;
	}

	int start = size > K ? (size%K) : 0;
	int count = std::min(K,size);

	for (int i=0; i<count; i++)
	{
		std::cout << L[(size+i)%K] << std::endl;
	}
}

int main(int argc, char *argv[])
{
	if (argc>2)
	{
		std::cout << "Error: invalid number of arguments." << std::endl;
		return -1;
	}
	std::string filename;
	if (argc==1) filename = "lastKlines.cpp";
	else if (argc==2) filename = argv[1];

	char *filename_cstr = new char[filename.size()+1];
	strcpy(filename_cstr, filename.c_str());
    printLast10Lines(filename_cstr);
    return 0;
}
