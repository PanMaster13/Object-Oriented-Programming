#include "Election.h"

Election::Election() {} //Empty Constructor

//Similar to the DecideWinner method for ElectionCommittee class, the BallotBox class is assumed as a group of Candidates contending similar positions
void Election::announceWinner(BallotBox *box) {

	//Finds position type that will be won by winning candidate
	string position;
	if (box->getBoxType() == President) {
		position = "President";
	}

	else if (box->getBoxType() == VicePresident) {
		position = "VicePresident";
	}

	else if (box->getBoxType() == Secretary) {
		position = "Secretary";
	}

	else {
		position = "Treasurer";
	}

	//Finding winning candidate
	vector<BallotPaper*> paper = box->getPapers();
	vector<Candidate*> candidatelist = paper[0]->getCandidates();
	
	for (int i = 0; i < candidatelist.size(); i++) {
		if (candidatelist[i]->getWonPosition() == true) {
			std::cout << "The candidate " << candidatelist[i]->getName() << " with student ID of " << candidatelist[i]->getStudID() << " has won the position of " << position << std::endl;
		}
	}

}