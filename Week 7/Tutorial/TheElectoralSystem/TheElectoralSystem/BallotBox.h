#pragma once

#include <iostream>
#include <string>
#include "BallotPaper.h"

using namespace std;

class BallotBox {
private:
	vector<BallotPaper*> _papers; //vector pointer
	PostType _boxtype;

public:
	BallotBox(PostType boxtype);
	PostType getBoxType();
	vector<BallotPaper*> getPapers();
	void addPaper(BallotPaper *p);
};