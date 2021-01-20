#include "BallotBox.h"

BallotBox::BallotBox(PostType boxtype) {
	_boxtype = boxtype;
}

PostType BallotBox::getBoxType() {
	return _boxtype;
}

vector<BallotPaper*> BallotBox::getPapers() {
	return _papers;
}

void BallotBox::addPaper(BallotPaper *p) {
	_papers.push_back(p);
}