#include "member.h"

Member::Member(int studID, string name, string course, int contNo) {
	_studID = studID;
	_name = name;
	_course = course;
	_contNo = contNo;
}

int Member::getStudID() {
	return _studID;
}

string Member::getName() {
	return _name;
}

string Member::getCourse() {
	return _course;
}

int Member::getContNo(){
	return _contNo;
}
