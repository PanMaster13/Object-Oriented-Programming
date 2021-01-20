#include "TutorialClass.h"


void TutorialClass::addStudent(clsStudent *std) {
	_students.push_back(std);
}

int TutorialClass::getStudentCount() {
	return _students.size();
}

void TutorialClass::displayAll() {
	for (int i = 0; i < _students.size(); i++)
	{
		std::cout << "\nThis is details of student number " << i + 1 << std::endl;
		_students[i]->displayStudentDetails();
	}
}