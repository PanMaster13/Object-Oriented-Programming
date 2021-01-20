#pragma once

#include <iostream>
#include <string>

using namespace std;

class clsStudent {
protected:
	string _name;
	string _student_number;
	string _program;

public:
	clsStudent(string n, string sn, string program);
	virtual void displayStudentDetails();
};