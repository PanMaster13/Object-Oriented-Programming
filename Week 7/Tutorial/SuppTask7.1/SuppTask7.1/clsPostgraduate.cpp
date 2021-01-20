#include "clsPostGraduate.h"

clsPostgraduate::clsPostgraduate(string name, string student_number, string program, string rt, int g):clsStudent::clsStudent(name, student_number, program) {
	_name = name;
	_student_number = student_number;
	_program = program;
	_researchTitle = rt;
	_grant = g;
}

int clsPostgraduate::getGrant() {
	return _grant;
}

void clsPostgraduate::displayStudentDetails() {
	std::cout << "Name: " << _name << std::endl;
	std::cout << "Student Number: " << _student_number << std::endl;
	std::cout << "Program Name: " << _program << std::endl;
	std::cout << "Research Title: " << _researchTitle << std::endl;
	std::cout << "Grant: " << _grant << std::endl;
}