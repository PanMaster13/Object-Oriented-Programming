#pragma once

#include <iostream>
#include "clsStudent.h"
#include <string>

using namespace std;

class clsPostgraduate : public clsStudent {
private:
	string _researchTitle;
	int _grant;

public:
	clsPostgraduate(string n, string sn, string program, string rt, int g);
	int getGrant();
	void displayStudentDetails();
};