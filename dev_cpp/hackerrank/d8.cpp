#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <map>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int n;
    std::cin >> n;
    map<string,string> phonebook;
    for (int i=0; i<n; ++i)
    {
        string name,phoneNumber;
        cin >> name >> phoneNumber;
        phonebook[name]=phoneNumber;
    }

    for (int i=0; i<n; ++i)
    {
        string name;
        cin >> name;
        map<string,string>::iterator it = phonebook.find(name);
        if (it == phonebook.end()) cout << "Not found" << endl;
        else std::cout << name << "=" << phonebook[name] << std::endl;
    }

    return 0;
}

