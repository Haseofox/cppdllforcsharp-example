#ifndef TESTHEADER_H
#define TESTHEADER_H

#include <string>
#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <array>

using namespace std;

#ifdef __cplusplus
	extern "C" {
#endif

#ifdef BUILD_DLL
	#define TESTHEADER __declspec(dllexport)
#else
	#define TESTHEADER __declspec(dllimport)
#endif // 

void TESTHEADER Strcat(const char* str1, const char* str2, char* newstr);
void TESTHEADER Strcpy(char* str1, char* str2);
int TESTHEADER add(int a, int b);
void TESTHEADER pipecommand(const char* strCmd);
void TESTHEADER Saysomething(const char* str);

#ifdef __cplusplus
}
#endif

#endif // !TESTHEADER_H

