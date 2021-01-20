#pragma once

#include <iostream>
#include <string>
#include "BallotBox.h"

using namespace std;

class ElectionCommittee {
private:
	string _name;

public:
	ElectionCommittee(string name);
	string getname();
	void countVotes(BallotBox *box); //count votes
	void decideWinner(BallotBox *box); //decides votes (normally executed after counting votes)
};