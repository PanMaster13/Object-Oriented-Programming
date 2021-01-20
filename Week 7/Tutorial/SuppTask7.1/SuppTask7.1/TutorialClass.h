#pragma once

#include <iostream>
#include <vector>
#include "clsStudent.h"

using namespace std;

class TutorialClass {
private:
	vector<clsStudent*> _students;

public:
	void addStudent(clsStudent *std);
	int getStudentCount();
	void displayAll();
};