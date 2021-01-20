#pragma once

#include <iostream>
#include <string>
#include <vector>
#include "Candidate.h"

using namespace std;

class BallotPaper {
private:
	vector<Candidate*> _candidates; //vector pointer
	PostType _paperType;
	int _votedCandidate; //position of candidate in candidate vector

public:
	BallotPaper(PostType paperType);
	PostType getPaperType();
	vector<Candidate*> getCandidates();
	int getVotedCandidate();
	void setVotedCandidate(int number);
	void addCandidate(Candidate *c);
};
