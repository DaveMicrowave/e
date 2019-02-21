// ConsoleApplication7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#import "ClassLibrary7.tlb" raw_interfaces_only

int wmain()
{
	CoInitialize(0);
	BSTR successMsg;
	BSTR tobe = ::SysAllocString(L"File has been yeeted");

	ClassLibrary7::_Class1Ptr obj(__uuidof(ClassLibrary7::Class1));
	HRESULT hResult = obj->WriteFiles(tobe, &successMsg);

	std::wcout << "Write " << std::endl;
	std::wcout << successMsg << std::endl;

	return 0;
}

