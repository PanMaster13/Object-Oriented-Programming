#include "Voter.h"

//calls base constructor
Voter::Voter(int studID, string name, string course, int contNo) : Member::Member(studID, name, course, contNo) {
	_studID = studID;
	_name = name;
	_course = course;
	_contNo = contNo;
}

void Voter::CheckActive(int current_month, int last_month) {
	int balance = current_month - last_month;

	if (balance > 6){
		_isActive = true;
	}
}

void Voter::Vote(BallotPaper *paper, int number) {
	if (_isActive == true) {
		paper->setVotedCandidate(number);
	}

	else {
		std::cout << "You're not active, so you cannot vote!" << std::endl;
	}
}