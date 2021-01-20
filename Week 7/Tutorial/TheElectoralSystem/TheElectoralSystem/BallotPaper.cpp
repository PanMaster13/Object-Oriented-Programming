#include "BallotPaper.h"

BallotPaper::BallotPaper(PostType paperType) {
	_paperType = paperType;
}

PostType BallotPaper::getPaperType() {
	return _paperType;
}

vector<Candidate*> BallotPaper::getCandidates() {
	return _candidates;
}

int BallotPaper::getVotedCandidate() {
	return _votedCandidate;
}

void BallotPaper::setVotedCandidate(int number) {
	_votedCandidate = number;
}

void BallotPaper::addCandidate(Candidate *c) {
	_candidates.push_back(c);
}