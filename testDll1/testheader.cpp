#include "pch.h"
#include "testheader.h"

void Strcat(const char* str1, const char* str2, char* newstr)
{
	string str = string(str1) + string(str2);
	strcpy_s(newstr, sizeof(newstr), str.c_str());
}

void Strcpy(char* str1, char* str2)
{
	strcpy_s(str1, sizeof(str1), str2);
}

void pipecommand(const char* strCmd)
{
	std::array<char, 80> buffer;
	FILE* pipe = _popen(strCmd, "r");
	if (!pipe)
	{
		std::cerr << "cannot open pipe for reading" << endl;
	}
	int c = 0;
	while (fgets(buffer.data(), 80, pipe) != NULL)
	{
		c++;
		std::cout << c << "\t" << buffer.data();
	}
	_pclose(pipe);
}

void Saysomething(const char* str)
{
	std::cout << "I typed: " << str << endl;
}

int add(int a, int b)
{
	return a + b;
}