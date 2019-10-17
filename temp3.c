int main () {
	int a = 0x2019ABCD;
	char c = *(char*) &a;
	printf("%c", c);
}
