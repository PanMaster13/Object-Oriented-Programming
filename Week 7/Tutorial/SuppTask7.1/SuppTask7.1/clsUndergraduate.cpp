#include "clsUndergraduate.h"

clsUndergraduate::clsUndergraduate(string name, string student_number, string program, string major):clsStudent ::clsStudent(name, student_number, program){
	_name = name;
	_student_number = student_number;
	_program = program;
	_major = major;
}

string clsUndergraduate::getMajor() {
	return _major;
}

void clsUndergraduate::displayStudentDetails() {
	std::cout << "Name: " << _name << std::endl;
	std::cout << "Student Number: " << _student_number << std::endl;
	std::cout << "Program Name: " << _program << std::endl;
	std::cout << "Major Name: " << _major << std::endl;
}

