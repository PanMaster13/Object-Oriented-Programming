#pragma once

#include <iostream>
#include "clsStudent.h"
#include <string>

using namespace std;

class clsUndergraduate: public clsStudent {
private:
	string _major;

public:
	clsUndergraduate(string n, string sn, string program, string m);
	string getMajor();
	void displayStudentDetails();
};