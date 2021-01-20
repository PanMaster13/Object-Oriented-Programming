#pragma once

#include <iostream>
#include <string>
#include "member.h"
#include "BallotPaper.h"

using namespace std;

//Inherited from member class
class Voter : public Member {
private:
	bool _isActive = false; //every voter is inactive by default

public:
	Voter(int studID, string name, string course, int contNo);
	void CheckActive(int current_month, int last_month); //decides whether the voter can vote or not
	void Vote(BallotPaper *paper, int number);
};